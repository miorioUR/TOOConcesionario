using MDVehiculo;
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
    public partial class FRecorridoV : Form
    {
        public FRecorridoV(List<Vehiculo> lv)
        {
            InitializeComponent();

            LoadData(lv);

            bindingNavigator1.BindingSource = bindingSource1;
        }



        private void LoadData(List<Vehiculo> lv)
        {

            bindingSource1.DataSource = lv;

            textBox1.DataBindings.Add("Text", bindingSource1, "numBastidor");
            textBox2.DataBindings.Add("Text", bindingSource1, "marca");
            textBox3.DataBindings.Add("Text", bindingSource1, "modelo");
            textBox4.DataBindings.Add("Text", bindingSource1, "potencia");
            textBox5.DataBindings.Add("Text", bindingSource1, "precio");


        }
    }
}
