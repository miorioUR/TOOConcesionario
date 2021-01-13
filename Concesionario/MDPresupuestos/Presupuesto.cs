using MDCliente;
using MDVehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDPresupuesto
{
    public class Presupuesto
    {
        internal string id;
        private DateTime fecha;
        private Empleado empleado;
        private Cliente cliente;
        private Estado estado;

        private List<Valoracion> listaValoraciones;

        public Presupuesto(string i, Empleado e, Cliente c, List<Valoracion> v)
        {
            this.id = i;
            this.fecha = DateTime.Now;
            this.empleado = e;
            this.cliente = c;
            this.listaValoraciones = v;
            this.estado = Estado.propuesto;
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public Empleado Empleado
        {
            get { return empleado; }
            set { empleado = value; }
        }
        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public List<Valoracion> ListaValoraciones
        {
            get { return listaValoraciones; }
            set { listaValoraciones = value; }
        }
        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
    public enum Estado
    {
        aceptado, desestimado, pendiente, propuesto
    }
    public class Valoracion
    {
        private Vehiculo vehiculo;
        private double precio;
        private bool aceptado;

        public Valoracion(Vehiculo v, double p)
        {
            this.vehiculo = v;
            this.precio = p;
            this.aceptado = false;
        }
        public Vehiculo Vehiculo
        {
            get { return vehiculo; }
            set { vehiculo = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public bool Aceptado
        {
            get { return aceptado; }
            set { aceptado = value; }
        }
    }
    public class Empleado
    {
        private String dni, nombre;
        protected Empleado(string iden, string nom)
        {
            this.dni = iden;
            this.nombre = nom;
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
