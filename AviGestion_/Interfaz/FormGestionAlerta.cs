using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AviGestion_.Datos;
using AviGestion_.Logica;

namespace AviGestion_.UI
{
    public partial class FormAlertas : Form
    {
        private AlertaLogica logica = new AlertaLogica();
        private Usuario usuarioActual;

        public FormAlertas(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            ConfigurarChart();
            this.Load += FormAlertas_Load;
        }

        private void FormAlertas_Load(object sender, EventArgs e)
        {
            // El flujo normal del CU-08 arranca mostrando las alertas ACTIVAS.
            cmbTipoAlerta.SelectedItem = "Todas";
            cmbEstadoAlerta.SelectedItem = "Activa";
            cmbVistaGrafico.SelectedIndex = 0;
            CargarGrilla();
        }

        private void ConfigurarChart()
        {
            chartAlertas.ChartAreas.Clear();
            chartAlertas.ChartAreas.Add(new ChartArea("area1"));

            chartAlertas.Legends.Clear();
            chartAlertas.Legends.Add(new Legend("leyenda1") { Docking = Docking.Bottom });

            chartAlertas.Titles.Clear();
        }

        private void CargarGrilla()
        {
            DateTime? desde = chkFiltrarFecha.Checked ? dtpDesde.Value.Date : (DateTime?)null;
            DateTime? hasta = chkFiltrarFecha.Checked ? dtpHasta.Value.Date.AddDays(1).AddSeconds(-1) : (DateTime?)null;

            var lista = logica.Buscar(txtBuscar.Text, cmbTipoAlerta.Text, cmbEstadoAlerta.Text, desde, hasta);

            dgvAlertas.AutoGenerateColumns = false;
            dgvAlertas.DataSource = null;
            dgvAlertas.DataSource = lista;

            if (dgvAlertas.Columns.Count > 0)
            {
                dgvAlertas.Columns["colFechaGeneracion"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgvAlertas.Columns["colFechaResolucion"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }

            // Alternativas 2.1 / 6.1 del CU-08: informar cuando no hay alertas para mostrar.
            lblSinResultados.Visible = lista.Count == 0;
            lblSinResultados.Text = lista.Count == 0
                ? (cmbEstadoAlerta.Text == "Activa" && string.IsNullOrWhiteSpace(txtBuscar.Text) && cmbTipoAlerta.Text == "Todas" && !chkFiltrarFecha.Checked
                    ? "No hay alertas activas pendientes en este momento."
                    : "No existen alertas con los criterios aplicados.")
                : "";
        }

        private void Filtro_Changed(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void chkFiltrarFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpDesde.Enabled = chkFiltrarFecha.Checked;
            dtpHasta.Enabled = chkFiltrarFecha.Checked;
            CargarGrilla();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            cmbTipoAlerta.SelectedItem = "Todas";
            cmbEstadoAlerta.SelectedItem = "Todas";
            chkFiltrarFecha.Checked = false;
            CargarGrilla();
        }

        private void dgvAlertas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAlertas.Columns[e.ColumnIndex].Name != "colEstadoAlerta" || e.Value == null) return;

            if (e.Value.ToString() == "Activa")
            {
                e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(180, 30, 30);
                e.CellStyle.Font = new System.Drawing.Font(dgvAlertas.Font, System.Drawing.FontStyle.Bold);
            }
            else
            {
                e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            }
        }

        private void dgvAlertas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvAlertas.Columns[e.ColumnIndex].Name != "colSeleccionarAlerta") return;

            var alerta = (AlertaVista)dgvAlertas.Rows[e.RowIndex].DataBoundItem;
            var resumen = logica.ObtenerResumenProducto(alerta.ProductoId);
            if (resumen == null) return;

            lblVCodigo.Text = resumen.Codigo;
            lblVProducto.Text = resumen.Producto;
            lblVCategoria.Text = resumen.Categoria;
            lblVStockActual.Text = resumen.Stock.ToString();
            lblVStockMin.Text = resumen.StockMinimo.ToString();
            lblVStockMax.Text = resumen.StockMaximo.ToString();
            lblVEstado.Text = resumen.Estado;
            lblVCantAlertas.Text = resumen.CantidadAlertasHistoricas.ToString();
        }

        private void btnAlternarVista_Click(object sender, EventArgs e)
        {
            bool mostrandoGrilla = pnlGrilla.Visible;

            pnlGrilla.Visible = !mostrandoGrilla;
            pnlGraficos.Visible = mostrandoGrilla;

            btnAlternarVista.Text = mostrandoGrilla ? "📋 Ver Grilla" : "📊 Ver Gráficos";

            if (mostrandoGrilla)
                CargarGrafico();
        }

        private void cmbVistaGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrafico();
        }

        private void CargarGrafico()
        {
            chartAlertas.Series.Clear();

            var serie = new Series("Alertas") { IsValueShownAsLabel = true };

            switch (cmbVistaGrafico.SelectedIndex)
            {
                case 0: // Por Tipo de Alerta -> torta
                    serie.ChartType = SeriesChartType.Pie;
                    foreach (var item in logica.ConteoPorTipo())
                        serie.Points.AddXY(item.Etiqueta, item.Cantidad);
                    break;

                case 1: // Por Producto -> torta
                    serie.ChartType = SeriesChartType.Pie;
                    foreach (var item in logica.ConteoPorProducto())
                        serie.Points.AddXY(item.Etiqueta, item.Cantidad);
                    break;

                case 2: // Por Categoría -> torta
                    serie.ChartType = SeriesChartType.Pie;
                    foreach (var item in logica.ConteoPorCategoria())
                        serie.Points.AddXY(item.Etiqueta, item.Cantidad);
                    break;

                case 3: // Por Período (mes) -> barras
                    serie.ChartType = SeriesChartType.Column;
                    serie.Color = System.Drawing.Color.FromArgb(46, 92, 45);
                    foreach (var item in logica.ConteoPorMes())
                        serie.Points.AddXY(item.Etiqueta, item.Cantidad);
                    break;
            }

            chartAlertas.Series.Add(serie);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Desea cerrar la sesión actual?", "Cerrar sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion != DialogResult.Yes) return;

            AviGestion_.Form1 login = new AviGestion_.Form1();
            login.Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu(usuarioActual);
            menu.Show();
            this.Close();
        }

        private void chartAlertas_Click(object sender, EventArgs e)
        {

        }
    }
}