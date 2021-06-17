using AppContactos.cs.core;
/**
 * @author  John Tibagan
 * @code    1002709915
 */
namespace AppContactos.cs
{
    class Contacto : PersonaAbtractClass
    {
        private string telefono;
        private string organizacion;

        public Contacto()
        {
        }

        public string Telefono { get => telefono; set => telefono = value; }
        public string Organizacion { get => organizacion; set => organizacion = value; }

        public override bool Equals(object obj)
        {
            return obj is Contacto contacto &&
                   telefono == contacto.telefono;
        }

        public bool valid()
        {

            return true;
        }
    }
}
