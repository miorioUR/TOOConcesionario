using MDCliente;
using MDPresupuesto;
using Utilidades;
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
        LogicaNegocio.LNPresupuesto lnp;
        public FListadoC(LogicaNegocio.LNPresupuesto l)
        {
            InitializeComponent();
            this.lnp = l;
            List<Presupuesto> lc = lnp.ListaPresupuestosDNI();
            LoadData(lc);
        }
        public void LoadData(List<Presupuesto> lc)
        {
            foreach (Presupuesto p in lc) {
                lbDNI.Items.Add(p.Cliente.Dni);
                lbNombre.Items.Add(p.Cliente.Nombre);
                lbImporte.Items.Add(Utilidades.Calculadora.calcularImporte(p));
            }
        }

        private void btDNI_Click(object sender, EventArgs e)
        {
            List<Presupuesto> lc = lnp.ListaPresupuestosDNI();
            LoadData(lc);
        }

        private void btNombre_Click(object sender, EventArgs e)
        {
            List<Presupuesto> lc = lnp.ListaPresupuestosNombre();
            LoadData(lc);
        }

        private void btImporte_Click(object sender, EventArgs e)
        {
            List<Presupuesto> lc = lnp.ListaPresupuestosImporte();
            LoadData(lc);
        }
    }
}
