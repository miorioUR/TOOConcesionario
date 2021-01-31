
namespace Presentación
{
    partial class FListadoC
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
            this.btDNI = new System.Windows.Forms.Button();
            this.btNombre = new System.Windows.Forms.Button();
            this.btImporte = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.ListBox();
            this.lbDNI = new System.Windows.Forms.ListBox();
            this.lbImporte = new System.Windows.Forms.ListBox();
            this.btCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDNI
            // 
            this.btDNI.Location = new System.Drawing.Point(35, 58);
            this.btDNI.Name = "btDNI";
            this.btDNI.Size = new System.Drawing.Size(75, 23);
            this.btDNI.TabIndex = 0;
            this.btDNI.Text = "DNI";
            this.btDNI.UseVisualStyleBackColor = true;
            this.btDNI.Click += new System.EventHandler(this.btDNI_Click);
            // 
            // btNombre
            // 
            this.btNombre.Location = new System.Drawing.Point(142, 58);
            this.btNombre.Name = "btNombre";
            this.btNombre.Size = new System.Drawing.Size(75, 23);
            this.btNombre.TabIndex = 1;
            this.btNombre.Text = "Nombre";
            this.btNombre.UseVisualStyleBackColor = true;
            this.btNombre.Click += new System.EventHandler(this.btNombre_Click);
            // 
            // btImporte
            // 
            this.btImporte.Location = new System.Drawing.Point(256, 58);
            this.btImporte.Name = "btImporte";
            this.btImporte.Size = new System.Drawing.Size(75, 23);
            this.btImporte.TabIndex = 2;
            this.btImporte.Text = "Importe";
            this.btImporte.UseVisualStyleBackColor = true;
            this.btImporte.Click += new System.EventHandler(this.btImporte_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.FormattingEnabled = true;
            this.lbNombre.Location = new System.Drawing.Point(142, 97);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(75, 160);
            this.lbNombre.TabIndex = 3;
            // 
            // lbDNI
            // 
            this.lbDNI.FormattingEnabled = true;
            this.lbDNI.Location = new System.Drawing.Point(35, 97);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(75, 160);
            this.lbDNI.TabIndex = 4;
            // 
            // lbImporte
            // 
            this.lbImporte.FormattingEnabled = true;
            this.lbImporte.Location = new System.Drawing.Point(256, 97);
            this.lbImporte.Name = "lbImporte";
            this.lbImporte.Size = new System.Drawing.Size(75, 160);
            this.lbImporte.TabIndex = 5;
            // 
            // btCerrar
            // 
            this.btCerrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btCerrar.Location = new System.Drawing.Point(142, 313);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 6;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            // 
            // FListadoC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 375);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.lbImporte);
            this.Controls.Add(this.lbDNI);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btImporte);
            this.Controls.Add(this.btNombre);
            this.Controls.Add(this.btDNI);
            this.Name = "FListadoC";
            this.Text = "FListadoC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDNI;
        private System.Windows.Forms.Button btNombre;
        private System.Windows.Forms.Button btImporte;
        private System.Windows.Forms.ListBox lbNombre;
        private System.Windows.Forms.ListBox lbDNI;
        private System.Windows.Forms.ListBox lbImporte;
        private System.Windows.Forms.Button btCerrar;
    }
}