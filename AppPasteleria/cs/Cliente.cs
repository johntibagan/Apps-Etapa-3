using AppPasteleria.cs.core;
using System;

namespace AppPasteleria.cs
{
    class Cliente : PersonaAbtractClass
    {
        public Cliente()
        {
        }

        public override void cambiarDireccion(string nueva)
        {
            this.Direccion = nueva;
        }

        public override bool Equals(object obj)
        {
            return obj is Cliente cliente &&
                   Telefono == cliente.Telefono;
        }

        public new string ToString => this.Nombre;

        internal bool valid()
        {
            if (null == Nombre)
                throw new Exception("El nombre es requerido");
            else if (null == Telefono)
                throw new Exception("El teléfono es requerido");
            else if (null == Direccion)
                throw new Exception("La dirección es requerida");

            return true;
        }
    }
}
