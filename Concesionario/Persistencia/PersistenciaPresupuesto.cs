using BaseDatos;
using MDPresupuesto;
using MDCliente;
using MDVehiculo;
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
        public static Presupuesto Buscar(string id)
        {
            if(BD.SELECTPresupuesto(id) != null)
            {
                PresupuestoDato dato = BD.SELECTPresupuesto(id);
                return new Presupuesto(dato.Id, Utilidades.Conversores.CambioAEmpleado(dato.Empleado), Utilidades.Conversores.CambioACliente(dato.Cliente), Utilidades.Conversores.CambioAListaValoracion(dato.ListaValoraciones));
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

    }
}
