using System;

namespace AppPasteleria.cs
{
    class Pastel : Producto
    {
        private string sabor;
        private string decoracion;

        public string Sabor { get => sabor; set => sabor = value; }
        public string Decoracion { get => decoracion; set => decoracion = value; }


        public new string ToString => this.Nombre + " - " + this.Sabor;
    }
}
