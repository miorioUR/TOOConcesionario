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
        //Pre: p!=null, p no existente
        //Post: Añade un nuevo presupuesto p a la BD
        public static void Añadir(Presupuesto p)
        {
            BD.INSERTPresupuesto(new PresupuestoDato(p));
        }
        //Pre: id con formato válido de presupuesto
        //Post: Devuelve un presupuesto cuya id sea coincidente con la string introducida. Si no existe ninguno con esa id devuelve null
        public static Presupuesto Buscar(string id)
        {
            if (BD.SELECTPresupuesto(id) != null)
            {
                PresupuestoDato dato = BD.SELECTPresupuesto(id);
                return new Presupuesto(dato.Id, Utilidades.Conversores.CambioAEmpleado(dato.Empleado), Utilidades.Conversores.CambioACliente(dato.Cliente), Utilidades.Conversores.CambioAListaValoracion(dato.ListaValoraciones));
            }
            else
            {
                return null;
            }
        }
        //Pre: p!=null, p existente
        //Post: Accede a modificar todos los datos de presupuesto excepto id
        public static void Modificar(Presupuesto p)
        {
            BD.UPDATEPresupuesto(BD.SELECTPresupuesto(p.Id));
        }
        //Pre: p!=null, p ya existente
        //Post: Elimina un presupuesto p de la BD
        public static void Eliminar(Presupuesto p)
        {
            BD.DELETEPresupuesto(BD.SELECTPresupuesto(p.Id));
        }
        //Pre: p!=null, p ya existente, v!= null ,  v no existente
        //Post: Añade una nueva valoracion al presupuesto p a la BD
        public static void AñadirValoracion(Presupuesto p, Valoracion v)
        {
            BD.INSERTValoracion(BD.SELECTPresupuesto(p.Id), new ValoracionDato(v));
        }
        //Pre: p!=null, p ya existente, 
        //Post: Añade una nueva valoracion al presupuesto p a la BD
        public static Valoracion BuscarValoracion(Presupuesto p, string id)
        {
            if (BD.SELECTValoracion(BD.SELECTPresupuesto(p.Id), id) != null)
            {
                ValoracionDato dato = BD.SELECTValoracion(BD.SELECTPresupuesto(p.Id), id);
                return new Valoracion(Utilidades.Conversores.CambioAVehiculo(dato.Vehiculo), dato.Precio);
            }
            else
            {
                return null;
            }
        }
        //Pre: p!=null, p existente, v!=null , v existente
        //Post: Modifica la valoracion v asociada a un presupuesto p
        public static void ModificarValoracion(Presupuesto p, Valoracion v)
        {
            BD.UPDATEValoracion(BD.SELECTPresupuesto(p.Id), BD.SELECTValoracion(BD.SELECTPresupuesto(p.Id), v.Vehiculo.NumBastidor));
        }
        //Pre: p!=null, p existente, v!=null , v existente
        //Post: Elimina una valoracion v asociada al presupuesto p
        public static void EliminarValoracion(Presupuesto p, Valoracion v)
        {
            BD.DELETEValoracion(BD.SELECTPresupuesto(p.Id), Utilidades.Conversores.CambioAValoracionDato(v));
        }
    }
}
