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
    public partial class FormCliente : Form
    {
        private int tipo;
        //POST genera un formulario para trabajar con el cliente de DNI introducido, si el tipo es 0 será alta, si es 1 baja y cualquier otro caso búsqueda
        public FormCliente(string DNI, int t)
        {
            this.tipo = t;

            InitializeComponent();
            this.tbDNI.Text = DNI;

            switch (t)
            {
                case 0:
                    this.Text = "Alta de un cliente";
                    break;
                case 1:
                    this.Text = "Baja de un cliente";
                    this.tbNombre.Enabled = false;
                    this.tbTeléfono.Enabled = false;
                    this.rbA.Enabled = false;
                    this.rbB.Enabled = false;
                    this.rbC.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            switch (this.tipo)
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
