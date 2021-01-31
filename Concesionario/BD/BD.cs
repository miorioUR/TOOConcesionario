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
        //private static TablaValoraciones valoraciones;
        private static TablaExtras extras;
        private static TablaSegundaMano vehiculosSegundaMano;
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
                if (vehiculos == null)
                {
                    vehiculos = new TablaVehiculo();
                }
                return vehiculos;
            }
        }

        public static TablaSegundaMano VehiculosSegundaMano
        {
            get
            {
                if (vehiculosSegundaMano == null)
                    vehiculosSegundaMano = new TablaSegundaMano();
                return vehiculosSegundaMano;
            }
        }

        public static TablaExtras Extras
        {
            get
            {
                if (extras == null)
                    extras = new TablaExtras();
                return extras;
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
            Clientes.Add(c);
        }

        public static ClienteDato SELECTCliente(string dni)
        {
            return Clientes[dni];
        }
        public static List<ClienteDato> SELECTAllCliente()
        {
            List<ClienteDato> lc = new List<ClienteDato>();
            foreach (ClienteDato c in Clientes)
            {
                lc.Add(c);
            }
            return lc;
        }
        public static void UPDATECliente(ClienteDato c)
        {
            Clientes.Remove(c.Dni);
            Clientes.Add(c);
        }

        public static void DELETECliente(ClienteDato c)
        {
            Clientes.Remove(c.Dni);
        }
        public static List<ClienteDato> LISTClientes()
        {
            List<ClienteDato> lcd = Clientes.ToList<ClienteDato>();
            return lcd;
        }
        public static bool CONTAINSCliente(string c)
        {
            if (Clientes.Contains(c))
                return true;
            else
                return false;
        }
        //METODOS VEHICULO-----------------------------
        public static void INSERTVehiculo(VehiculoDato v)
        {
            Vehiculos.Add(v);
        }
        public static VehiculoDato SELECTVehiculo(string numBastidor)
        {
            return Vehiculos[numBastidor];
        }
        public static bool CONTAINSVehiculo(string n)
        {
            if (Vehiculos.Contains(n))
                return true;
            else
                return false;
        }
        public static void UPDATEVehiculo(VehiculoDato v)
        {
            Vehiculos.Remove(v.NumBastidor);
            Vehiculos.Add(v);
        }
        public static bool DELETEVehiculo(VehiculoDato v)
        {
            return Vehiculos.Remove(v);
        }
        public static List<VehiculoDato> SELECTAllVehiculo()
        {
            List<VehiculoDato> lv = new List<VehiculoDato>();
            foreach (VehiculoDato v in Vehiculos)
            {
                lv.Add(v);
            }
            return lv;
        }
        public static void INSERTExtra(VehiculoDato v, ExtraDato e)
        {
            Vehiculos[v.NumBastidor].ListaExtras.Add(e);
            Extras.Add(e);
        }
        public static ExtraDato SELECTExtra(string nombre)
        {
            return Extras[nombre];
        }
        public static void UPDATEExtra(ExtraDato e)
        {
            Extras.Remove(e.Nombre);
            Extras.Add(e);
        }
        public static void DELETEExtra(VehiculoDato v, ExtraDato e)
        {
            Vehiculos[v.NumBastidor].ListaExtras.Remove(e);
            Extras.Remove(e);
        }
        public static void INSERTVehiculoSegundaMano(VehiculoSegundaManoDato v)
        {
            VehiculosSegundaMano.Add(v);
            Vehiculos.Add(new VehiculoDato(new Vehiculo(v.NumBastidor, v.Marca, v.Modelo, v.Potencia, v.Precio)));
        }
        public static VehiculoSegundaManoDato SELECTVehiculoSegundaMano(string numBastidor)
        {
            return VehiculosSegundaMano[numBastidor];
        }
        public static void UPDATEVehiculoSegundaMano(VehiculoSegundaManoDato v)
        {
            VehiculosSegundaMano.Remove(v.NumBastidor);
            Vehiculos.Add(v);
        }
        public static void DELETEVehiculoSegundaMano(VehiculoSegundaManoDato v)
        {
            VehiculosSegundaMano.Remove(v);
            Vehiculos.Remove(v.NumBastidor);
        }
        public static bool CONTAINSVehiculoSegundaMano(string n)
        {
            if (VehiculosSegundaMano.Contains(n))
                return true;
            else
                return false;
        }
        public static List<VehiculoDato> LISTVehiculos()
        {
            List<VehiculoDato> lvd = Vehiculos.ToList<VehiculoDato>();
            return lvd;
        }
        //METODOS PRESUPUESTOS ----------------------------------------
        public static void INSERTPresupuesto(PresupuestoDato p)
        {
            Presupuestos.Add(p);
        }
        public static bool DELETEPresupuesto(PresupuestoDato p)
        {
            return Presupuestos.Remove(p);
        }
        public static void UPDATEPresupuesto(PresupuestoDato p)
        {
            Presupuestos.Remove(p.Id);
            Presupuestos.Add(p);
        }
        public static PresupuestoDato SELECTPresupuesto(string id)
        {
            return Presupuestos[id];
        }
        public static List<PresupuestoDato> LISTPresupuesto()
        {
            List<PresupuestoDato> lpd = Presupuestos.ToList<PresupuestoDato>();
            //lpd.Sort(Utilidades.Comparadores.comparaPresupuestosDNI);
            return lpd;
        }
        public static void INSERTValoracion(PresupuestoDato p, ValoracionDato v)
        {
            Presupuestos[p.id].ListaValoraciones.Add(v);
        }
        public static ValoracionDato SELECTValoracion(PresupuestoDato p, string id)
        {
            foreach (ValoracionDato vd in Presupuestos[p.id].ListaValoraciones)
            {
                if (vd.Vehiculo.NumBastidor.Equals(id))
                {
                    return vd;
                }
            }
            return null;
        }
        public static void UPDATEValoracion(PresupuestoDato p, ValoracionDato v)
        {
            foreach (ValoracionDato vd in p.ListaValoraciones)
            {
                if (vd.Vehiculo.Equals(v.Vehiculo))
                {
                    Presupuestos[p.Id].ListaValoraciones.Remove(vd);
                }
            }
            Presupuestos[p.Id].ListaValoraciones.Add(v);
        }
        public static void DELETEValoracion(PresupuestoDato p, ValoracionDato v)
        {
            Presupuestos[p.Id].ListaValoraciones.Remove(v);
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
    public class TablaExtras : KeyedCollection<string, ExtraDato>
    {
        protected override string GetKeyForItem(ExtraDato e)
        {
            return e.Nombre;
        }
    }
    public class TablaSegundaMano : KeyedCollection<string, VehiculoSegundaManoDato>
    {
        protected override string GetKeyForItem(VehiculoSegundaManoDato item)
        {
            return item.NumBastidor;
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
            this.valor = (CategoriaDato)c.Valor; //Es esto correcto?
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
        private double iva;

        private List<ExtraDato> listaExtras;

        public VehiculoDato(Vehiculo v)
        {
            this.numBastidor = v.NumBastidor;
            this.marca = v.Marca;
            this.modelo = v.Modelo;
            this.potencia = v.Potencia;
            this.precio = v.Precio;
            this.iva = v.Iva;
            this.listaExtras = new List<ExtraDato>();
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
        public double Iva
        {
            get
            { return iva; }
        }
        public List<ExtraDato> ListaExtras
        {
            get
            { return listaExtras; }
        }
    }
    public class VehiculoSegundaManoDato : VehiculoDato
    {
        private string matricula;
        private DateTime fechaMatriculacion;
        private const double IVA = 0.21;

        public VehiculoSegundaManoDato(Vehiculo v, string matr, DateTime fMatr) : base(v)
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
            get { return fechaMatriculacion; }
        }
    }
    public class ExtraDato
    {
        private string nombre;
        private double precio;

        public ExtraDato(Extra e)
        {
            this.nombre = e.Nombre;
            this.precio = e.Precio;
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public double Precio
        {
            get { return precio; }
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
            this.empleado = new EmpleadoDato(p.Empleado.Dni, p.Empleado.Nombre);
            this.cliente = new ClienteDato(p.Cliente);
            this.listaValoraciones = Utilidades.Conversores.CambioAListaValoracionDato(p.ListaValoraciones);
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

        public ValoracionDato(Valoracion v)
        {
            this.vehiculo = Utilidades.Conversores.CambioAVehiculoDato(v.Vehiculo);
            this.precio = v.Precio;
            this.aceptado = v.Aceptado;
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
