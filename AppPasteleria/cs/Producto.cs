using AppPasteleria.cs.core;

namespace AppPasteleria.cs
{
    class Producto : CantidadAbtractClass
    {
        // ID
        private string codigo;
        private string nombre;
        private float precio;

        public Producto()
        {
            this.Precio = 0;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public float Precio
        {
            get => precio;
            set
            {
                this.precio = value < 0 ? 0 : value;
            }
        }

        public void disminuirCantidad()
        {
            this.Cantidad--;
        }

        public override bool Equals(object obj)
        {
            return obj is Producto producto &&
                   codigo == producto.codigo;
        }
    }
}
