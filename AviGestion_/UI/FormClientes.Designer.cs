namespace AviGestion_.UI
{
    partial class FormClientes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colCuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colHistorial = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlModificar = new System.Windows.Forms.Panel();
            this.lblModificarDatos = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnlModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.pnlHeader.Controls.Add(this.btnVolver);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(210, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Clientes";
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(740, 15);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(140, 30);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver al Menú";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(20, 75);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(300, 22);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(740, 74);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 26);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "+ Agregar Cliente";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCuit,
            this.colNombre,
            this.colApellido,
            this.colEmpresa,
            this.colTelefono,
            this.colAccion,
            this.colHistorial});
            this.dgvClientes.Location = new System.Drawing.Point(20, 110);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(860, 180);
            this.dgvClientes.TabIndex = 3;
            // 
            // colCuit
            // 
            this.colCuit.HeaderText = "CUIT";
            this.colCuit.Name = "colCuit";
            this.colCuit.ReadOnly = true;
            this.colCuit.Width = 120;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 120;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            this.colApellido.Width = 120;
            // 
            // colEmpresa
            // 
            this.colEmpresa.HeaderText = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.ReadOnly = true;
            this.colEmpresa.Width = 150;
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            this.colTelefono.Width = 120;
            // 
            // colAccion
            // 
            this.colAccion.HeaderText = "Acción";
            this.colAccion.Name = "colAccion";
            this.colAccion.ReadOnly = true;
            this.colAccion.Text = "Modificar";
            this.colAccion.UseColumnTextForButtonValue = true;
            this.colAccion.Width = 110;
            // 
            // colHistorial
            // 
            this.colHistorial.HeaderText = "";
            this.colHistorial.Name = "colHistorial";
            this.colHistorial.ReadOnly = true;
            this.colHistorial.Text = "Historial";
            this.colHistorial.UseColumnTextForButtonValue = true;
            this.colHistorial.Width = 110;
            // 
            // pnlModificar
            // 
            this.pnlModificar.BackColor = System.Drawing.Color.White;
            this.pnlModificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlModificar.Controls.Add(this.lblModificarDatos);
            this.pnlModificar.Controls.Add(this.lblCuit);
            this.pnlModificar.Controls.Add(this.txtCuit);
            this.pnlModificar.Controls.Add(this.lblNombre);
            this.pnlModificar.Controls.Add(this.txtNombre);
            this.pnlModificar.Controls.Add(this.lblApellido);
            this.pnlModificar.Controls.Add(this.txtApellido);
            this.pnlModificar.Controls.Add(this.lblEmpresa);
            this.pnlModificar.Controls.Add(this.txtEmpresa);
            this.pnlModificar.Controls.Add(this.lblDireccion);
            this.pnlModificar.Controls.Add(this.txtDireccion);
            this.pnlModificar.Controls.Add(this.lblTelefono);
            this.pnlModificar.Controls.Add(this.txtTelefono);
            this.pnlModificar.Controls.Add(this.btnCancelar);
            this.pnlModificar.Controls.Add(this.btnGuardar);
            this.pnlModificar.Location = new System.Drawing.Point(20, 305);
            this.pnlModificar.Name = "pnlModificar";
            this.pnlModificar.Size = new System.Drawing.Size(860, 230);
            this.pnlModificar.TabIndex = 4;
            // 
            // lblModificarDatos
            // 
            this.lblModificarDatos.AutoSize = true;
            this.lblModificarDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblModificarDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblModificarDatos.Location = new System.Drawing.Point(15, 12);
            this.lblModificarDatos.Name = "lblModificarDatos";
            this.lblModificarDatos.Size = new System.Drawing.Size(130, 20);
            this.lblModificarDatos.TabIndex = 0;
            this.lblModificarDatos.Text = "Modificar Datos";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblCuit.Location = new System.Drawing.Point(15, 50);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(31, 13);
            this.lblCuit.TabIndex = 1;
            this.lblCuit.Text = "CUIT";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(15, 68);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(220, 22);
            this.txtCuit.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblNombre.Location = new System.Drawing.Point(260, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(260, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblApellido.Location = new System.Drawing.Point(505, 50);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 13);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "APELLIDO";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(505, 68);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(220, 22);
            this.txtApellido.TabIndex = 6;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblEmpresa.Location = new System.Drawing.Point(15, 105);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(58, 13);
            this.lblEmpresa.TabIndex = 7;
            this.lblEmpresa.Text = "EMPRESA";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(15, 123);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(220, 22);
            this.txtEmpresa.TabIndex = 8;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblDireccion.Location = new System.Drawing.Point(260, 105);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(60, 13);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "DIRECCIÓN";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(260, 123);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(220, 22);
            this.txtDireccion.TabIndex = 10;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblTelefono.Location = new System.Drawing.Point(505, 105);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 13);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "TELÉFONO";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(505, 123);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(220, 22);
            this.txtTelefono.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(620, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(730, 180);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 30);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.pnlModificar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FormClientes";
            this.Text = "Gestión de Clientes";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.pnlModificar.ResumeLayout(false);
            this.pnlModificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewButtonColumn colAccion;
        private System.Windows.Forms.DataGridViewButtonColumn colHistorial;
        private System.Windows.Forms.Panel pnlModificar;
        private System.Windows.Forms.Label lblModificarDatos;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}