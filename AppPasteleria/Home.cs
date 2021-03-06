using System;
using System.Windows.Forms;
/**
 * @author  John Tibagan
 * @code    1002709915
 */
namespace AppPasteleria
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            using (FormRegistroPedidos formRegistroPedidos = new FormRegistroPedidos())
                formRegistroPedidos.ShowDialog();
        }

        private void lblPedidos_Click(object sender, EventArgs e)
        {
            using (FormPedidos formPedidos = new FormPedidos())
                formPedidos.ShowDialog();
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            using (FormVentas formVentas = new FormVentas())
                formVentas.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
