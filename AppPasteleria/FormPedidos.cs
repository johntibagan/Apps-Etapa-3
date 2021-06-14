using System.Collections.Generic;
using System.Windows.Forms;
using AppPasteleria.cs;

namespace AppPasteleria
{
    public partial class FormPedidos : Form
    {

        public FormPedidos()
        {
            InitializeComponent();
        }

        private void FormPedidos_Load(object sender, System.EventArgs e)
        {
            this.actualizarTabla();
        }

        private void tablePedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == colBtnCancelar.Index)
                {
                    Data.pedidos[e.RowIndex].cancelar();
                }
                else if (e.ColumnIndex == this.colBtnEnviar.Index)
                {
                    Data.pedidos[e.RowIndex].enviar();
                }
                this.actualizarTabla();
            }
        }

        public void actualizarTabla()
        {
            tablePedidos.AutoGenerateColumns = false;
            tablePedidos.DataSource = new List<Pedido<Pastel>>();
            tablePedidos.DataSource = Data.pedidos.FindAll(p => p.IsPendiente);
            tablePedidos.Update();
            tablePedidos.Refresh();
        }
    }
}
