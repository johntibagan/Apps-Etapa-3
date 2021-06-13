using AppPasteleria.cs.core;

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
    }
}
