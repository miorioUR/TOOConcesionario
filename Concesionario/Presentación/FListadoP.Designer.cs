
namespace Presentación
{
    partial class FListadoP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGPListado = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGPListado)).BeginInit();
            this.SuspendLayout();
            // 
            // dGPListado
            // 
            this.dGPListado.AllowUserToDeleteRows = false;
            this.dGPListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGPListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cEmpleado,
            this.cCliente,
            this.cImporte});
            this.dGPListado.Location = new System.Drawing.Point(12, 12);
            this.dGPListado.Name = "dGPListado";
            this.dGPListado.ReadOnly = true;
            this.dGPListado.Size = new System.Drawing.Size(547, 346);
            this.dGPListado.TabIndex = 1;
            // 
            // cID
            // 
            this.cID.HeaderText = "ID Presupuesto";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            // 
            // cEmpleado
            // 
            this.cEmpleado.HeaderText = "Empleado";
            this.cEmpleado.Name = "cEmpleado";
            this.cEmpleado.ReadOnly = true;
            // 
            // cCliente
            // 
            this.cCliente.HeaderText = "DNI Cliente";
            this.cCliente.Name = "cCliente";
            this.cCliente.ReadOnly = true;
            // 
            // cImporte
            // 
            this.cImporte.HeaderText = "Importe";
            this.cImporte.Name = "cImporte";
            this.cImporte.ReadOnly = true;
            // 
            // FListadoP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 376);
            this.Controls.Add(this.dGPListado);
            this.Name = "FListadoP";
            this.Text = "FListadoP";
            ((System.ComponentModel.ISupportInitialize)(this.dGPListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGPListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cImporte;
    }
}