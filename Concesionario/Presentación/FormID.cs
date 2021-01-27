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
    public partial class FormID : Form
    {
        private int tipo;
        private int accion;
        //POST: Inicia el Formulario con 0 para cliente y con cualquier otro entero para vehículo. 0 para alta, 1 para baja y cualquier otro para búsqueda. 
        public FormID(int t, int a)
        {
            InitializeComponent();
            this.tipo = t;
            this.accion = a;
            if (t == 0)
            {
                this.lbID.Text = "DNI:";
                this.lbID.Location = new Point(54, 19);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (this.tipo == 0)
            {
                switch (this.accion)
                {
                    case 0:
                        Form f0 = new FormCliente(this.tbID.Text, 0);
                        f0.ShowDialog();
                        break;
                    case 1:
                        Form f1 = new FormCliente(this.tbID.Text, 1);
                        f1.ShowDialog();
                        break;
                    default:
                        Form f2 = new FormCliente(this.tbID.Text, 0);
                        f2.ShowDialog();
                        break;
                }
                this.Close();
            }
            else
            {
                switch (this.accion)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
