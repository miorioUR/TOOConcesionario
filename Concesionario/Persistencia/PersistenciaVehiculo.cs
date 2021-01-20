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
        public static void Añadir(Vehiculo v)
        {
            BD.INSERTVehiculo(new VehiculoDato(v)); //requiere constructor de vehiculodato en publico, al igual que el de vehiculo en la linea 22.solucion?
        }
        public static Vehiculo Buscar(string id)
        {
            if(BD.SELECTVehiculo(id)!=null)
            {
                VehiculoDato dato = BD.SELECTVehiculo(id);
                return new Vehiculo(dato.NumBastidor,dato.Marca,dato.Modelo,dato.Potencia,dato.Precio);
            }
            else
            {
                return null;
            }
        }
        public static void Modificar(Vehiculo v)
        {
            BD.UPDATEVehiculo(new VehiculoDato(v));
        }
        public static void Eliminar(Vehiculo v)
        {
            BD.DELETEVehiculo(new VehiculoDato(v));
        }
        
        public static void AñadirExtra(Vehiculo v, Extra e)
        {
            BD.INSERTExtra(new VehiculoDato(v), new ExtraDato(e));
        }
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
        public static void ModificarExtra(Extra e)
        {
            BD.UPDATEExtra(new ExtraDato(e));
        }
        public static void EliminarExtra(Vehiculo v, Extra e)
        {
            BD.DELETEExtra(new VehiculoDato(v), new ExtraDato(e));
        }
    }
}
