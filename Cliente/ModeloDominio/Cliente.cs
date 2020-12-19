using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{ 
    
    public class Cliente : IEquatable<Cliente>
    {
        private string dni;
        private string nombre;
        private string telefono;
        private Categoria valor;

        public Cliente(string dni, string nombre, string telefono, Categoria valor)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;
            this.valor = valor;
        }

        public Cliente(string dni) : this(dni, null, null, Categoria.A) { }

        public string Dni
        {
            get { return this.dni; }
        }

        public string Nombre
        {
            get { return this.nombre; }

            set { this.nombre = value; }
        }

        public string Telefono
        {
            get { return this.telefono; }

            set { this.telefono = value; }
        }

        public Categoria Valor
        {
            get { return this.valor; }

            set { this.valor = value; }
        }

        public bool Equals(Cliente c)
        {
            if (this.dni == c.dni)
            {
                return true;
            }
            else return false;
        }
    }
}
