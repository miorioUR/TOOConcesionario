using MDCliente;
using MDPresupuesto;
using MDVehiculo;
using PersCliente;
using PersPresupuestos;
using PersVehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class LNCliente
    {
        Empleado e;
        internal LNCliente(Empleado emp)
        {
            this.e = emp;
        }


        public void AltaCliente(Cliente c)
        {
            PersistenciaCliente.Añadir(c);
        }
        public bool ExisteCliente(Cliente c)
        {
            return (PersistenciaCliente.Buscar(c) != null);
        }
        public void BajaCliente(Cliente c)
        {
            PersistenciaCliente.Eliminar(c);
        }
        public void ModificarCliente(Cliente c)
        {
            PersistenciaCliente.Modificar(c);
        }
    }
    public class LNVehiculo
    {
        Empleado e;
        internal LNVehiculo(Empleado emp)
        {
            this.e = emp;
        }


        public void AltaVehiculo(Vehiculo v)
        {
            PersistenciaVehiculo.Añadir(v);
        }
        public bool ExisteVehiculo(Vehiculo v)
        {
            return PersistenciaVehiculo.Buscar(v) != null;
        }
        public void BajaVehiculo(Vehiculo v)
        {
            PersistenciaVehiculo.Eliminar(v);
        }
        public void ModificarVehiculo(Vehiculo v)
        {
            PersistenciaVehiculo.Modificar(v);
        }
    }
    public class LNPresupuesto
    {
        Empleado e;
        internal LNPresupuesto(Empleado emp)
        {
            this.e = emp;
        }


        public void AltaPresupuesto(Presupuesto p)
        {
            PersistenciaPresupuesto.Añadir(p);
        }
        public bool ExistePresupuesto(Presupuesto p)
        {
            return (PersistenciaPresupuesto.Buscar(p) != null);
        }
        public void BajaPresupuesto(Presupuesto p)
        {
            PersistenciaPresupuesto.Eliminar(p);
        }
        public void ModificarPresupuesto(Presupuesto p)
        {
            PersistenciaPresupuesto.Modificar(p);
        }
    }
    
    public class LN
    {
        Empleado e;
        LNCliente lncliente;
        LNVehiculo lnvehiculo;
        LNPresupuesto lnpreupuesto;

        public LN(Empleado emp,LNCliente lnc,LNVehiculo lnv, LNPresupuesto lnp)
        {
            this.e = emp;
            this.lncliente = lnc;
            this.lnvehiculo = lnv;
            this.lnpreupuesto = lnp;
        }
    }
}
