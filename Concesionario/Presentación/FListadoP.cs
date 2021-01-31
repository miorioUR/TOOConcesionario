using System;
using System.Collections.Generic;
using System.ComponentModel;
using MDPresupuesto;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FListadoP : Form
    {
        public FListadoP(List<Presupuesto> lp)
        {
            InitializeComponent();
            LoadData(lp);
        }
        public void LoadData(List<Presupuesto> lp)
        {
            int i = 0;
            foreach (Presupuesto p in lp)
            {
                DataGridViewRow row = (DataGridViewRow)dGPListado.Rows[i].Clone();
                row.Cells[0].Value = p.Id;
                row.Cells[1].Value = p.Empleado.Dni;
                row.Cells[2].Value = p.Cliente.Dni;
                row.Cells[3].Value = Utilidades.Calculadora.calcularImporte(p);
                dGPListado.Rows.Add(row);
                i++;
            }
        }
    }
}
