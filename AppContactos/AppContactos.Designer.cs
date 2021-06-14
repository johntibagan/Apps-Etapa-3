
namespace AppContactos
{
    partial class AppContactos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrors = new System.Windows.Forms.Label();
            this.txtOrganizacion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tablaContactos = new System.Windows.Forms.DataGridView();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblErrors);
            this.panel1.Controls.Add(this.txtOrganizacion);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.btnCrear);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblNuevo);
            this.panel1.Location = new System.Drawing.Point(54, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 292);
            this.panel1.TabIndex = 0;
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.BackColor = System.Drawing.SystemColors.Control;
            this.lblErrors.ForeColor = System.Drawing.Color.Maroon;
            this.lblErrors.Location = new System.Drawing.Point(24, 228);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(40, 13);
            this.lblErrors.TabIndex = 13;
            this.lblErrors.Text = "Errores";
            // 
            // txtOrganizacion
            // 
            this.txtOrganizacion.Location = new System.Drawing.Point(84, 200);
            this.txtOrganizacion.Name = "txtOrganizacion";
            this.txtOrganizacion.Size = new System.Drawing.Size(111, 20);
            this.txtOrganizacion.TabIndex = 12;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(84, 152);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(111, 20);
            this.txtTelefono.TabIndex = 11;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(84, 104);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(111, 20);
            this.txtApellidos.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(111, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCrear.Location = new System.Drawing.Point(47, 246);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(95, 32);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Organización";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Teléfono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombres";
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevo.ForeColor = System.Drawing.Color.Blue;
            this.lblNuevo.Location = new System.Drawing.Point(30, 18);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(137, 20);
            this.lblNuevo.TabIndex = 3;
            this.lblNuevo.Text = "Nuevo Contacto";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tablaContactos);
            this.panel2.Location = new System.Drawing.Point(281, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 292);
            this.panel2.TabIndex = 1;
            // 
            // tablaContactos
            // 
            this.tablaContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaContactos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCompleto,
            this.Telefono,
            this.Organizacion,
            this.colBtnEliminar});
            this.tablaContactos.Location = new System.Drawing.Point(3, 18);
            this.tablaContactos.Name = "tablaContactos";
            this.tablaContactos.Size = new System.Drawing.Size(469, 260);
            this.tablaContactos.TabIndex = 0;
            this.tablaContactos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaContactos_CellContentClick);
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "NombreCompleto";
            this.NombreCompleto.Name = "NombreCompleto";
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            // 
            // Organizacion
            // 
            this.Organizacion.DataPropertyName = "Organizacion";
            this.Organizacion.HeaderText = "Organización";
            this.Organizacion.Name = "Organizacion";
            // 
            // colBtnEliminar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.NullValue = "Eliminar";
            this.colBtnEliminar.DefaultCellStyle = dataGridViewCellStyle2;
            this.colBtnEliminar.HeaderText = "Eliminar";
            this.colBtnEliminar.Name = "colBtnEliminar";
            this.colBtnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBtnEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Blue;
            this.lblTitulo.Location = new System.Drawing.Point(334, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(91, 20);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Contactos";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSalir.Location = new System.Drawing.Point(678, 404);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // AppContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AppContactos";
            this.Text = "Contactos";
            this.Load += new System.EventHandler(this.AppContactos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOrganizacion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNuevo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tablaContactos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organizacion;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnEliminar;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Button BtnSalir;
    }
}

