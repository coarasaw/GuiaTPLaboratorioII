namespace Ejercicio_23
{
    partial class ConversorDinero
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
            this.components = new System.ComponentModel.Container();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPesos = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.txtPesosAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtPesosADolar = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtPesosAPesos = new System.Windows.Forms.TextBox();
            this.txtDolarAPesos = new System.Windows.Forms.TextBox();
            this.txtEuroAPesos = new System.Windows.Forms.TextBox();
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertPesos = new System.Windows.Forms.Button();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtDolarEuro = new System.Windows.Forms.TextBox();
            this.txtDolarDolar = new System.Windows.Forms.TextBox();
            this.txtDolarPesos = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTituloEuros = new System.Windows.Forms.Label();
            this.lblTituloDolar = new System.Windows.Forms.Label();
            this.lblTituloPesos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(18, 66);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(29, 13);
            this.lblEuro.TabIndex = 0;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(18, 156);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(32, 13);
            this.lblDolar.TabIndex = 1;
            this.lblDolar.Text = "Dolar";
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Location = new System.Drawing.Point(18, 255);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(36, 13);
            this.lblPesos.TabIndex = 2;
            this.lblPesos.Text = "Pesos";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(83, 59);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(120, 20);
            this.txtEuro.TabIndex = 3;
            this.txtEuro.TextChanged += new System.EventHandler(this.txtEuro_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 4;
            // 
            // txtPesos
            // 
            this.txtPesos.Location = new System.Drawing.Point(83, 255);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(120, 20);
            this.txtPesos.TabIndex = 5;
            // 
            // txtPesosAEuro
            // 
            this.txtPesosAEuro.Enabled = false;
            this.txtPesosAEuro.Location = new System.Drawing.Point(362, 255);
            this.txtPesosAEuro.Name = "txtPesosAEuro";
            this.txtPesosAEuro.Size = new System.Drawing.Size(120, 20);
            this.txtPesosAEuro.TabIndex = 8;
            this.txtPesosAEuro.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Location = new System.Drawing.Point(362, 160);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(120, 20);
            this.txtDolarAEuro.TabIndex = 7;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Enabled = false;
            this.txtEuroAEuro.Location = new System.Drawing.Point(362, 63);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(120, 20);
            this.txtEuroAEuro.TabIndex = 6;
            // 
            // txtPesosADolar
            // 
            this.txtPesosADolar.Enabled = false;
            this.txtPesosADolar.Location = new System.Drawing.Point(517, 255);
            this.txtPesosADolar.Name = "txtPesosADolar";
            this.txtPesosADolar.Size = new System.Drawing.Size(120, 20);
            this.txtPesosADolar.TabIndex = 11;
            this.txtPesosADolar.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Location = new System.Drawing.Point(517, 160);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(120, 20);
            this.txtDolarADolar.TabIndex = 10;
            this.txtDolarADolar.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Enabled = false;
            this.txtEuroADolar.Location = new System.Drawing.Point(517, 63);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(120, 20);
            this.txtEuroADolar.TabIndex = 9;
            // 
            // txtPesosAPesos
            // 
            this.txtPesosAPesos.Enabled = false;
            this.txtPesosAPesos.Location = new System.Drawing.Point(668, 255);
            this.txtPesosAPesos.Name = "txtPesosAPesos";
            this.txtPesosAPesos.Size = new System.Drawing.Size(120, 20);
            this.txtPesosAPesos.TabIndex = 14;
            this.txtPesosAPesos.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // txtDolarAPesos
            // 
            this.txtDolarAPesos.Location = new System.Drawing.Point(668, 160);
            this.txtDolarAPesos.Name = "txtDolarAPesos";
            this.txtDolarAPesos.Size = new System.Drawing.Size(120, 20);
            this.txtDolarAPesos.TabIndex = 13;
            // 
            // txtEuroAPesos
            // 
            this.txtEuroAPesos.Enabled = false;
            this.txtEuroAPesos.Location = new System.Drawing.Point(668, 61);
            this.txtEuroAPesos.Name = "txtEuroAPesos";
            this.txtEuroAPesos.Size = new System.Drawing.Size(120, 20);
            this.txtEuroAPesos.TabIndex = 12;
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.Location = new System.Drawing.Point(218, 59);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(113, 22);
            this.btnConvertEuro.TabIndex = 15;
            this.btnConvertEuro.Text = "=>";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(218, 154);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(113, 22);
            this.btnConvertDolar.TabIndex = 16;
            this.btnConvertDolar.Text = "=>";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // btnConvertPesos
            // 
            this.btnConvertPesos.Location = new System.Drawing.Point(218, 250);
            this.btnConvertPesos.Name = "btnConvertPesos";
            this.btnConvertPesos.Size = new System.Drawing.Size(113, 22);
            this.btnConvertPesos.TabIndex = 17;
            this.btnConvertPesos.Text = "=>";
            this.btnConvertPesos.UseVisualStyleBackColor = true;
            this.btnConvertPesos.Click += new System.EventHandler(this.btnConvertPesos_Click);
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(83, 156);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(120, 20);
            this.txtDolar.TabIndex = 4;
            // 
            // txtDolarEuro
            // 
            this.txtDolarEuro.Enabled = false;
            this.txtDolarEuro.Location = new System.Drawing.Point(362, 160);
            this.txtDolarEuro.Name = "txtDolarEuro";
            this.txtDolarEuro.Size = new System.Drawing.Size(120, 20);
            this.txtDolarEuro.TabIndex = 7;
            // 
            // txtDolarDolar
            // 
            this.txtDolarDolar.Enabled = false;
            this.txtDolarDolar.Location = new System.Drawing.Point(517, 160);
            this.txtDolarDolar.Name = "txtDolarDolar";
            this.txtDolarDolar.Size = new System.Drawing.Size(120, 20);
            this.txtDolarDolar.TabIndex = 10;
            this.txtDolarDolar.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtDolarPesos
            // 
            this.txtDolarPesos.Enabled = false;
            this.txtDolarPesos.Location = new System.Drawing.Point(668, 160);
            this.txtDolarPesos.Name = "txtDolarPesos";
            this.txtDolarPesos.Size = new System.Drawing.Size(120, 20);
            this.txtDolarPesos.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // lblTituloEuros
            // 
            this.lblTituloEuros.AutoSize = true;
            this.lblTituloEuros.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTituloEuros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTituloEuros.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTituloEuros.Location = new System.Drawing.Point(403, 19);
            this.lblTituloEuros.Name = "lblTituloEuros";
            this.lblTituloEuros.Size = new System.Drawing.Size(47, 15);
            this.lblTituloEuros.TabIndex = 18;
            this.lblTituloEuros.Text = "EUROS";
            // 
            // lblTituloDolar
            // 
            this.lblTituloDolar.AutoSize = true;
            this.lblTituloDolar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTituloDolar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTituloDolar.Location = new System.Drawing.Point(552, 19);
            this.lblTituloDolar.Name = "lblTituloDolar";
            this.lblTituloDolar.Size = new System.Drawing.Size(44, 13);
            this.lblTituloDolar.TabIndex = 19;
            this.lblTituloDolar.Text = "DOLAR";
            // 
            // lblTituloPesos
            // 
            this.lblTituloPesos.AutoSize = true;
            this.lblTituloPesos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTituloPesos.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTituloPesos.Location = new System.Drawing.Point(706, 19);
            this.lblTituloPesos.Name = "lblTituloPesos";
            this.lblTituloPesos.Size = new System.Drawing.Size(43, 13);
            this.lblTituloPesos.TabIndex = 20;
            this.lblTituloPesos.Text = "PESOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(555, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "DOLAR";
            // 
            // ConversorDinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 336);
            this.Controls.Add(this.lblTituloPesos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloDolar);
            this.Controls.Add(this.lblTituloEuros);
            this.Controls.Add(this.btnConvertPesos);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.txtPesosAPesos);
            this.Controls.Add(this.txtDolarPesos);
            this.Controls.Add(this.txtDolarAPesos);
            this.Controls.Add(this.txtEuroAPesos);
            this.Controls.Add(this.txtPesosADolar);
            this.Controls.Add(this.txtDolarDolar);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtPesosAEuro);
            this.Controls.Add(this.txtDolarEuro);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtPesos);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.lblPesos);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.Name = "ConversorDinero";
            this.Text = "ConversorDinero";
            this.Load += new System.EventHandler(this.ConversorDinero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.TextBox txtPesosAEuro;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtPesosADolar;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtPesosAPesos;
        private System.Windows.Forms.TextBox txtDolarAPesos;
        private System.Windows.Forms.TextBox txtEuroAPesos;
        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvertPesos;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtDolarEuro;
        private System.Windows.Forms.TextBox txtDolarDolar;
        private System.Windows.Forms.TextBox txtDolarPesos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Label lblTituloPesos;
        private System.Windows.Forms.Label lblTituloDolar;
        private System.Windows.Forms.Label lblTituloEuros;
        private System.Windows.Forms.Label label1;
    }
}