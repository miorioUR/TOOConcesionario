using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class BDCliente
    {

        private static TablaClientes clientes;

        private BDCliente() { }


        public static TablaClientes Clientes
        {
            get
            {
                if (clientes == null)
                {
                    clientes = new TablaClientes();
                }
                return clientes;
            }
        }

        public static void INSERTCliente(ClienteDato c)
        {
            BDCliente.clientes.Add(c);
        }

        public static ClienteDato SELECTCliente(ClienteDato c)
        {
            return BDCliente.clientes[c.Dni];
        }

        public static void UPDATECliente(ClienteDato c)
        {
            BDCliente.clientes.Remove(c.Dni);
            BDCliente.clientes.Add(c);
        }

        public static void DELETECliente(ClienteDato c)
        {
            BDCliente.clientes.Remove(c.Dni);
        }

    }
}
