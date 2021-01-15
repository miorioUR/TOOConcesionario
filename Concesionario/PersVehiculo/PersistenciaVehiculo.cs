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
        public static Vehiculo Buscar(Vehiculo v)
        {
            if(BD.SELECTVehiculo(new VehiculoDato(v)) != null)
            {
                VehiculoDato dato = BD.SELECTVehiculo(new VehiculoDato(v));
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
    }
}
