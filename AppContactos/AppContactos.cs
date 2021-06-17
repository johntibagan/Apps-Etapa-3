using AppContactos.cs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * @author  John Tibagan
 * @code    1002709915
 */
namespace AppContactos
{
    public partial class AppContactos : Form
    {
        public AppContactos()
        {
            InitializeComponent();
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            Contacto contacto = new Contacto()
            {
                Nombres = txtNombre.Text,
                Apellidos = txtApellidos.Text,
                Telefono = txtTelefono.Text,
                Organizacion = txtOrganizacion.Text
            };

            if (contacto.valid())
            {
                if (Data.existe(contacto))
                    this.error("Ya existe el contacto con el Teléfono: " + contacto.Telefono);
                else
                {
                    Data.contactos.Insert(0, contacto);
                    this.reset();
                    this.actualizarTabla();
                }
            }
        }

        private void AppContactos_Load(object sender, EventArgs e)
        {
            actualizarTabla();
            lblErrors.Visible = false;
        }

        private void tablaContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == colBtnEliminar.Index)
                {
                    Contacto actual = Data.contactos[e.RowIndex];
                    Data.contactos = Data.contactos.FindAll(c => !c.Equals(actual));
                    this.actualizarTabla();
                }
            }
        }
        public void actualizarTabla()
        {
            tablaContactos.AutoGenerateColumns = false;
            tablaContactos.DataSource = new List<Contacto>();
            tablaContactos.DataSource = Data.contactos;
        }
        public void reset()
        {
            txtNombre.ResetText();
            txtApellidos.ResetText();
            txtTelefono.ResetText();
            txtOrganizacion.ResetText();
        }

        public async void error(string mensaje)
        {
            lblErrors.Visible = true;
            lblErrors.Text = mensaje;
            await Task.Delay(2000);
            lblErrors.Visible = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
