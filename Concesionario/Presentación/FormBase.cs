using LogicaNegocio;
using MDPresupuesto;
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
    public partial class FormBase : Form
    {
        private Empleado e;
        private LNCliente lnC;
        private LNVehiculo lnV;
        private LNPresupuesto lnP;
        private LN ln;

        public FormBase()
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
            FBastidor i = new FBastidor();
            DialogResult r = i.ShowDialog();
            string numBastidor = i.getNumBastidor();

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
            FBastidor i = new FBastidor();
            DialogResult r = i.ShowDialog();
            string numBastidor = i.getNumBastidor();

            if (r == DialogResult.OK)
            {
                FVehiculo fv = null;
                
                if (numBastidor != "" || this.lnV.ExisteVehiculo(numBastidor))
                {
                    fv = new FVehiculo("Baja vehiculo");
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
                fv.Dispose();
                i.Dispose();
            }
        }

        private void TSMIBusquedaV_Click(object sender, EventArgs e)
        {
            FBastidor i = new FBastidor();
            DialogResult r = i.ShowDialog();
            string numBastidor = i.getNumBastidor();

            if (r == DialogResult.OK)
            {
                FVehiculo fv = null;
                if (this.lnV.ExisteVehiculo(numBastidor))
                {
                    Vehiculo vv = null;
                    VehiculoSegundaMano vs = null;
                    fv = new FVehiculo("Búsqueda de vehículo");
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
                fv.Dispose();
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
