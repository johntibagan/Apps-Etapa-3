using System;
using AppPasteleria.cs.core;

namespace AppPasteleria.cs
{
    class Producto : CantidadAbtractClass
    {
        private String nombre;
        private String sabor;
        private String decoracion;
        private float precio;

        public Producto()
        {
            this.Precio = 0;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Sabor { get => sabor; set => sabor = value; }
        public string Decoracion { get => decoracion; set => decoracion = value; }
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

        // Get precio * Cantidad
        public float subTotal()
        {
            return this.Precio * this.Cantidad;
        }
    }
}
