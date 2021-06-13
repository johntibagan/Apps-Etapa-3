using System;

namespace AppPasteleria.cs.core
{
    abstract class PersonaAbtractClass
    {
        private String nombre;
        private int telefono;
        private string direccion;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public abstract void cambiarDireccion(String nueva);
    }
}
