using BaseDatos;
using MDCliente;
using MDPresupuesto;
using PersCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersPresupuestos
{
    public class PersistenciaPresupuesto
    {
        public static void Añadir(Presupuesto p)
        {
            BD.INSERTPresupuesto(new PresupuestoDato(p));
        }
        public static Presupuesto Buscar(Presupuesto p)
        {
            if (BD.SELECTPresupuesto(new PresupuestoDato(p)) != null)
            {
                PresupuestoDato dato = BD.SELECTPresupuesto(new PresupuestoDato(p));
                return new Presupuesto(dato.Id, PersistenciaPresupuesto.CambioAEmpleado(dato.Empleado), PersistenciaPresupuesto.CambioACliente(dato.Cliente), dato.ListaValoraciones);
            }
            else
            {
                return null;
            }
        }
        public static void Modificar(Presupuesto p)
        {
            BD.UPDATEPresupuesto(new PresupuestoDato(p));
        }
        public static void Eliminar(Presupuesto p)
        {
            BD.DELETEPresupuesto(new PresupuestoDato(p));
        }
        public static Empleado CambioAEmpleado(EmpleadoDato e)
        {
            return new Empleado(e.Dni, e.Nombre);
        }
        public static Cliente CambioACliente(ClienteDato c)
        {
            return new Cliente(c.Dni, c.Nombre, c.Telefono, PersistenciaCliente.CambioACategoria(c.Valor));
        }
    }
}
