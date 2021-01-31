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
    public partial class FID : Form
    {
        private int tipo;
        //POST: Inicia el Formulario con 0 para cliente, con 1 para vehículo y con cualquier otro entero para presupuesto.
        public FID(int t)
        {
            InitializeComponent();
            this.tipo = t;
            if (t == 0)
            {
                this.lbID.Text = "DNI:";
                this.lbID.Location = new Point(54, 19);
            }
            if (t==1)
            {
                this.lbID.Text = "Número de bastidor:";
            }
        }

        public string getID()
        {
            return this.tbID.Text;
        }
    }
}
