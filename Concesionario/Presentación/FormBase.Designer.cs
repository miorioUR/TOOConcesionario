
namespace Presentación
{
    partial class FormBase
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMIClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIAltaC = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIBajaC = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIBusquedaC = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIAltaV = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIBajaV = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIBusquedaV = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIPresupuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIClientes,
            this.TSMIVehiculos,
            this.TSMIPresupuestos,
            this.TSMIConfiguracion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMIClientes
            // 
            this.TSMIClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIAltaC,
            this.TSMIBajaC,
            this.TSMIBusquedaC});
            this.TSMIClientes.Name = "TSMIClientes";
            this.TSMIClientes.Size = new System.Drawing.Size(61, 20);
            this.TSMIClientes.Text = "Clientes";
            // 
            // TSMIAltaC
            // 
            this.TSMIAltaC.Name = "TSMIAltaC";
            this.TSMIAltaC.Size = new System.Drawing.Size(180, 22);
            this.TSMIAltaC.Text = "Alta";
            this.TSMIAltaC.Click += new System.EventHandler(this.TSMIAltaC_Click);
            // 
            // TSMIBajaC
            // 
            this.TSMIBajaC.Name = "TSMIBajaC";
            this.TSMIBajaC.Size = new System.Drawing.Size(180, 22);
            this.TSMIBajaC.Text = "Baja";
            this.TSMIBajaC.Click += new System.EventHandler(this.TSMIBajaC_Click);
            // 
            // TSMIBusquedaC
            // 
            this.TSMIBusquedaC.Name = "TSMIBusquedaC";
            this.TSMIBusquedaC.Size = new System.Drawing.Size(180, 22);
            this.TSMIBusquedaC.Text = "Búsqueda";
            this.TSMIBusquedaC.Click += new System.EventHandler(this.TSMIBusquedaC_Click);
            // 
            // TSMIVehiculos
            // 
            this.TSMIVehiculos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIAltaV,
            this.TSMIBajaV,
            this.TSMIBusquedaV});
            this.TSMIVehiculos.Name = "TSMIVehiculos";
            this.TSMIVehiculos.Size = new System.Drawing.Size(69, 20);
            this.TSMIVehiculos.Text = "Vehículos";
            // 
            // TSMIAltaV
            // 
            this.TSMIAltaV.Name = "TSMIAltaV";
            this.TSMIAltaV.Size = new System.Drawing.Size(180, 22);
            this.TSMIAltaV.Text = "Alta";
            this.TSMIAltaV.Click += new System.EventHandler(this.TSMIAltaV_Click);
            // 
            // TSMIBajaV
            // 
            this.TSMIBajaV.Name = "TSMIBajaV";
            this.TSMIBajaV.Size = new System.Drawing.Size(180, 22);
            this.TSMIBajaV.Text = "Baja";
            this.TSMIBajaV.Click += new System.EventHandler(this.TSMIBajaV_Click);
            // 
            // TSMIBusquedaV
            // 
            this.TSMIBusquedaV.Name = "TSMIBusquedaV";
            this.TSMIBusquedaV.Size = new System.Drawing.Size(180, 22);
            this.TSMIBusquedaV.Text = "Búsqueda";
            this.TSMIBusquedaV.Click += new System.EventHandler(this.TSMIBusquedaV_Click);
            // 
            // TSMIPresupuestos
            // 
            this.TSMIPresupuestos.Name = "TSMIPresupuestos";
            this.TSMIPresupuestos.Size = new System.Drawing.Size(89, 20);
            this.TSMIPresupuestos.Text = "Presupuestos";
            // 
            // TSMIConfiguracion
            // 
            this.TSMIConfiguracion.Name = "TSMIConfiguracion";
            this.TSMIConfiguracion.Size = new System.Drawing.Size(95, 20);
            this.TSMIConfiguracion.Text = "Configuración";
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pepe ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMIClientes;
        private System.Windows.Forms.ToolStripMenuItem TSMIAltaC;
        private System.Windows.Forms.ToolStripMenuItem TSMIBajaC;
        private System.Windows.Forms.ToolStripMenuItem TSMIBusquedaC;
        private System.Windows.Forms.ToolStripMenuItem TSMIVehiculos;
        private System.Windows.Forms.ToolStripMenuItem TSMIAltaV;
        private System.Windows.Forms.ToolStripMenuItem TSMIBajaV;
        private System.Windows.Forms.ToolStripMenuItem TSMIBusquedaV;
        private System.Windows.Forms.ToolStripMenuItem TSMIPresupuestos;
        private System.Windows.Forms.ToolStripMenuItem TSMIConfiguracion;
    }
}

