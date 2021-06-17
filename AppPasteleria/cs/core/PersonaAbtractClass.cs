using System;
/**
 * @author  John Tibagan
 * @code    1002709915
 */
namespace AppPasteleria.cs.core
{
    abstract class PersonaAbtractClass
    {
        private String nombre;
        private string telefono;
        private string direccion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public abstract void cambiarDireccion(String nueva);
    }
}
