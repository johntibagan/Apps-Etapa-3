using System;
using AppPasteleria.cs.core;

namespace AppPasteleria.cs
{
    class Pedido<I> : CantidadAbtractClass where I : Producto
    {
        public static char ESTADO_ENVIADO = 'E',
            ESTADO_CANCELADO = 'C',
            ESTADO_PENDIENTE = 'P';

        private I producto;
        private Cliente cliente;
        private DateTime fechaPedido;
        private DateTime fechaSalida;
        private char estado;

        internal I Producto { get => producto; set => producto = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public char Estado { get => estado; set => estado = value; }

        public Pedido()
        {
            this.fechaPedido = DateTime.Now;
            this.Estado = ESTADO_PENDIENTE;
        }

        // Enviar pedido
        public void enviar()
        {
            this.Estado = ESTADO_ENVIADO;
            this.fechaSalida = DateTime.Now;
        }

        // Cancelar pedido
        public void cancelar()
        {
            this.Estado = ESTADO_CANCELADO;
        }

        public bool valid()
        {
            if (null == Producto)
                throw new Exception("Falta el producto");
            else if (null == Cliente)
                throw new Exception("Falta el Cliente");
            else if (null == FechaPedido)
                throw new Exception("Falta las Fecha Pedido");
            else if (0 == Cantidad)
                throw new Exception("Falta las Cantidad");

            return true;
        }


        public override bool Equals(object obj)
        {
            return obj is Pedido<I> pedido &&
                   fechaPedido == pedido.fechaPedido;
        }

        #region Para_Tablas

        public string ClienteNombre => this.Cliente.Nombre + " - " + this.Cliente.Direccion;
        public string ProductoNombre => this.Producto.Nombre;
        public float ProductoPrecio => this.Producto.Precio;
        public bool IsPendiente => this.Estado == ESTADO_PENDIENTE;
        public bool IsCancelado => this.Estado == ESTADO_CANCELADO;
        public bool IsEnviado => this.Estado == ESTADO_ENVIADO;

        // Get precio * Cantidad
        public float SubTotal => this.Producto.Precio * this.Cantidad;

        #endregion;
    }
}
