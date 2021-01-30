namespace Presentación
{
    partial class FVehiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNBastidor = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbPotencia = new System.Windows.Forms.TextBox();
            this.tbPrecioRecomendado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSMano = new System.Windows.Forms.RadioButton();
            this.rbNuevo = new System.Windows.Forms.RadioButton();
            this.lMatricula = new System.Windows.Forms.Label();
            this.lFMatricula = new System.Windows.Forms.Label();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.tbFMatricula = new System.Windows.Forms.TextBox();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de bastidor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Potencia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio recomendado:";
            // 
            // tbNBastidor
            // 
            this.tbNBastidor.Location = new System.Drawing.Point(188, 50);
            this.tbNBastidor.Name = "tbNBastidor";
            this.tbNBastidor.Size = new System.Drawing.Size(100, 20);
            this.tbNBastidor.TabIndex = 5;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(188, 110);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 6;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(188, 160);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(100, 20);
            this.tbModelo.TabIndex = 7;
            // 
            // tbPotencia
            // 
            this.tbPotencia.Location = new System.Drawing.Point(188, 217);
            this.tbPotencia.Name = "tbPotencia";
            this.tbPotencia.Size = new System.Drawing.Size(100, 20);
            this.tbPotencia.TabIndex = 8;
            // 
            // tbPrecioRecomendado
            // 
            this.tbPrecioRecomendado.Location = new System.Drawing.Point(188, 270);
            this.tbPrecioRecomendado.Name = "tbPrecioRecomendado";
            this.tbPrecioRecomendado.Size = new System.Drawing.Size(100, 20);
            this.tbPrecioRecomendado.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSMano);
            this.groupBox1.Controls.Add(this.rbNuevo);
            this.groupBox1.Location = new System.Drawing.Point(347, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 108);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehículo";
            // 
            // rbSMano
            // 
            this.rbSMano.AutoSize = true;
            this.rbSMano.Location = new System.Drawing.Point(147, 41);
            this.rbSMano.Name = "rbSMano";
            this.rbSMano.Size = new System.Drawing.Size(97, 17);
            this.rbSMano.TabIndex = 1;
            this.rbSMano.Text = "Segunda mano";
            this.rbSMano.UseVisualStyleBackColor = true;
            this.rbSMano.CheckedChanged += new System.EventHandler(this.rbSMano_CheckedChanged);
            // 
            // rbNuevo
            // 
            this.rbNuevo.AutoSize = true;
            this.rbNuevo.Checked = true;
            this.rbNuevo.Location = new System.Drawing.Point(21, 41);
            this.rbNuevo.Name = "rbNuevo";
            this.rbNuevo.Size = new System.Drawing.Size(55, 17);
            this.rbNuevo.TabIndex = 0;
            this.rbNuevo.TabStop = true;
            this.rbNuevo.Text = "nuevo";
            this.rbNuevo.UseVisualStyleBackColor = true;
            // 
            // lMatricula
            // 
            this.lMatricula.AutoSize = true;
            this.lMatricula.Location = new System.Drawing.Point(344, 194);
            this.lMatricula.Name = "lMatricula";
            this.lMatricula.Size = new System.Drawing.Size(55, 13);
            this.lMatricula.TabIndex = 11;
            this.lMatricula.Text = "Matrícula:";
            this.lMatricula.Visible = false;
            // 
            // lFMatricula
            // 
            this.lFMatricula.AutoSize = true;
            this.lFMatricula.Location = new System.Drawing.Point(344, 251);
            this.lFMatricula.Name = "lFMatricula";
            this.lFMatricula.Size = new System.Drawing.Size(105, 13);
            this.lFMatricula.TabIndex = 12;
            this.lFMatricula.Text = "Fecha matriculación:";
            this.lFMatricula.Visible = false;
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(465, 187);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(100, 20);
            this.tbMatricula.TabIndex = 13;
            this.tbMatricula.Visible = false;
            // 
            // tbFMatricula
            // 
            this.tbFMatricula.Location = new System.Drawing.Point(465, 244);
            this.tbFMatricula.Name = "tbFMatricula";
            this.tbFMatricula.Size = new System.Drawing.Size(100, 20);
            this.tbFMatricula.TabIndex = 14;
            this.tbFMatricula.Visible = false;
            // 
            // bAceptar
            // 
            this.bAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAceptar.Location = new System.Drawing.Point(188, 336);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 15;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancelar.Location = new System.Drawing.Point(347, 336);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 16;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // FVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 385);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tbFMatricula);
            this.Controls.Add(this.tbMatricula);
            this.Controls.Add(this.lFMatricula);
            this.Controls.Add(this.lMatricula);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbPrecioRecomendado);
            this.Controls.Add(this.tbPotencia);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.tbNBastidor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FVehiculo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNBastidor;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbPotencia;
        private System.Windows.Forms.TextBox tbPrecioRecomendado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSMano;
        private System.Windows.Forms.RadioButton rbNuevo;
        private System.Windows.Forms.Label lMatricula;
        private System.Windows.Forms.Label lFMatricula;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.TextBox tbFMatricula;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
    }
}