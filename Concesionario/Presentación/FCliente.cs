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
    public partial class FCliente : Form
    {
        public FCliente(string n)
        {
            this.Text = n;
            InitializeComponent();
        }

        public void setDNI(String dni, bool e)
        {
            this.tbDNI.Text = dni;
            this.tbDNI.Enabled = e;
        }

        public string getNombre()
        {
            return this.tbNombre.Text;
        }
        public void setNombre(String n, bool e)
        {
            this.tbNombre.Text = n;
            this.tbNombre.Enabled = e;
        }

        public string getTelefono()
        {
            return this.tbTeléfono.Text;
        }
        public void setTelefono(String tf, bool e)
        {
            this.tbTeléfono.Text = tf;
            this.tbTeléfono.Enabled = e;
        }
        public char getCat()
        {
            if (this.rbA.Checked)
            {
                return 'A';
            }
            else if (this.rbB.Checked)
            {
                return 'B';
            }
            else if (this.rbC.Checked)
            {
                return 'C';
            }
            return '0';
        }
    }
}
