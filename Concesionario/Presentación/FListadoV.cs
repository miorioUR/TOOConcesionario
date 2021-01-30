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
    public partial class FListadoV : Form
    {
        public FListadoV(List<Vehiculo> lv)
        {
            InitializeComponent();
            LoadData(lv);
        }



        public void LoadData(List<Vehiculo> lv)
        {
            int i = 0;
            foreach (Vehiculo v in lv)
            {
                DataGridViewRow row = (DataGridViewRow)dGVListado.Rows[i].Clone();
                row.Cells[0].Value = v.NumBastidor;
                row.Cells[1].Value = v.Marca;
                row.Cells[2].Value = v.Modelo;
                row.Cells[3].Value = v.Potencia;
                row.Cells[4].Value = v.Precio;
                dGVListado.Rows.Add(row);
                i++;
            }
        }
    }
}
