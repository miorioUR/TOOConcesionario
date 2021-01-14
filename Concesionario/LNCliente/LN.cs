using MDCliente;
using MDPresupuesto;
using PersCliente;
using PersPresupuestos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class LNCliente
    {
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
    public class LNPresupuestos
    {
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
}
