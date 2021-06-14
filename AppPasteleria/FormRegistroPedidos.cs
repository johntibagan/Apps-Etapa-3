using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AppPasteleria.cs;

namespace AppPasteleria
{
    public partial class FormRegistroPedidos : Form
    {
        public FormRegistroPedidos()
        {
            InitializeComponent();
        }

        private void FormRegistroPedidos_Load(object sender, System.EventArgs e)
        {
            listPasteles.DataSource = Data.pasteles;
            listPasteles.DisplayMember = "ToString";
            listPasteles.ValueMember = "Codigo";
            listPasteles.Text = "Seleccionar";

            listClientes.DataSource = Data.clientes;
            listClientes.DisplayMember = "ToString";
            listClientes.ValueMember = "Telefono";
            listClientes.Text = "Seleccionar";

            tablaPasteles.AutoGenerateColumns = false;
            tablaPasteles.DataSource = Data.pasteles;

            this.actualizaPedidos();
        }

        private void listClientes_SelectedValueChanged(object sender, System.EventArgs e)
        {
            Cliente cliente = listClientes.SelectedItem as Cliente;
            if (null != cliente)
            {
                txtNombreC.Text = cliente.Nombre;
                txtDireccionC.Text = cliente.Direccion;
                txtTelefonoC.Text = cliente.Telefono;
            }
        }

        private void btnPedido_Click(object sender, System.EventArgs e)
        {
            Cliente cliente = Data.getCliente(
                txtNombreC.Text,
                txtTelefonoC.Text,
                txtDireccionC.Text
            );
            Pedido<Pastel> pedido = new Pedido<Pastel>()
            {
                Producto = listPasteles.SelectedItem as Pastel,
                Cliente = cliente,
                Cantidad = Convert.ToInt32(txtCantidad.Value),
            };

            if (pedido.valid())
                Data.pedidos.Insert(0, pedido);

            this.actualizaPedidos();
        }

        public void actualizaPedidos()
        {
            tablePedidos.AutoGenerateColumns = false;
            tablePedidos.DataSource = new List<Pedido<Pastel>>();
            tablePedidos.DataSource = Data.pedidos;
            tablePedidos.Update();
            tablePedidos.Refresh();

            txtCantidad.ResetText();
            txtDireccionC.ResetText();
            txtNombreC.ResetText();
            txtTelefonoC.ResetText();
            listClientes.ResetText();
            listPasteles.ResetText();

            float total = 0;
            Data.pedidos.ForEach(c => total += c.SubTotal);
            txtTotal.Text = total.ToString();
        }
    }
}
