using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Vehiculo
{
    public class Vehiculo
    {
        internal string numBastidor;
        private string marca;
        private string modelo;
        private int potencia;
        private double precio;

        private List<Extra> listaExtras = null;

        protected Vehiculo(string numBastidor, string marca, string modelo, int potencia, double preciobase)
        {
            this.numBastidor = numBastidor;
            this.marca = marca;
            this.modelo = modelo;
            this.potencia = potencia;
            this.precio = preciobase;
        }

    }
    public class VehiculoSegundaMano : Vehiculo
    {
        private string matricula;
        private DateTime fechaMatriculacion;
        private const double IVA = 0.21;

        protected VehiculoSegundaMano(string numBastidor, string marca, string modelo, int potencia, double preciobase, string matricula, DateTime fechaMatricula):base(numBastidor,marca,modelo,potencia,preciobase)
        {
            this.matricula = matricula;
            this.fechaMatriculacion = fechaMatricula;
        }
    }
    public class VehiculoPrimeraMano : Vehiculo
    {
        private const double IVA = 0.1;

        protected VehiculoPrimeraMano(string numBastidor, string marca, string modelo, int potencia, double preciobase) : base(numBastidor, marca, modelo, potencia, preciobase) { }
    }
    public class Extra
    {
        private string nombre;
        private double precio;

        Extra(string nombre,double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
    }
    public class TablaVehiculo : KeyedCollection<string,Vehiculo>
    {
        protected override string GetKeyForItem(Vehiculo item)
        {
            return item.numBastidor; // cambiar por get con funcionalidad
        }
    }
    public class BDVehiculo
    {
        private static TablaVehiculo vehiculos;
        private BDVehiculo() { }

        public static TablaVehiculo Vehiculos
        {
            get
            {
                if (vehiculos == null) vehiculos = new TablaVehiculo();
                return vehiculos;
            }
        }

        public static void INSERTVehiculo(Vehiculo v)
        {
            vehiculos.Add(v);
        }
        public static Vehiculo SELECTVehiculo(string numBastidor)
        {
            return vehiculos[numBastidor];
        }
        public static void UPDATEVehiculo(Vehiculo v)
        {
            vehiculos.IndexOf(v);//terminar
        }
        public static bool DELETEVehiculo(Vehiculo v)
        {
            return vehiculos.Remove(v);
        }
    }
}
