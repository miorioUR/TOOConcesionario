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
            foreach (Valoracion v in lv)
            {
                lvd.Add(new ValoracionDato(v));
            }
            return lvd;
        }
        public static List<Valoracion> CambioAListaValoracion(List<ValoracionDato> lvd)
        {
            List<Valoracion> lv = new List<Valoracion>();
            foreach (ValoracionDato v in lvd)
            {
                lv.Add(new Valoracion(new Vehiculo(v.Vehiculo.NumBastidor, v.Vehiculo.Marca, v.Vehiculo.Modelo, v.Vehiculo.Potencia, v.Vehiculo.Precio), v.Precio));
            }
            return lv;
        }
        public static List<Cliente> CambioAListaCliente(List<ClienteDato> lcd)
        {
            List<Cliente> lc = new List<Cliente>();
            foreach (ClienteDato c in lcd)
            {
                lc.Add(new Cliente(c.Dni,c.Nombre,c.Telefono,Conversores.CambioACategoria(c.Valor)));
            }
            return lc;
        }
        public static List<Vehiculo> CambioAListaVehiculo(List<VehiculoDato> lvd)
        {
            List<Vehiculo> lv = new List<Vehiculo>();
            foreach (VehiculoDato v in lvd)
            {
                lv.Add(new Vehiculo(v.NumBastidor,v.Marca,v.Modelo,v.Potencia,v.Precio));
            }
            return lv;
        }
        public static List<Presupuesto> CambioAListaPresupuesto(List<PresupuestoDato> lpd)
        {
            List<Presupuesto> lp = new List<Presupuesto>();
            foreach (PresupuestoDato p in lpd)
            {
                lp.Add(new Presupuesto(p.Id,Conversores.CambioAEmpleado(p.Empleado),Conversores.CambioACliente(p.Cliente),Conversores.CambioAListaValoracion(p.ListaValoraciones)));
            }
            return lp;
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
        public static Vehiculo CambioAVehiculo(VehiculoDato vd)
        {
            return new Vehiculo(vd.NumBastidor, vd.Marca, vd.Modelo, vd.Potencia, vd.Precio);
        }
        public static ValoracionDato CambioAValoracionDato(Valoracion v)
        {
            return new ValoracionDato(v);
        }
    }
}