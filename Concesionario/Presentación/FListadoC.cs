using MDCliente;
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
    public partial class FListadoC : Form
    {
        public FListadoC(List<Cliente> lc)
        {
            InitializeComponent();
            LoadData(lc);
        }
        public void LoadData(List<Cliente> lc)
        {
            foreach (Cliente c in lc) {
                lbDNI.Items.Add(c.Dni);
                lbNombre.Items.Add(c.Nombre);
            }
        }
    }
}
