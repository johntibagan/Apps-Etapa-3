
namespace AppPasteleria
{
    partial class FormRegistroPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPastel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPedidos = new System.Windows.Forms.TabPage();
            this.tabTortas = new System.Windows.Forms.TabPage();
            this.tablaPasteles = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sabor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.listClientes = new System.Windows.Forms.ListBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTelefonoC = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccionC = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnPedido = new System.Windows.Forms.Button();
            this.listPasteles = new System.Windows.Forms.ListBox();
            this.tablePedidos = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPedidos.SuspendLayout();
            this.tabTortas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPasteles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(274, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 20);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Registrar Pedidos Pasteles";
            // 
            // lblPastel
            // 
            this.lblPastel.AutoSize = true;
            this.lblPastel.Location = new System.Drawing.Point(36, 107);
            this.lblPastel.Name = "lblPastel";
            this.lblPastel.Size = new System.Drawing.Size(52, 13);
            this.lblPastel.TabIndex = 6;
            this.lblPastel.Text = "Pastel/es";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPedidos);
            this.tabControl1.Controls.Add(this.tabTortas);
            this.tabControl1.Location = new System.Drawing.Point(260, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(541, 350);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPedidos
            // 
            this.tabPedidos.Controls.Add(this.txtTotal);
            this.tabPedidos.Controls.Add(this.lblTotal);
            this.tabPedidos.Controls.Add(this.tablePedidos);
            this.tabPedidos.ForeColor = System.Drawing.Color.Black;
            this.tabPedidos.Location = new System.Drawing.Point(4, 22);
            this.tabPedidos.Name = "tabPedidos";
            this.tabPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedidos.Size = new System.Drawing.Size(533, 324);
            this.tabPedidos.TabIndex = 1;
            this.tabPedidos.Text = "Pedidos";
            this.tabPedidos.UseVisualStyleBackColor = true;
            // 
            // tabTortas
            // 
            this.tabTortas.Controls.Add(this.tablaPasteles);
            this.tabTortas.ForeColor = System.Drawing.Color.Black;
            this.tabTortas.Location = new System.Drawing.Point(4, 22);
            this.tabTortas.Name = "tabTortas";
            this.tabTortas.Padding = new System.Windows.Forms.Padding(3);
            this.tabTortas.Size = new System.Drawing.Size(533, 324);
            this.tabTortas.TabIndex = 0;
            this.tabTortas.Text = "Pasteles";
            this.tabTortas.UseVisualStyleBackColor = true;
            // 
            // tablaPasteles
            // 
            this.tablaPasteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPasteles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Sabor,
            this.Cantidad,
            this.Precio});
            this.tablaPasteles.Location = new System.Drawing.Point(6, 6);
            this.tablaPasteles.Name = "tablaPasteles";
            this.tablaPasteles.Size = new System.Drawing.Size(468, 264);
            this.tablaPasteles.TabIndex = 4;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Sabor
            // 
            this.Sabor.DataPropertyName = "Sabor";
            this.Sabor.HeaderText = "Sabor";
            this.Sabor.Name = "Sabor";
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Stock";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle5;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(7, 31);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 9;
            this.lblCliente.Text = "Cliente";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(114, 170);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(120, 20);
            this.txtCantidad.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cantidad";
            // 
            // listClientes
            // 
            this.listClientes.FormattingEnabled = true;
            this.listClientes.Location = new System.Drawing.Point(85, 18);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(118, 43);
            this.listClientes.TabIndex = 13;
            this.listClientes.SelectedValueChanged += new System.EventHandler(this.listClientes_SelectedValueChanged);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(23, 84);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(44, 13);
            this.lblNombreCliente.TabIndex = 14;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(103, 76);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(100, 20);
            this.txtNombreC.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTelefonoC);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.txtNombreC);
            this.panel1.Controls.Add(this.txtDireccionC);
            this.panel1.Controls.Add(this.listClientes);
            this.panel1.Controls.Add(this.lblNombreCliente);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Location = new System.Drawing.Point(29, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 187);
            this.panel1.TabIndex = 16;
            // 
            // txtTelefonoC
            // 
            this.txtTelefonoC.Location = new System.Drawing.Point(103, 148);
            this.txtTelefonoC.Name = "txtTelefonoC";
            this.txtTelefonoC.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoC.TabIndex = 20;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(23, 154);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 19;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtDireccionC
            // 
            this.txtDireccionC.Location = new System.Drawing.Point(103, 112);
            this.txtDireccionC.Name = "txtDireccionC";
            this.txtDireccionC.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionC.TabIndex = 18;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(23, 119);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 17;
            this.lblDireccion.Text = "Dirección";
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(79, 399);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(133, 39);
            this.btnPedido.TabIndex = 17;
            this.btnPedido.Text = "Registrar Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // listPasteles
            // 
            this.listPasteles.FormattingEnabled = true;
            this.listPasteles.Location = new System.Drawing.Point(114, 103);
            this.listPasteles.Name = "listPasteles";
            this.listPasteles.Size = new System.Drawing.Size(120, 56);
            this.listPasteles.TabIndex = 18;
            // 
            // tablePedidos
            // 
            this.tablePedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.Producto,
            this.dataGridViewTextBoxColumn1,
            this.FechaPedido,
            this.PrecioUnitario,
            this.SubTotal});
            this.tablePedidos.Location = new System.Drawing.Point(6, 8);
            this.tablePedidos.Name = "tablePedidos";
            this.tablePedidos.Size = new System.Drawing.Size(521, 262);
            this.tablePedidos.TabIndex = 4;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "ClienteNombre";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "ProductoNombre";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // FechaPedido
            // 
            this.FechaPedido.DataPropertyName = "FechaPedido";
            dataGridViewCellStyle6.Format = "G";
            dataGridViewCellStyle6.NullValue = null;
            this.FechaPedido.DefaultCellStyle = dataGridViewCellStyle6;
            this.FechaPedido.HeaderText = "Fecha Pedido";
            this.FechaPedido.Name = "FechaPedido";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.DataPropertyName = "ProductoPrecio";
            dataGridViewCellStyle7.Format = "C";
            dataGridViewCellStyle7.NullValue = null;
            this.PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle7;
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle8.Format = "C";
            dataGridViewCellStyle8.NullValue = null;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle8;
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(343, 282);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(380, 275);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(144, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // FormRegistroPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listPasteles);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblPastel);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Name = "FormRegistroPedidos";
            this.Text = "Registrar Pedidos";
            this.Load += new System.EventHandler(this.FormRegistroPedidos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPedidos.ResumeLayout(false);
            this.tabPedidos.PerformLayout();
            this.tabTortas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPasteles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPastel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTortas;
        private System.Windows.Forms.DataGridView tablaPasteles;
        private System.Windows.Forms.TabPage tabPedidos;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTelefonoC;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDireccionC;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sabor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.ListBox listPasteles;
        private System.Windows.Forms.DataGridView tablePedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}