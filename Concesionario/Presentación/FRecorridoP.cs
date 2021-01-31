using MDPresupuesto;
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
    public partial class FRecorridoP : Form
    {
        public FRecorridoP(List<Presupuesto> lp)
        {
            InitializeComponent();

            LoadData(lp);

            bindingNavigator1.BindingSource = bindingSource1;
        }

        private void LoadData(List<Presupuesto> lp)
        {
            bindingSource1.DataSource = lp;
            tbID.DataBindings.Add("Text", bindingSource1, "id");
            tbDNI.DataBindings.Add("Text", bindingSource1, "Cliente.dni");
            tbEmpleado.DataBindings.Add("Text", bindingSource1, "Empleado.nombre");
        }
    }
}
