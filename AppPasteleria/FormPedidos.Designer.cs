
namespace AppPasteleria
{
    partial class FormPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tablePedidos = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnCancelar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colBtnEnviar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablePedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Blue;
            this.lblTitulo.Location = new System.Drawing.Point(461, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(73, 20);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Pedidos";
            // 
            // tablePedidos
            // 
            this.tablePedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.Producto,
            this.Cantidad,
            this.FechaPedido,
            this.Estado,
            this.PrecioUnitario,
            this.SubTotal,
            this.colBtnCancelar,
            this.colBtnEnviar});
            this.tablePedidos.Location = new System.Drawing.Point(32, 94);
            this.tablePedidos.Name = "tablePedidos";
            this.tablePedidos.Size = new System.Drawing.Size(942, 315);
            this.tablePedidos.TabIndex = 3;
            this.tablePedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablePedidos_CellContentClick);
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
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // FechaPedido
            // 
            this.FechaPedido.DataPropertyName = "FechaPedido";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.FechaPedido.DefaultCellStyle = dataGridViewCellStyle1;
            this.FechaPedido.HeaderText = "Fecha Pedido";
            this.FechaPedido.Name = "FechaPedido";
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.DataPropertyName = "ProductoPrecio";
            dataGridViewCellStyle2.Format = "C";
            dataGridViewCellStyle2.NullValue = null;
            this.PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle2;
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle3.Format = "C";
            dataGridViewCellStyle3.NullValue = null;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            // 
            // colBtnCancelar
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.NullValue = "Cancelar";
            this.colBtnCancelar.DefaultCellStyle = dataGridViewCellStyle4;
            this.colBtnCancelar.HeaderText = "Cancelar";
            this.colBtnCancelar.Name = "colBtnCancelar";
            this.colBtnCancelar.Text = "";
            // 
            // colBtnEnviar
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle5.NullValue = "Enviar";
            this.colBtnEnviar.DefaultCellStyle = dataGridViewCellStyle5;
            this.colBtnEnviar.HeaderText = "Enviar";
            this.colBtnEnviar.Name = "colBtnEnviar";
            this.colBtnEnviar.Text = "";
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 450);
            this.Controls.Add(this.tablePedidos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormPedidos";
            this.Text = "           ";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView tablePedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnCancelar;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnEnviar;
    }
}