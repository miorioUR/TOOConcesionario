using LogicaNegocio;
using MDPresupuesto;
using MDVehiculo;
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
    public partial class FBase : Form
    {
        private Empleado e;
        private LNCliente lnC;
        private LNVehiculo lnV;
        private LNPresupuesto lnP;
        private LN ln;

        public FBase()
        {
            this.e = new Empleado("1234", "Pepe");
            this.lnC = new LNCliente(e);
            this.lnV = new LNVehiculo(e);
            this.lnP = new LNPresupuesto(e);
            LN ln = new LN(e,lnC,lnV,lnP);
            InitializeComponent();
        }

        private void TSMIAltaC_Click(object sender, EventArgs e)
        {
            FID i = new FID(0);
            DialogResult r = i.ShowDialog();
            string DNI = i.getID();

            if (r == DialogResult.OK)
            {
                FCliente fc = null;

                if (DNI == "" || this.lnC.ExisteCliente(DNI))
                {
                    DialogResult dr = MessageBox.Show("Ya existe un cliente con ese DNI o no ha rellenado el campo 'DNI'.", "¿Quieres introducir otro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        i.Dispose();
                        this.TSMIAltaC_Click(sender, e);
                    }
                }
                else
                {
                    fc = new FCliente("Alta Cliente");
                    fc.setDNI(DNI, false);
                    DialogResult dr = fc.ShowDialog();

                    if (dr == DialogResult.OK)
                    {

                        if (fc.getNombre() != "" &&  fc.getTelefono() != "")
                        {
                                Cliente c = new Cliente(DNI, fc.getNombre(), fc.getTelefono(), Categoria.A);
                                lnC.AltaCliente(c);
                        }
                        else
                        {
                            DialogResult error = MessageBox.Show("Debes introducir todos los datos del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                fc.Dispose();
            }
            i.Dispose();
        }
        private void TSMIBajaC_Click(object sender, EventArgs e)
        {
            FID i = new FID(0);
            DialogResult r = i.ShowDialog();
            string DNI = i.getID();

            if (r == DialogResult.OK)
            {
                if (this.lnC.ExisteCliente(DNI))
                {
                    FCliente fc = new FCliente("Baja Cliente");
                    Cliente c = null;

                    if (lnC.ExisteCliente(DNI))
                    {
                        c = lnC.BuscarCliente(DNI);
                        fc.setDNI(DNI, false);
                        fc.setNombre(c.Nombre, false);
                        fc.setTelefono(c.Telefono, false);
                        fc.setCat(c.Valor, false);
                    }
                    DialogResult dd = fc.ShowDialog();

                    if (dd == DialogResult.OK)
                    {
                        DialogResult aviso = MessageBox.Show("¿Estás seguro que desea dar de baja a ese cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (aviso == DialogResult.Yes)
                        {
                            this.lnC.BajaCliente(c);
                        }
                        MessageBox.Show("Cliente eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    fc.Dispose();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("¿Quieres introducir otro?", "No existe un cliente con ese dni", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        i.Dispose();
                        this.TSMIBajaV_Click(sender, e);
                    }
                }
                i.Dispose();
            }
        }

        private void TSMIBusquedaC_Click(object sender, EventArgs e)
        {
            FID f = new FID(0);
            f.ShowDialog();
        }

        private void recorridoUnoAUnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Cliente> lc = this.lnC.BuscarTodosClientes();
            FRecorridoC fc = new FRecorridoC(lc);
            fc.ShowDialog();
        }
        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Cliente> lc = this.lnC.BuscarTodosClientes();
            FListadoC fc = new FListadoC(lc);
            fc.ShowDialog();
        }

        private void TSMIAltaV_Click(object sender, EventArgs e)
        {
            FID i = new FID(1);
            DialogResult r = i.ShowDialog();
            string numBastidor = i.getID();

            if (r == DialogResult.OK)
            {
                FVehiculo fv = null;

                if (numBastidor == "" || this.lnV.ExisteVehiculo(numBastidor))
                {
                    DialogResult dr = MessageBox.Show("Ya existe un vehiculo con ese número de bastidor o no ha rellenado el campo 'número de bastidor'.", "¿Quieres introducir otro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        i.Dispose();
                        this.TSMIAltaV_Click(sender, e);
                    }
                }
                else
                {
                    fv = new FVehiculo("Alta Vehiculo");
                    fv.setNBastidor(numBastidor, false);
                    DialogResult dr = fv.ShowDialog();

                    if (dr == DialogResult.OK)
                    {

                        if (fv.getMarca() != "" && fv.getModelo() != "" && fv.getPotencia() != null && fv.getPrecio() != "" && (fv.getNuevo().Checked == true || fv.getSegMano().Checked == true))
                        {
                            int potencia = Int32.Parse(fv.getPotencia());
                            double precio = Double.Parse(fv.getPrecio());

                            if (fv.getSegMano().Checked == true)
                            {
                                // Vehiculo segunda mano
                                if (fv.getMatricula() != "" && fv.getFMatricula() != "")
                                {
                                    DateTime fMatricula = DateTime.Parse(fv.getFMatricula());
                                    VehiculoSegundaMano vsm = new VehiculoSegundaMano(numBastidor, fv.getMarca(), fv.getModelo(), potencia, precio, fv.getMatricula(), fMatricula);
                                    lnV.AltaVehiculoSegundaMano(vsm);
                                }
                            }
                            else
                            {
                                // Vehiculo nuevo
                                Vehiculo vv = new Vehiculo(numBastidor, fv.getMarca(), fv.getModelo(), potencia, precio);
                                lnV.AltaVehiculo(vv);

                            }
                        }
                        else
                        {
                            DialogResult error = MessageBox.Show("Debes introducir todos los datos del vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                fv.Dispose();
            }
            i.Dispose();
        }

        private void TSMIBajaV_Click(object sender, EventArgs e)
        {
            FID i = new FID(1);
            DialogResult r = i.ShowDialog();
            string numBastidor = i.getID();

            if (r == DialogResult.OK)
            {                
                if (this.lnV.ExisteVehiculo(numBastidor))
                {
                    FVehiculo fv = new FVehiculo("Baja vehiculo");
                    Vehiculo vv = null;
                    VehiculoSegundaMano vs = null;

                    if (lnV.ExisteVehiculo(numBastidor))
                    {
                        vv = lnV.BuscarVehiculo(numBastidor);
                        fv.setNBastidor(numBastidor, false);
                        fv.setMarca(vv.Marca, false);
                        fv.setModelo(vv.Modelo, false);
                        fv.setPotencia(vv.Potencia, false);
                        fv.setPrecio(vv.Precio, false);

                        if (lnV.ExisteVehiculoSegundaMano(numBastidor))
                        {
                            vs = lnV.BuscarVehiculoSegundaMano(numBastidor);
                            fv.setMatricula(vs.Matricula, false);
                            fv.setFMatricula(vs.FechaMatriculacion, false);
                            RadioButton s = fv.getSegMano();
                            s.Checked = true;
                        }
                    }

                    fv.bloqueoPanel(false);
                    DialogResult dd = fv.ShowDialog();

                    if (dd == DialogResult.OK)
                    {
                        DialogResult aviso = MessageBox.Show("¿Estás seguro que desea dar de baja a ese vehiculo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (aviso == DialogResult.Yes)
                        {
                            if (fv.getMatricula() != "")
                            {
                                this.lnV.BajaVehiculoSegundaMano(vs);
                            }
                            else
                            {
                                this.lnV.BajaVehiculo(vv);
                            }
                        }
                        MessageBox.Show("Vehiculo eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    fv.Dispose();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("¿Quieres introducir otro?", "No existe un vehiculo con ese número de bastidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        i.Dispose();
                        this.TSMIBajaV_Click(sender, e);
                    }
                }
                i.Dispose();
            }
        }

        private void TSMIBusquedaV_Click(object sender, EventArgs e)
        {
            FID i = new FID(1);
            DialogResult r = i.ShowDialog();
            string numBastidor = i.getID();

            if (r == DialogResult.OK)
            {
                if (this.lnV.ExisteVehiculo(numBastidor))
                {

                    Vehiculo vv = null;
                    VehiculoSegundaMano vs = null;
                    FVehiculo fv = new FVehiculo("Búsqueda de vehículo");
                    if (lnV.ExisteVehiculo(numBastidor))
                    {
                        vv = lnV.BuscarVehiculo(numBastidor);
                        fv.setNBastidor(numBastidor, false);
                        fv.setMarca(vv.Marca, false);
                        fv.setModelo(vv.Modelo, false);
                        fv.setPotencia(vv.Potencia, false);
                        fv.setPrecio(vv.Precio, false);

                        if (lnV.ExisteVehiculoSegundaMano(numBastidor))
                        {
                            vs = lnV.BuscarVehiculoSegundaMano(numBastidor);
                            fv.setMatricula(vs.Matricula, false);
                            fv.setFMatricula(vs.FechaMatriculacion, false);
                            RadioButton s = fv.getSegMano();
                            s.Checked = true;
                        }
                    }
                    fv.bloqueoPanel(false);
                    fv.visibleBotonCancelar(false);

                    fv.ShowDialog();

                }
                else
                {
                    DialogResult dr = MessageBox.Show("¿Quieres introducir otro?", "No existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        i.Dispose();
                        this.TSMIBajaV_Click(sender, e);
                    }
                }
                i.Dispose();
            }
        }

        private void TSMIRecorridoUnoAUnoV_Click(object sender, EventArgs e)
        {
            List<Vehiculo> lv = this.lnV.BuscarTodosVehiculos();
            FRecorridoV fv = new FRecorridoV(lv);
            fv.ShowDialog();
        }

        private void TSMIListadoV_Click(object sender, EventArgs e)
        {
            List<Vehiculo> lv = this.lnV.BuscarTodosVehiculos();
            FListadoV listv = new FListadoV(lv);
            listv.ShowDialog();
        }
    }
}
