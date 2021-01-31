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
        LogicaNegocio.LNCliente lnc;
        public FListadoC(LogicaNegocio.LNCliente l)
        {
            InitializeComponent();
            this.lnc = l;
            List<Cliente> lc = lnc.ListaClientesDNI();
            LoadData(lc);
        }
        public void LoadData(List<Cliente> lc)
        {
            lbDNI.Items.Clear();
            lbNombre.Items.Clear();
            lbImporte.Items.Clear();
            foreach (Cliente c in lc) {
                lbDNI.Items.Add(c.Dni);
                lbNombre.Items.Add(c.Nombre);
                lbImporte.Items.Add(Calculadora.calcularPago(c));
            }
        }

        private void btDNI_Click(object sender, EventArgs e)
        {
            List<Cliente> lc = lnc.ListaClientesDNI();
            LoadData(lc);
        }

        private void btNombre_Click(object sender, EventArgs e)
        {
            List<Cliente> lc = lnc.ListaClientesNombre();
            LoadData(lc);
        }

        private void btImporte_Click(object sender, EventArgs e)
        {
            List<Cliente> lc = lnc.ListaClientesImporte();
            LoadData(lc);
        }
    }
}
