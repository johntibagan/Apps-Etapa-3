using AppPasteleria.cs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppPasteleria
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        public void actualizarTabla()
        {
            tableVentas.AutoGenerateColumns = false;
            tableVentas.DataSource = new List<Pedido<Pastel>>();
            tableVentas.DataSource = Data.pedidos.FindAll(p => p.IsEnviado);
            tableVentas.Update();
            tableVentas.Refresh();
        }
    }
}
