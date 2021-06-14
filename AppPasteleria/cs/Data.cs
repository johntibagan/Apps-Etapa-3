using System.Collections.Generic;

namespace AppPasteleria.cs
{
    class Data
    {
        public static List<Pastel> pasteles = new List<Pastel>()
        {
            new Pastel() { Codigo = "1", Nombre="Torta", Cantidad=10,Decoracion="", Sabor="Chocolate",Precio=2100f },
            new Pastel() { Codigo = "2", Nombre="Torta", Cantidad=10,Decoracion="", Sabor="Vainilla",Precio=2000f },
            new Pastel() { Codigo = "3", Nombre="Gelato", Cantidad=10,Decoracion="", Sabor="",Precio=2500f },
            new Pastel() { Codigo = "4", Nombre="Tiramisú", Cantidad=10,Decoracion="", Sabor="",Precio=3000f },
        };

        public static List<Cliente> clientes = new List<Cliente>
        {
            new Cliente(){Nombre="John",Telefono= "319XXXXXXX",Direccion= "Tunja Calle N # N" },
            new Cliente(){Nombre="Diana",Telefono= "320XXXXXXX",Direccion= " Cra Z # Z" },
            new Cliente(){Nombre="Juan",Telefono= "313XXXXXXX",Direccion= "Tunja Cra S # S" },
            new Cliente(){Nombre="Claudia",Telefono= "311XXXXXXX",Direccion= "Tunja Cra V # V" }

        };

        public static List<Pedido<Pastel>> pedidos = new List<Pedido<Pastel>>();

        // No instanciar
        private Data()
        {
        }

        public static Cliente getCliente(string nombre, string telefono, string direccion)
        {
            Cliente cliente = new Cliente() { Nombre = nombre, Telefono = telefono, Direccion = direccion };
            if (cliente.valid())
            {
                Cliente existe = Data.clientes.Find(c => c.Equals(cliente));
                if (null != existe)
                    return existe;
                else
                    Data.clientes.Add(cliente);
            }

            return cliente;
        }
    }
}
