using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDatos;
using MDCliente;
using MDPresupuesto;
using MDVehiculo;

namespace Utilidades
{
    public class Comparadores
    {
        public static int comparaPresupuestosDNI(Presupuesto p1, Presupuesto p2)
        {
            if(p1.Equals(null))
            {
                if (p2.Equals(null))
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (p2.Equals(null))
                {
                    return 1;
                }
                else
                {
                    return p1.Cliente.Dni.CompareTo(p2.Cliente.Dni);
                }
            }
        }
        public static int comparaPresupuestosNombre(Presupuesto p1,Presupuesto p2)
        {
            if (p1.Equals(null))
            {
                if (p2.Equals(null))
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (p2.Equals(null))
                {
                    return 1;
                }
                else
                {
                    return p1.Cliente.Nombre.CompareTo(p2.Cliente.Nombre);
                }
            }
        }
        public static int comparaPresupuestosImporte(Presupuesto p1,Presupuesto p2)
        {
            if (p1.Equals(null))
            {
                if (p2.Equals(null))
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (p2.Equals(null))
                {
                    return 1;
                }
                else
                {
                    return Calculadora.calcularImporte(p1).CompareTo(Calculadora.calcularImporte(p2));
                }
            }
        }
        public static int comparaVehiculosNumBastidor(Vehiculo v1,Vehiculo v2)
        {
            if (v1.Equals(null))
            {
                if (v2.Equals(null))
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (v2.Equals(null))
                {
                    return 1;
                }
                else
                {
                    return v1.NumBastidor.CompareTo(v2.NumBastidor);
                }
            }
        }
        public static int comparaVehiculosMarca(Vehiculo v1, Vehiculo v2)
        {
            if (v1.Equals(null))
            {
                if (v2.Equals(null))
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (v2.Equals(null))
                {
                    return 1;
                }
                else
                {
                    return v1.Marca.CompareTo(v2.Marca);
                }
            }
        }
        public static int comparaVehiculosModelo(Vehiculo v1, Vehiculo v2)
        {
            if (v1.Equals(null))
            {
                if (v2.Equals(null))
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (v2.Equals(null))
                {
                    return 1;
                }
                else
                {
                    return v1.Modelo.CompareTo(v2.Modelo);
                }
            }
        }
        public static int comparaVehiculosPotencia(Vehiculo v1, Vehiculo v2)
        {
            if (v1.Equals(null))
            {
                if (v2.Equals(null))
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (v2.Equals(null))
                {
                    return 1;
                }
                else
                {
                    return v1.Potencia.CompareTo(v2.Potencia);
                }
            }
        }
        public static int comparaVehiculosPrecio(Vehiculo v1, Vehiculo v2)
        {
            if (v1.Equals(null))
            {
                if (v2.Equals(null))
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (v2.Equals(null))
                {
                    return 1;
                }
                else
                {
                    return v1.Precio.CompareTo(v2.Precio);
                }
            }
        }
    }
    class Calculadora
    {
        public static double calcularImporte(PresupuestoDato p)
        {
            double importe = 0;
            foreach(ValoracionDato v in p.ListaValoraciones)
            {
                double importevehiculo = v.Vehiculo.Precio;
                if (v.Vehiculo.ListaExtras != null)
                {
                    foreach(ExtraDato e in v.Vehiculo.ListaExtras)
                    {
                        importevehiculo = importevehiculo + e.Precio;
                    }
                }
                importe = importe + importevehiculo * v.Vehiculo.Iva;
            }
            if (p.Cliente.Valor.Equals(CategoriaDato.A)) { importe = importe * 1.05; }
            if (p.Cliente.Valor.Equals(CategoriaDato.B)) { importe = importe * 1.1; }
            else { importe = importe * 1.15; }

            return importe;
        }
        public static double calcularImporte(Presupuesto p)
        {
            double importe = 0;
            foreach (Valoracion v in p.ListaValoraciones)
            {
                double importevehiculo = v.Vehiculo.Precio;
                if (v.Vehiculo.ListaExtras != null)
                {
                    foreach (Extra e in v.Vehiculo.ListaExtras)
                    {
                        importevehiculo = importevehiculo + e.Precio;
                    }
                }
                importe = importe + importevehiculo * v.Vehiculo.Iva;
            }
            if (p.Cliente.Valor.Equals(Categoria.A)) { importe = importe * 1.05; }
            if (p.Cliente.Valor.Equals(Categoria.B)) { importe = importe * 1.1; }
            else { importe = importe * 1.15; }

            return importe;
        }
    }
}
