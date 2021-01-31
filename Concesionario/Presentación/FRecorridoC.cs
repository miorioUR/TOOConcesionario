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
    public partial class FRecorridoC : Form
    {
        public FRecorridoC(List<Cliente> lc)
        {
            InitializeComponent();
            
            LoadData(lc);

            bindingNavigator1.BindingSource = bindingSource1;
        }



        private void LoadData(List<Cliente> lc)
        {

            bindingSource1.DataSource = lc;

            tbDNI.DataBindings.Add("Text", bindingSource1, "dni");
            tbNombre.DataBindings.Add("Text", bindingSource1, "nombre");
            tbTelefono.DataBindings.Add("Text", bindingSource1, "telefono");

        }
    }
}
