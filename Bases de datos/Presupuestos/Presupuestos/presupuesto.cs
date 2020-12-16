using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presupuestos
{

    public class Presupuesto
    {
        internal string ID;
        private DateTime fecha;
        private Empleado empleado;
        private Cliente cliente;
        private Valoracion[] valoraciones;
        private Estado estado;

        public Presupuesto(string id, Empleado e, Cliente c, Valoracion[] v)
        {
            this.ID = id;
            this.fecha = DateTime.Now;
            this.empleado = e;
            this.cliente = c;
            this.valoraciones = v;
            this.estado = Estado.propuesto;
        }
    }   
    public enum Estado
    {
        aceptado,desestimado,pendiente, propuesto
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
    }
    public class TablaPresupuestos : KeyedCollection<string, Presupuesto>
    {
        protected override string GetKeyForItem(Presupuesto p)
        {
            return p.ID;
        }
    }
    public class BDPresupuestos
    {
        private static TablaPresupuestos presupuestos;
        public BDPresupuestos() { }
        public static TablaPresupuestos Presupuestos
        {
            get
            {
                if (presupuestos == null)
                    presupuestos = new TablaPresupuestos();
                return presupuestos;
            }
        }
        public static void INSERT(Presupuesto p)
        {
            presupuestos.Add(p);
        }
        public static bool DELETE(string id)
        {
            return presupuestos.Remove(id);
        }
        public static void UPDATE(Presupuesto p)
        {

        }
        public static Presupuesto SELECT(string id)
        {
            return presupuestos[id];
        }
    }
}
public class Empleado
{
    private String DNI, nombre;
}
public class Cliente
{

}
public class Vehiculo
{

}