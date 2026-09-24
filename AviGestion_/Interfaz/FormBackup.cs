using System;
using System.Windows.Forms;
using AviGestion_.Logica;

namespace AviGestion_.UI
{
    public partial class FormBackup : Form
    {
        private BackupLogica logica = new BackupLogica();
        private Usuario usuarioActual;

        public FormBackup(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void btnSeleccionarCarpeta_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txtCarpeta.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnGenerarBackup_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.ForeColor = System.Drawing.Color.FromArgb(46, 92, 45);
                lblResultado.Text = "Generando backup, por favor espere...";
                Application.DoEvents();

                string ruta = logica.GenerarBackup(txtCarpeta.Text, usuarioActual.Nombre, usuarioActual.Rol);

                lblResultado.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
                lblResultado.Text = $"✓ Backup generado correctamente en:\n{ruta}";
            }
            catch (Exception ex)
            {
                lblResultado.ForeColor = System.Drawing.Color.FromArgb(180, 30, 30);
                lblResultado.Text = "✗ " + ex.Message;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Desea cerrar la sesión actual?", "Cerrar sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion != DialogResult.Yes) return;

            BitacoraLogica.Registrar(usuarioActual.Nombre, "Cierre de Sesión", "Seguridad");

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
    }
}