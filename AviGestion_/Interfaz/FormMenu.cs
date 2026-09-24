using AviGestion_.Interfaz;
using AviGestion_.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviGestion_.UI
{
    public partial class FormMenu : Form
    {
        private Usuario usuarioActual;
        public FormMenu(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            ConfigurarVisibilidadPorRol();
        }

        private void btnUsuarios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios usuarios = new FormUsuarios(usuarioActual);
            usuarios.Show();
            this.Hide();
        }

        private void ConfigurarVisibilidadPorRol()
        {
            // Por defecto, ocultamos todo excepto Ayuda (que ven todos)
            btnClientes.Visible = false;
            btnUsuarios.Visible = false;
            btnPedidos.Visible = false;
            btnProductos.Visible = false;
            btnAsignarPedidos.Visible = false;
            btnStock.Visible = false;
            btnCategorias.Visible = false;
            btnVehiculos.Visible = false;
            btnAyuda.Visible = true;
            btnBitacora.Visible = false;
            btnBackup.Visible = false;
            lblProductosDescripcion.Visible = false;
            lblStockDescripcion.Visible = false;



            switch (usuarioActual.Rol)
            {
                case "Administrador":
                    btnClientes.Visible = true;
                    btnUsuarios.Visible = true;
                    btnStock.Visible = false;
                    btnProductos.Visible = false;
                    btnBitacora.Visible = true;
                    btnBackup.Visible = true;
                    break;

                case "Administrador de pedidos":
                    btnPedidos.Visible = true;
                    break;

                case "Jefe de Deposito":
                    btnProductos.Visible = true;
                    btnAsignarPedidos.Visible = true;
                    btnVehiculos.Visible = true;
                    btnStock.Visible = true;
                    btnCategorias.Visible = true;
                    lblProductosDescripcion.Visible = true;
                    lblStockDescripcion.Visible = true;
                    break;
            }
        }

        private void btnClientes_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes frmCliente = new FormClientes();
            frmCliente.Show();
            this.Hide();
        }

        private void btnProductos_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblProductosTitulo_Click(object sender, EventArgs e)
        {
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProducto frm = new FormProducto(usuarioActual);
            frm.Show();
            this.Hide();
        }




        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            FormProducto frm = new FormProducto(usuarioActual);
            frm.Show();
            this.Hide();
        }

        private void btnStock_Click_1(object sender, EventArgs e)
        {
            FormCargaStock frm = new FormCargaStock(usuarioActual);
            frm.Show();
            this.Hide();
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            FormBitacora frm = new FormBitacora(usuarioActual);
            frm.Show();
            this.Hide();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            FormBackup frm = new FormBackup(usuarioActual);
            frm.Show();
            this.Hide();
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
    }

}