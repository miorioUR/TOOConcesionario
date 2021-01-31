using MDVehiculo;
using BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersVehiculo
{
    public class PersistenciaVehiculo
    {
        //Pre: v != null. v no existente ya en la tabla.   
        //Post: Añade v a la tabla de clientes de la BD
        public static void Añadir(Vehiculo v)
        {
            BD.INSERTVehiculo(new VehiculoDato(v));
        }
        //Pre: id es el numero de Bastidor de un vehiculo != null, con un formato valido. 
        //Post: Si existe un vehiculo con ese numBastidor, lo devuelve. En caso contrario solo devuelve null.
        public static Vehiculo Buscar(string id)
        {
            if (BD.SELECTVehiculo(id) != null)
            {
                VehiculoDato dato = BD.SELECTVehiculo(id);
                return new Vehiculo(dato.NumBastidor, dato.Marca, dato.Modelo, dato.Potencia, dato.Precio);
            }
            else
            {
                return null;
            }
        }
        //Pre: n es un número de bastidor con formato valido.
        //Post: Devuelve true si pertenece algún vehiculo a ese número de bastidor.
        public static bool Existe(string n)
        {
            return BD.CONTAINSVehiculo(n);
        }

        //Pre: v != null. v existente en la BD.  
        //Post: Permite modificar todos los valores de v excepto numBastidor.
        public static void Modificar(Vehiculo v)
        {
            BD.UPDATEVehiculo(BD.SELECTVehiculo(v.NumBastidor));
        }
        //Pre: v existente, v!= null 
        //Post: Elimina v de la base de datos. No elimina sus extras aunque no esten en otros vehiculos
        public static void Eliminar(Vehiculo v)
        {
            BD.DELETEVehiculo(BD.SELECTVehiculo(v.NumBastidor));
        }
        //Pre:
        //Post: Devuelve todos los vehiculos almacenados.
        public static List<Vehiculo> BuscarTodos()
        {
            List<Vehiculo> lv = new List<Vehiculo>();
            foreach (VehiculoDato v in BD.SELECTAllVehiculo())
            {
                lv.Add(new Vehiculo(v.NumBastidor, v.Marca, v.Modelo, v.Potencia, v.Precio));
            }
            return lv;
        }
        //Pre: e!=null, e no existente, v !=null,v ya existente
        //Post: Añade un extra al vehiculo v y a la lista de extras
        public static void AñadirExtra(Vehiculo v, Extra e)
        {
            BD.INSERTExtra(new VehiculoDato(v), new ExtraDato(e));
        }
        //Pre: nombre con formato válido para extra
        //Post: devuelve un extra con el nombre introducido, en caso de que no exista devuelve null
        public static Extra BuscarExtra(string nombre)
        {
            if (BD.SELECTExtra(nombre) != null)
            {
                ExtraDato dato = BD.SELECTExtra(nombre);
                return new Extra(dato.Nombre, dato.Precio);
            }
            else
            {
                return null;
            }
        }
        //Pre: e != null. e existente en la BD.  
        //Post: Permite modificar todos los valores de e excepto nombre.
        public static void ModificarExtra(Extra e)
        {
            BD.UPDATEExtra(BD.SELECTExtra(e.Nombre));
        }
        //Pre: e!=null, e existente perteneciente a un v ya existente, v!=null
        //Post: Elimina el extra e del vehiculo v y de la tabla de extras
        public static void EliminarExtra(Vehiculo v, Extra e)
        {
            BD.DELETEExtra(BD.SELECTVehiculo(v.NumBastidor), BD.SELECTExtra(e.Nombre));
        }
        //Pre: v!=null, v ya creado
        //Post: Añade un vehiculoSegundaMano v a la luista de vehiculosSegundaMano y un vehiculo correspondiente a sus datos a la lista de vehiculos
        public static void AñadirVehiculoSegundaMano(VehiculoSegundaMano v)
        {
            BD.INSERTVehiculoSegundaMano(new VehiculoSegundaManoDato(new Vehiculo(v.NumBastidor, v.Marca, v.Modelo, v.Potencia, v.Precio), v.Matricula, v.FechaMatriculacion));
        }
        //Pre: id con formato válido para un numero de bastidor de vehiculo
        //Post: devuelve un vehiculoSegundaMano con el numBastidor introducido, en caso de que no exista devuelve null
        public static VehiculoSegundaMano BuscarVehiculoSegundaMano(string id)
        {
            if (BD.SELECTVehiculoSegundaMano(id) != null)
            {
                VehiculoSegundaManoDato dato = BD.SELECTVehiculoSegundaMano(id);
                return new VehiculoSegundaMano(dato.NumBastidor, dato.Marca, dato.Modelo, dato.Potencia, dato.Precio, dato.Matricula, dato.FechaMatriculacion);
            }
            else
            {
                return null;
            }
        }
        //Pre: v != null. v existente en la BD.  
        //Post: Permite modificar todos los valores de v excepto numBastidor.
        public static void ModificarVehiculoSegundaMano(VehiculoSegundaMano v)
        {
            BD.UPDATEVehiculoSegundaMano(BD.SELECTVehiculoSegundaMano(v.NumBastidor));
        }
        //Pre: v!=null, v existente tanto en tablaSegundaMano como en TablaVehiculo
        //Post: Elimina el vehiculoSegundaMano v de ambas tablas
        public static void EliminarVehiculoSegundaMano(VehiculoSegundaMano v)
        {
            BD.DELETEVehiculoSegundaMano(BD.SELECTVehiculoSegundaMano(v.NumBastidor));
        }
        //Pre: n es un número de bastidor con formato valido.
        //Post: Devuelve true si pertenece algún vehiculo a ese número de bastidor.
        public static bool ExisteVehiculoSegundaMano(string n)
        {
            return BD.CONTAINSVehiculoSegundaMano(n);
        }
        public static List<Vehiculo> ListarVehiculos()
        {
            return Utilidades.Conversores.CambioAListaVehiculo(BD.LISTVehiculos());
        }
    }
}
