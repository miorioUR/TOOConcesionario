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
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void TSMIAltaC_Click(object sender, EventArgs e)
        {
            Form f = new FormID(0,0);
            f.ShowDialog();
        }

        private void TSMIBajaC_Click(object sender, EventArgs e)
        {
            Form f = new FormID(0,1);
            f.ShowDialog();
        }

        private void TSMIBusquedaC_Click(object sender, EventArgs e)
        {
            Form f = new FormID(0,2);
            f.ShowDialog();
        }

        private void TSMIAltaV_Click(object sender, EventArgs e)
        {
            Form f = new FormID(1,0);
            f.ShowDialog();
        }

        private void TSMIBajaV_Click(object sender, EventArgs e)
        {
            Form f = new FormID(1,1);
            f.ShowDialog();
        }

        private void TSMIBusquedaV_Click(object sender, EventArgs e)
        {
            Form f = new FormID(1,2);
            f.ShowDialog();
        }
    }
}
