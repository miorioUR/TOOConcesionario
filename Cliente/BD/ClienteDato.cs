using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BD
{    
    public class ClienteDato
    {
        private string dni;
        private string nombre;
        private string telefono;
        private CategoriaDato valor;

        public ClienteDato(string dni, string nombre, string telefono, CategoriaDato valor)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;
            this.valor = valor;
        }

        public ClienteDato(string dni) : this(dni, null, null, CategoriaDato.A) { }

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

        public CategoriaDato Valor
        {
            get { return this.valor; }

            set { this.valor = value; }
        }
    }
}
