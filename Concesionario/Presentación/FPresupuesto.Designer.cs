
namespace Presentación
{
    partial class FPresupuesto
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
            this.lbID = new System.Windows.Forms.Label();
            this.lbDNI = new System.Windows.Forms.Label();
            this.lbEmpleado = new System.Windows.Forms.Label();
            this.lbNumBastidor = new System.Windows.Forms.Label();
            this.tbIDPresupuesto = new System.Windows.Forms.TextBox();
            this.tbEmpleado = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbNumBastidor = new System.Windows.Forms.TextBox();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.btAñadirValoracion = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(78, 92);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(82, 13);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID presupuesto:";
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Location = new System.Drawing.Point(78, 136);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(29, 13);
            this.lbDNI.TabIndex = 1;
            this.lbDNI.Text = "DNI:";
            // 
            // lbEmpleado
            // 
            this.lbEmpleado.AutoSize = true;
            this.lbEmpleado.Location = new System.Drawing.Point(78, 51);
            this.lbEmpleado.Name = "lbEmpleado";
            this.lbEmpleado.Size = new System.Drawing.Size(57, 13);
            this.lbEmpleado.TabIndex = 2;
            this.lbEmpleado.Text = "Empleado:";
            // 
            // lbNumBastidor
            // 
            this.lbNumBastidor.AutoSize = true;
            this.lbNumBastidor.Location = new System.Drawing.Point(96, 241);
            this.lbNumBastidor.Name = "lbNumBastidor";
            this.lbNumBastidor.Size = new System.Drawing.Size(63, 13);
            this.lbNumBastidor.TabIndex = 3;
            this.lbNumBastidor.Text = "Nº Bastidor:";
            // 
            // tbIDPresupuesto
            // 
            this.tbIDPresupuesto.Location = new System.Drawing.Point(181, 89);
            this.tbIDPresupuesto.Name = "tbIDPresupuesto";
            this.tbIDPresupuesto.Size = new System.Drawing.Size(100, 20);
            this.tbIDPresupuesto.TabIndex = 4;
            // 
            // tbEmpleado
            // 
            this.tbEmpleado.Location = new System.Drawing.Point(181, 48);
            this.tbEmpleado.Name = "tbEmpleado";
            this.tbEmpleado.Size = new System.Drawing.Size(100, 20);
            this.tbEmpleado.TabIndex = 5;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(181, 129);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(100, 20);
            this.tbDNI.TabIndex = 6;
            // 
            // tbNumBastidor
            // 
            this.tbNumBastidor.Location = new System.Drawing.Point(168, 234);
            this.tbNumBastidor.Name = "tbNumBastidor";
            this.tbNumBastidor.Size = new System.Drawing.Size(100, 20);
            this.tbNumBastidor.TabIndex = 7;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(96, 273);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(40, 13);
            this.lbPrecio.TabIndex = 8;
            this.lbPrecio.Text = "Precio:";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(168, 266);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 9;
            // 
            // btAñadirValoracion
            // 
            this.btAñadirValoracion.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAñadirValoracion.Location = new System.Drawing.Point(129, 306);
            this.btAñadirValoracion.Name = "btAñadirValoracion";
            this.btAñadirValoracion.Size = new System.Drawing.Size(110, 23);
            this.btAñadirValoracion.TabIndex = 10;
            this.btAñadirValoracion.Text = "Añadir Valoración";
            this.btAñadirValoracion.UseVisualStyleBackColor = true;
            // 
            // btCerrar
            // 
            this.btCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCerrar.Location = new System.Drawing.Point(143, 358);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 11;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            // 
            // FPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btAñadirValoracion);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.tbNumBastidor);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.tbEmpleado);
            this.Controls.Add(this.tbIDPresupuesto);
            this.Controls.Add(this.lbNumBastidor);
            this.Controls.Add(this.lbEmpleado);
            this.Controls.Add(this.lbDNI);
            this.Controls.Add(this.lbID);
            this.Name = "FPresupuesto";
            this.Text = "FPresupuesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.Label lbEmpleado;
        private System.Windows.Forms.Label lbNumBastidor;
        private System.Windows.Forms.TextBox tbIDPresupuesto;
        private System.Windows.Forms.TextBox tbEmpleado;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbNumBastidor;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Button btAñadirValoracion;
        private System.Windows.Forms.Button btCerrar;
    }
}