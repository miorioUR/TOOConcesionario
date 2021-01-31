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
    public partial class FPresupuesto : Form
    {
        public FPresupuesto(string n)
        {
            this.Text = n;
            InitializeComponent();
        }

        public void setDNI(String dni, bool e)
        {
            this.tbDNI.Text = dni;
            this.tbDNI.Enabled = e;
        }

        public void setID(String id, bool e)
        {
            this.tbIDPresupuesto.Text = id;
            this.tbIDPresupuesto.Enabled = e;
        }
        public void setEmpleado(String em, bool e)
        {
            this.tbEmpleado.Text = em;
            this.tbEmpleado.Enabled = e;
        }
        public string getNumBastidor()
        {
            return this.tbNumBastidor.Text;
        }
        public double getPrecio()
        {
            if (tbPrecio.Text == "") return 0;
            return Double.Parse(this.tbPrecio.Text);
        }
        public void ocultarValoracion()
        {
            this.lbNumBastidor.Visible = false;
            this.lbPrecio.Visible = false;
            this.tbNumBastidor.Visible = false;
            this.tbPrecio.Visible = false;
            this.btAñadirValoracion.Text = "Eliminar";
        }

    }
}
