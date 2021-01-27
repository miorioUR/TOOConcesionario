using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDVehiculo
{
    public class Vehiculo : IEquatable<Vehiculo>
    {
        private string numBastidor;
        private string marca;
        private string modelo;
        private int potencia;
        private double precio;
        private double iva = 0.1;

        private List<Extra> listaExtras = null;

        public Vehiculo(string numBastidor, string marca, string modelo, int potencia, double preciobase)
        {
            this.numBastidor = numBastidor;
            this.marca = marca;
            this.modelo = modelo;
            this.potencia = potencia;
            this.precio = preciobase;
        }

        public string NumBastidor
        {
            get
            { return numBastidor; }
            set
            { numBastidor = value; }
        }
        public string Marca
        {
            get
            { return marca; }
            set
            { marca = value; }
        }
        public string Modelo
        {
            get
            { return modelo; }
            set
            { modelo = value; }
        }
        public int Potencia
        {
            get
            { return potencia; }
            set
            { potencia = value; }
        }
        public double Precio
        {
            get
            { return precio; }
            set
            { precio = value; }
        }
        public double Iva
        {
            get
            { return iva;}
            set
            { precio = value; }
        }
        public List<Extra> ListaExtras
        {
            get
            { return listaExtras; }
            set
            { listaExtras = value; }
        }
        public bool Equals(Vehiculo v)
        {
            return this.numBastidor==v.numBastidor;
        }
    }
    public class VehiculoSegundaMano : Vehiculo
    {
        private string matricula;
        private DateTime fechaMatriculacion;
        private const double IVA = 0.21;

        public VehiculoSegundaMano(string numBastidor, string marca, string modelo, int potencia, double preciobase, string matricula, DateTime fechaMatricula) : base(numBastidor, marca, modelo, potencia, preciobase)
        {
            base.Iva = IVA;
            this.matricula = matricula;
            fechaMatriculacion = fechaMatricula;
        }
        public string Matricula
        {
            get
            { return matricula; }
            set
            { matricula = value; }
        }
        public DateTime FechaMatriculacion
        {
            get
            { return fechaMatriculacion; }
            set
            { fechaMatriculacion = value; }
        }
    }
    public class Extra : IEquatable<Extra>
    {
        private string nombre;
        private double precio;

        public Extra(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
        public string Nombre
        {
            get
            { return nombre; }
            set
            { nombre = value; }
        }
        public double Precio
        {
            get
            { return precio; }
            set
            { precio = value; }
        }
        public bool Equals(Extra e2)
        {
            return e2.nombre==this.nombre;
        }
    }
}
