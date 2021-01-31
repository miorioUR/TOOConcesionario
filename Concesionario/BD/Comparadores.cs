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
        public static int comparaClienteDNI(Cliente c1, Cliente c2)
        {
            if (c1.Equals(null))
            {
                if (c2.Equals(null))
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
                if (c2.Equals(null))
                {
                    return 1;
                }
                else
                {
                    return c1.Dni.CompareTo(c2.Dni);
                }
            }
        }
        public static int comparaClienteNombre(Cliente c1, Cliente c2)
        {
            if (c1.Equals(null))
            {
                if (c2.Equals(null))
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
                if (c2.Equals(null))
                {
                    return 1;
                }
                else
                {
                    return c1.Nombre.CompareTo(c2.Nombre);
                }
            }
        }
        public static int comparaClienteImporte(Cliente c1, Cliente c2)
        {
            if (c1.Equals(null))
            {
                if (c2.Equals(null))
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
                if (c2.Equals(null))
                {
                    return 1;
                }
                else
                {
                    return Calculadora.calcularPago(c1).CompareTo(Calculadora.calcularPago(c2));
                }
            }
        }
    }
    public class Calculadora
    {
        public static double calcularImporte(PresupuestoDato p)
        {
            double importe = 0;
            foreach(ValoracionDato v in p.ListaValoraciones)
            {
                importe = importe + v.Precio;
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
                importe = importe + v.Precio;
            }
            if (p.Cliente.Valor.Equals(Categoria.A)) { importe = importe * 1.05; }
            if (p.Cliente.Valor.Equals(Categoria.B)) { importe = importe * 1.1; }
            else { importe = importe * 1.15; }

            return importe;
        }
        public static double calcularPago(Cliente c)
        {
            double pago = 0;
            foreach (PresupuestoDato p in BD.Presupuestos)
            {
                if (p.Cliente.Dni.Equals(c.Dni)) 
                {
                    pago = calcularImporte(p);
                }
            }
            return pago;
        }
        public static double calcularPrecio(VehiculoDato v)
        {
            double importevehiculo = v.Precio;
            if (v.ListaExtras != null)
            {
                foreach (ExtraDato e in v.ListaExtras)
                {
                    importevehiculo = importevehiculo + e.Precio;
                }
            }
            return importevehiculo * v.Iva;
        }
        public static double calcularPrecio(Vehiculo v)
        {
            double importevehiculo = v.Precio;
            if (v.ListaExtras != null)
            {
                foreach (Extra e in v.ListaExtras)
                {
                    importevehiculo = importevehiculo + e.Precio;
                }
            }
            return importevehiculo * v.Iva;
        }
    }
}
