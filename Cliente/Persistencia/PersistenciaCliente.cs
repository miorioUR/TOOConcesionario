using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDominio;
using BD;

namespace Persistencia
{
    class PersistenciaCliente
    {
        //Pre: c != null. c no existe.   
        //Post: Añade c
        public static void Añadir(Cliente c)
        {
            BDCliente.INSERTCliente(new ClienteDato(c.Dni, c.Nombre, c.Telefono, PersistenciaCliente.CambioACategoriaDato(c.Valor)));
        }

        //Pre: c != null. 
        //Post: Si c existe lo busca y lo devuelve, en otro caso no hace nada y devuelve null.
        public static Cliente Buscar(Cliente c)
        {;
            if (BDCliente.SELECTCliente(new ClienteDato(c.Dni)) != null){

                ClienteDato dato = BDCliente.SELECTCliente(new ClienteDato(c.Dni));
                return new Cliente(dato.Dni,dato.Nombre,dato.Telefono, PersistenciaCliente.CambioACategoria(dato.Valor));                
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
            BDCliente.UPDATECliente(new ClienteDato(c.Dni, c.Nombre, c.Telefono, PersistenciaCliente.CambioACategoriaDato(c.Valor)));
        }

        //Pre: c != null. c no existe.
        //Post: Elimina c.
        public static void Eliminar(Cliente c)
       {
            BDCliente.DELETECliente(new ClienteDato(c.Dni));            
       }


        public static CategoriaDato CambioACategoriaDato(Categoria c)
        {
            if (c.Equals(CategoriaDato.A))
            {
                return CategoriaDato.A;
            }
            else if (c.Equals(CategoriaDato.B))
            {
                return CategoriaDato.B;
            }
            return CategoriaDato.C;              
        }

        public static Categoria CambioACategoria(CategoriaDato c)
        {
            if (c.Equals(Categoria.A))
            {
                return Categoria.A;
            }
            else if (c.Equals(Categoria.B))
            {
                return Categoria.B;
            }
            return Categoria.C;
        }
    }
}
