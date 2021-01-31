﻿using MDCliente;
using BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace PersCliente
{
    public class PersistenciaCliente
    {
        //Pre: c != null. c no existe.   
        //Post: Añade c a la tabla de clientes de la BD
        public static void Añadir(Cliente c)
        {
            BD.INSERTCliente(new ClienteDato(c.Dni, c.Nombre, c.Telefono, Conversores.CambioACategoriaDato(c.Valor)));
        }

        //Pre: dni es una string con formato valido. 
        //Post: Si el cliente con dni existe lo busca y lo devuelve, en otro caso no hace nada y devuelve null.
        public static Cliente Buscar(string dni)
        {
            if (BD.SELECTCliente(dni) != null)
            {
                ClienteDato dato = BD.SELECTCliente(dni);
                return new Cliente(dato.Dni, dato.Nombre, dato.Telefono, Conversores.CambioACategoria(dato.Valor));
            }
            else
            {
                return null;
            }
        }

        //Pre: c != null. c existe.  
        //Post: Modifica c.
        public static void Modificar(Cliente c)
        {
            BD.UPDATECliente(new ClienteDato(c.Dni, c.Nombre, c.Telefono, Conversores.CambioACategoriaDato(c.Valor)));
        }

        //Pre: c != null. c no existe.
        //Post: Elimina c.
        public static void Eliminar(Cliente c)
        {
            BD.DELETECliente(new ClienteDato(c.Dni));
        }
        public static List<Cliente> ListarClientes()
        {
            return Conversores.CambioAListaCliente(BD.LISTClientes());
        }
    }
}