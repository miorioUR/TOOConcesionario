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
        public LNCliente(Empleado emp)
        {
            this.e = emp;
        }


        public void AltaCliente(Cliente c)
        {
            PersistenciaCliente.Añadir(c);
        }
        public bool ExisteCliente(Cliente c)
        {
            return (PersistenciaCliente.Buscar(c.Dni) != null);
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
        public LNVehiculo(Empleado emp)
        {
            this.e = emp;
        }


        public void AltaVehiculo(Vehiculo v)
        {
            PersistenciaVehiculo.Añadir(v);
        }
        public bool ExisteVehiculo(string numBastidor)
        {
            return PersistenciaVehiculo.Existe(numBastidor);
        }
        public void BajaVehiculo(Vehiculo v)
        {
            PersistenciaVehiculo.Eliminar(v);
        }
        public void ModificarVehiculo(Vehiculo v)
        {
            PersistenciaVehiculo.Modificar(v);
        }
        public List<Vehiculo> BuscarTodosVehiculos()
        {
            return PersistenciaVehiculo.BuscarTodos();
        }
        public Vehiculo BuscarVehiculo(string v)
        {
            return PersistenciaVehiculo.Buscar(v);
        }
        public void AltaExtra(Vehiculo v, Extra e)
        {
            PersistenciaVehiculo.AñadirExtra(v, e);
        }
        public bool ExisteExtra(Extra e)
        {
            return PersistenciaVehiculo.BuscarExtra(e.Nombre) != null;
        }
        public void BajaExtra(Vehiculo v, Extra e)
        {
            PersistenciaVehiculo.EliminarExtra(v, e);
        }
        public void ModificarExtra(Extra e)
        {
            PersistenciaVehiculo.ModificarExtra(e);
        }
        public void AltaVehiculoSegundaMano(VehiculoSegundaMano v)
        {
            PersistenciaVehiculo.AñadirVehiculoSegundaMano(v);
        }
        public VehiculoSegundaMano BuscarVehiculoSegundaMano(string numBastidor)
        {
            return PersistenciaVehiculo.BuscarVehiculoSegundaMano(numBastidor);
        }
        public void BajaVehiculoSegundaMano(VehiculoSegundaMano v)
        {
            PersistenciaVehiculo.EliminarVehiculoSegundaMano(v);
        }
        public void ModificarVehiculoSegundaMano(VehiculoSegundaMano v)
        {
            PersistenciaVehiculo.ModificarVehiculoSegundaMano(v);
        }
        public bool ExisteVehiculoSegundaMano(string numBastidor)
        {
            return PersistenciaVehiculo.ExisteVehiculoSegundaMano(numBastidor);
        }
    }
    public class LNPresupuesto
    {
        Empleado e;
        public LNPresupuesto(Empleado emp)
        {
            this.e = emp;
        }

        public void AltaPresupuesto(Presupuesto p)
        {
            PersistenciaPresupuesto.Añadir(p);
        }
        public bool ExistePresupuesto(Presupuesto p)
        {
            return (PersistenciaPresupuesto.Buscar(p.Id) != null);
        }
        public void BajaPresupuesto(Presupuesto p)
        {
            PersistenciaPresupuesto.Eliminar(p);
        }
        public void ModificarPresupuesto(Presupuesto p)
        {
            PersistenciaPresupuesto.Modificar(p);
        }
        public void AltaValoracion(Presupuesto p, Valoracion v)
        {
            PersistenciaPresupuesto.AñadirValoracion(p, v);
        }
        public bool ExisteValoracion(Presupuesto p, Valoracion v)
        {
            return PersistenciaPresupuesto.BuscarValoracion(p, v.Vehiculo.NumBastidor) != null;
        }
        public void BajaValoracion(Presupuesto p, Valoracion v)
        {
            PersistenciaPresupuesto.EliminarValoracion(p, v);
        }
        public void ModificarValoracion(Presupuesto p, Valoracion v)
        {
            PersistenciaPresupuesto.ModificarValoracion(p, v);
        }
    }

    public class LN
    {
        Empleado e;
        LNCliente lncliente;
        LNVehiculo lnvehiculo;
        LNPresupuesto lnpreupuesto;

        public LN(Empleado emp, LNCliente lnc, LNVehiculo lnv, LNPresupuesto lnp)
        {
            this.e = emp;
            this.lncliente = lnc;
            this.lnvehiculo = lnv;
            this.lnpreupuesto = lnp;
        }
    }
}
