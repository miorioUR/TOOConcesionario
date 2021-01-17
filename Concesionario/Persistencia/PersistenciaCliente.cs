using MDCliente;
using BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersCliente
{
    public class PersistenciaCliente
    {
        //Pre: c != null. c no existe.   
        //Post: Añade c
        public static void Añadir(Cliente c)
        {
            BD.INSERTCliente(new ClienteDato(c.Dni, c.Nombre, c.Telefono, PersistenciaCliente.CambioACategoriaDato(c.Valor)));
        }

        //Pre: c != null. 
        //Post: Si c existe lo busca y lo devuelve, en otro caso no hace nada y devuelve null.
        public static Cliente Buscar(Cliente c)
        {
            if (BD.SELECTCliente(new ClienteDato(c.Dni)) != null)
            {
                ClienteDato dato = BD.SELECTCliente(new ClienteDato(c.Dni));
                return new Cliente(dato.Dni, dato.Nombre, dato.Telefono, PersistenciaCliente.CambioACategoria(dato.Valor));
            }
            else
            {
                return null;
            }
        }

        //Pre: c != null. c no existe.  
        //Post: Modifica c.
        public static void Modificar(Cliente c)
        {
            BD.UPDATECliente(new ClienteDato(c.Dni, c.Nombre, c.Telefono, PersistenciaCliente.CambioACategoriaDato(c.Valor)));
        }

        //Pre: c != null. c no existe.
        //Post: Elimina c.
        public static void Eliminar(Cliente c)
        {
            BD.DELETECliente(new ClienteDato(c.Dni));
        }
    }
}
