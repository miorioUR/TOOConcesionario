using BaseDatos;
using MDCliente;
using MDPresupuesto;
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
        public static List<ValoracionDato> CambioAListValoracionDato(List<Valoracion> lv)
        {
            List<ValoracionDato> lvd = new List<ValoracionDato>();
            foreach(Valoracion v in lv)
            {
                lvd.Add(new ValoracionDato(new VehiculoDato(v.Vehiculo),v.Precio));
            }
            return lvd;
        }
    }
}