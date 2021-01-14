using MDCliente;
using MDPresupuesto;
using MDVehiculo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public class BD
    {
        //TABLAS-----------------------
        private static TablaClientes clientes;
        private static TablaVehiculo vehiculos;
        private static TablaPresupuestos presupuestos;
        //CONSTRUCTOR------------------------
        private BD() { }
        //MODIFICACIONES DE TABLAS----------------------------
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
        public static TablaVehiculo Vehiculos
        {
            get
            {
                if (vehiculos == null) vehiculos = new TablaVehiculo();
                return vehiculos;
            }
        }
        public static TablaPresupuestos Presupuestos
        {
            get
            {
                if (presupuestos == null)
                    presupuestos = new TablaPresupuestos();
                return presupuestos;
            }
        }
        //METODOS CLIENTE------------------------------
        public static void INSERTCliente(ClienteDato c)
        {
            BD.clientes.Add(c);
        }

        public static ClienteDato SELECTCliente(ClienteDato c)
        {
            return BD.clientes[c.Dni];
        }

        public static void UPDATECliente(ClienteDato c)
        {
            BD.clientes.Remove(c.Dni);
            BD.clientes.Add(c);
        }

        public static void DELETECliente(ClienteDato c)
        {
            BD.clientes.Remove(c.Dni);
        }
        //METODOS VEHICULO-----------------------------
        public static void INSERTVehiculo(VehiculoDato v)
        {
            vehiculos.Add(v);
        }
        public static VehiculoDato SELECTVehiculo(VehiculoDato v)
        {
            return vehiculos[v.NumBastidor];
        }
        public static void UPDATEVehiculo(VehiculoDato v)
        {
            vehiculos.Remove(vehiculos[v.NumBastidor]);
            vehiculos.Add(v);
        }
        public static bool DELETEVehiculo(VehiculoDato v)
        {
            return vehiculos.Remove(v);
        }
        //METODOS PRESUPUESTOS ----------------------------------------
        public static void INSERTPresupuesto(PresupuestoDato p)
        {
            presupuestos.Add(p);
        }
        public static bool DELETEPresupuesto(string id)
        {
            return presupuestos.Remove(id);
        }
        public static void UPDATEPresupuesto(PresupuestoDato p)
        {
            presupuestos.Remove(p.Id);
            presupuestos.Add(p);
        }
        public static PresupuestoDato SELECTPresupuesto(string id)
        {
            return presupuestos[id];
        }
    }
    //ASIGNACION DE KEYS ------------------------------------
    public class TablaClientes : KeyedCollection<string, ClienteDato>
    {
        protected override string GetKeyForItem(ClienteDato item)
        {
            return item.Dni;
        }
    }
    public class TablaVehiculo : KeyedCollection<string, VehiculoDato>
    {
        protected override string GetKeyForItem(VehiculoDato item)
        {
            return item.NumBastidor;
        }
    }
    public class TablaPresupuestos : KeyedCollection<string, PresupuestoDato>
    {
        protected override string GetKeyForItem(PresupuestoDato p)
        {
            return p.id;
        }
    }
    //CLASES CLIENTE ----------------------------------------------
    public class ClienteDato
    {
        private string dni;
        private string nombre;
        private string telefono;
        private CategoriaDato valor;

        public ClienteDato(Cliente c)
        {
            this.dni = c.Dni;
            this.nombre = c.Nombre;  
            this.telefono = c.Telefono;
            this.valor = (CategoriaDato) c.Valor; //Es esto correcto?
        }
        public ClienteDato(string dni, string nombre, string telefono, CategoriaDato valor)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;
            this.valor = valor;
        }

        public ClienteDato(string dni) : this(new Cliente(dni, null, null, Categoria.A)) { }

        public string Dni
        {
            get { return this.dni; }
        }

        public string Nombre
        {
            get { return this.nombre; }

            set { this.nombre = value; }
        }

        public string Telefono
        {
            get { return this.telefono; }

            set { this.telefono = value; }
        }

        public CategoriaDato Valor
        {
            get { return this.valor; }

            set { this.valor = value; }
        }
    }
    public enum CategoriaDato { A = 5, B = 10, C = 15 };
    //CLASES VEHICULO --------------------------------------
    public class VehiculoDato
    {
        private string numBastidor;
        private string marca;
        private string modelo;
        private int potencia;
        private double precio;

        private List<ExtraDato> listaExtras = null;

        protected VehiculoDato(Vehiculo v)
        {
            this.numBastidor = v.NumBastidor;
            this.marca = v.Marca;
            this.modelo = v.Modelo;
            this.potencia = v.Potencia;
            this.precio = v.Precio * 1.1;
        }

        public string NumBastidor
        {
            get
            { return numBastidor; }
        }
        public string Marca
        {
            get
            { return marca; }
        }
        public string Modelo
        {
            get
            { return modelo; }
        }
        public int Potencia
        {
            get
            { return potencia; }
        }
        public double Precio
        {
            get
            { return precio; }
        }
    }
    public class VehiculoSegundaManoDato : VehiculoDato
    {
        private string matricula;
        private DateTime fechaMatriculacion;
        private const double IVA = 0.21;

        protected VehiculoSegundaManoDato(Vehiculo v, string matr,DateTime fMatr) : base(v)
        {
            this.matricula = matr;
            this.fechaMatriculacion = fMatr;
        }
        public string Matricula
        {
            get { return matricula; }
        }
        public DateTime FechaMatriculacion
        {
            get{ return fechaMatriculacion; }
        }
    }
    public class ExtraDato
    {
        private string nombre;
        private double precio;

        ExtraDato(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
        public string Nombre
        {
            get{ return nombre; }
        }
        public double Precio
        {
            get{ return precio; }
        }
    }
    //CLASES PRESUPUESTOS
    public class PresupuestoDato
    {
        internal string id;
        private DateTime fecha;
        private EmpleadoDato empleado;
        private ClienteDato cliente;
        private EstadoDato estado;

        private List<ValoracionDato> listaValoraciones;

        public PresupuestoDato(Presupuesto p)
        {
            this.id = p.Id;
            this.fecha = DateTime.Now;
            this.empleado = new EmpleadoDato(p.Empleado.Dni,p.Empleado.Nombre);
            this.cliente = new ClienteDato(p.Cliente);
            this.listaValoraciones = p.ListaValoraciones; // Como paso esto a valoraciondatos?
            this.estado = EstadoDato.propuesto;
        }
        public string Id
        {
            get { return id; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
        }
        public EmpleadoDato Empleado
        {
            get { return empleado; }
        }
        public ClienteDato Cliente
        {
            get { return cliente; }
        }
        public List<ValoracionDato> ListaValoraciones
        {
            get { return listaValoraciones; }
        }
        public EstadoDato Estado
        {
            get { return estado; }
        }
    }
    public enum EstadoDato
    {
        aceptado, desestimado, pendiente, propuesto
    }
    public class ValoracionDato
    {
        private VehiculoDato vehiculo;
        private double precio;
        private bool aceptado;

        public ValoracionDato(VehiculoDato v, double p)
        {
            this.vehiculo = v;
            this.precio = p;
            this.aceptado = false;
        }
        public VehiculoDato Vehiculo
        {
            get { return vehiculo; }
        }
        public double Precio
        {
            get { return precio; }
        }
        public bool Aceptado
        {
            get { return aceptado; }
        }
    }
    public class EmpleadoDato
    {
        private String dni, nombre;
        public EmpleadoDato(string iden, string nom)
        {
            this.dni = iden;
            this.nombre = nom;
        }
        public string Dni
        {
            get { return dni; }
        }
        public string Nombre
        {
            get { return nombre; }
        }
    }
}
