using System;
using AppPasteleria.cs.core;

namespace AppPasteleria.cs
{
    class Pedido : CantidadAbtractClass
    {
        public static char ESTADO_ENVIADO = 'E',
            ESTADO_CANCELADO = 'C',
            ESTADO_PENDIENTE = 'P';

        private Producto producto;
        private Cliente cliente;
        private DateTime fechaPedido;
        private DateTime fechaSalida;
        private char estado;

        internal Producto Producto { get => producto; set => producto = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public char Estado { get => estado; set => estado = value; }

        Pedido()
        {
        }
        // Gloabl | Registrar un pedido
        public static Pedido registrar(Producto producto, Cliente cliente, int cantidad)
        {
            Pedido pedido = new Pedido();
            pedido.Producto = producto;
            pedido.Cliente = cliente;
            pedido.Cantidad = cantidad;
            pedido.fechaPedido = new DateTime();
            pedido.Estado = ESTADO_PENDIENTE;

            return pedido;
        }

        // Enviar pedido
        public void enviar()
        {
            this.Estado = ESTADO_ENVIADO;
            this.fechaSalida = new DateTime();
        }

        // Cancelar pedido
        public void cancelar()
        {
            this.Estado = ESTADO_CANCELADO;
        }
    }
}
