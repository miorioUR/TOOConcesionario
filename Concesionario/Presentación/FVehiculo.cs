using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FVehiculo : Form
    {
        public FVehiculo(string t)
        {
            this.Text = t;
            InitializeComponent();
        }


        public void setNBastidor(string nB, bool b)
        {
            this.tbNBastidor.Text = nB;
            this.tbNBastidor.Enabled = b;
        }

        public string getMarca()
        {
            return this.tbMarca.Text;
        }

        public void setMarca(string m, bool b)
        {
            this.tbMarca.Text = m;
            this.tbMarca.Enabled = b;
        }

        public string getModelo()
        {
            return this.tbModelo.Text;
        }

        public void setModelo(string m, bool b)
        {
            this.tbModelo.Text = m;
            this.tbModelo.Enabled = b;
        }

        public string getPotencia()
        {
            return this.tbPotencia.Text;
        }

        public void setPotencia(int p, bool b)
        {
            string potencia = p.ToString();
            this.tbPotencia.Text = potencia;
            this.tbPotencia.Enabled = b;
        }

        public string getPrecio()
        {
            return this.tbPrecioRecomendado.Text;
        }

        public void setPrecio(double p, bool b)
        {
            string precio = p.ToString();
            this.tbPrecioRecomendado.Text = precio;
            this.tbPrecioRecomendado.Enabled = b;
        }

        public string getMatricula()
        {
            return this.tbMatricula.Text;
        }

        public void setMatricula(string m, bool b)
        {
            this.tbMatricula.Text = m;
            this.tbMatricula.Enabled = b;
        }

        public string getFMatricula()
        {
            return this.tbFMatricula.Text;
        }

        public void setFMatricula(DateTime f, bool b)
        {
            string fMatricula = f.ToString();
            this.tbFMatricula.Text = fMatricula;
            this.tbFMatricula.Enabled = b;
        }

        public RadioButton getNuevo()
        {
            return rbNuevo;
        }

        public RadioButton getSegMano()
        {
            return rbSMano;
        }

        public void bloqueoPanel(bool b)
        {
            groupBox1.Enabled = b;
        }

        public void visibleBotonCancelar(bool b)
        {
            bCancelar.Visible = b;
        }

        private void rbSMano_CheckedChanged(object sender, EventArgs e)
        {
            this.lFMatricula.Visible = true;
            this.lMatricula.Visible = true;
            this.tbFMatricula.Visible = true;
            this.tbMatricula.Visible = true;
        }
    }
}
