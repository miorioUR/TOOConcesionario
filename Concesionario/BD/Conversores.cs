using BaseDatos;
using MDCliente;
using MDPresupuesto;
using MDVehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class Conversores
    {
        public static CategoriaDato CambioACategoriaDato(Categoria c)
        {
            if (c.Equals(CategoriaDato.A))
            {
                return CategoriaDato.A;
            }
            else if (c.Equals(CategoriaDato.B))
            {
                return CategoriaDato.B;
            }
            return CategoriaDato.C;
        }

        public static Categoria CambioACategoria(CategoriaDato c)
        {
            if (c.Equals(Categoria.A))
            {
                return Categoria.A;
            }
            else if (c.Equals(Categoria.B))
            {
                return Categoria.B;
            }
            return Categoria.C;
        }
        public static List<ValoracionDato> CambioAListaValoracionDato(List<Valoracion> lv)
        {
            List<ValoracionDato> lvd = new List<ValoracionDato>();
            foreach(Valoracion v in lv)
            {
                lvd.Add(new ValoracionDato(new VehiculoDato(v.Vehiculo),v.Precio));
            }
            return lvd;
        }
        public static List<Valoracion> CambioAListaValoracion(List<ValoracionDato> lvd)
        {
            List<Valoracion> lv = new List<Valoracion>();
            foreach (Valoracion v in lv)
            {
                lv.Add(new Valoracion(new Vehiculo(v.Vehiculo.NumBastidor,v.Vehiculo.Marca,v.Vehiculo.Modelo,v.Vehiculo.Potencia,v.Vehiculo.Precio), v.Precio));
            }
            return lv;
        }
        public static Empleado CambioAEmpleado(EmpleadoDato e)
        {
            return new Empleado(e.Dni, e.Nombre);
        }
        public static Cliente CambioACliente(ClienteDato c)
        {
            return new Cliente(c.Dni, c.Nombre, c.Telefono, CambioACategoria(c.Valor));
        }
        public static VehiculoDato CambioAVehiculoDato(Vehiculo v)
        {
            return new VehiculoDato(v);
        }
    }
}