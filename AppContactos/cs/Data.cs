using System;
using System.Collections.Generic;
/**
 * @author  John Tibagan
 * @code    1002709915
 */
namespace AppContactos.cs
{
    class Data
    {
        public static List<Contacto> contactos = new List<Contacto>()
        {
            new Contacto(){Nombres= "John", Apellidos="Tibagan", Telefono="3190000000", Organizacion="UNAD"}
        };
        private Data()
        {
        }

        internal static bool existe(Contacto contacto)
        {
            return Data.contactos.FindIndex(c => c.Equals(contacto)) >= 0;
        }
    }
}
