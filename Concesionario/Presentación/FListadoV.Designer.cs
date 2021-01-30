namespace Presentación
{
    partial class FListadoV
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
            this.dGVListado = new System.Windows.Forms.DataGridView();
            this.NumeroBastidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Potencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListado)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVListado
            // 
            this.dGVListado.AllowUserToDeleteRows = false;
            this.dGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroBastidor,
            this.Marca,
            this.Modelo,
            this.Potencia,
            this.Precio});
            this.dGVListado.Location = new System.Drawing.Point(1, 1);
            this.dGVListado.Name = "dGVListado";
            this.dGVListado.ReadOnly = true;
            this.dGVListado.Size = new System.Drawing.Size(892, 346);
            this.dGVListado.TabIndex = 0;
            // 
            // NumeroBastidor
            // 
            this.NumeroBastidor.HeaderText = "Número de bastidor";
            this.NumeroBastidor.Name = "NumeroBastidor";
            this.NumeroBastidor.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Potencia
            // 
            this.Potencia.HeaderText = "Potencia";
            this.Potencia.Name = "Potencia";
            this.Potencia.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio recomendado";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // FListadoV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 372);
            this.Controls.Add(this.dGVListado);
            this.Name = "FListadoV";
            this.Text = "Listado de vehículos";
            ((System.ComponentModel.ISupportInitialize)(this.dGVListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroBastidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Potencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}