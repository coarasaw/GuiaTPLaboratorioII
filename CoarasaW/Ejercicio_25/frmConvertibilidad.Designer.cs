namespace Ejercicio_25
{
    partial class frmConvertibilidad
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
            this.components = new System.ComponentModel.Container();
            this.lblTituloBinaioDecimal = new System.Windows.Forms.Label();
            this.lblTituloDecimalBinario = new System.Windows.Forms.Label();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.txtResultadoBin = new System.Windows.Forms.TextBox();
            this.txtResultadoDec = new System.Windows.Forms.TextBox();
            this.btnDecBin = new System.Windows.Forms.Button();
            this.btnBinDec = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloBinaioDecimal
            // 
            this.lblTituloBinaioDecimal.AutoSize = true;
            this.lblTituloBinaioDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloBinaioDecimal.Location = new System.Drawing.Point(13, 33);
            this.lblTituloBinaioDecimal.Name = "lblTituloBinaioDecimal";
            this.lblTituloBinaioDecimal.Size = new System.Drawing.Size(149, 20);
            this.lblTituloBinaioDecimal.TabIndex = 0;
            this.lblTituloBinaioDecimal.Text = "Binario a Decimal";
            // 
            // lblTituloDecimalBinario
            // 
            this.lblTituloDecimalBinario.AutoSize = true;
            this.lblTituloDecimalBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDecimalBinario.Location = new System.Drawing.Point(13, 104);
            this.lblTituloDecimalBinario.Name = "lblTituloDecimalBinario";
            this.lblTituloDecimalBinario.Size = new System.Drawing.Size(149, 20);
            this.lblTituloDecimalBinario.TabIndex = 1;
            this.lblTituloDecimalBinario.Text = "Decimal a Binario";
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(185, 33);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(125, 20);
            this.txtBinario.TabIndex = 2;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(185, 106);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(125, 20);
            this.txtDecimal.TabIndex = 3;
            // 
            // txtResultadoBin
            // 
            this.txtResultadoBin.Enabled = false;
            this.txtResultadoBin.Location = new System.Drawing.Point(519, 108);
            this.txtResultadoBin.Name = "txtResultadoBin";
            this.txtResultadoBin.Size = new System.Drawing.Size(125, 20);
            this.txtResultadoBin.TabIndex = 5;
            this.txtResultadoBin.TabStop = false;
            // 
            // txtResultadoDec
            // 
            this.txtResultadoDec.Enabled = false;
            this.txtResultadoDec.Location = new System.Drawing.Point(519, 35);
            this.txtResultadoDec.Name = "txtResultadoDec";
            this.txtResultadoDec.Size = new System.Drawing.Size(125, 20);
            this.txtResultadoDec.TabIndex = 4;
            // 
            // btnDecBin
            // 
            this.btnDecBin.Location = new System.Drawing.Point(357, 108);
            this.btnDecBin.Name = "btnDecBin";
            this.btnDecBin.Size = new System.Drawing.Size(130, 21);
            this.btnDecBin.TabIndex = 7;
            this.btnDecBin.Text = "->";
            this.btnDecBin.UseVisualStyleBackColor = true;
            this.btnDecBin.Click += new System.EventHandler(this.btnDecBin_Click);
            // 
            // btnBinDec
            // 
            this.btnBinDec.Location = new System.Drawing.Point(357, 29);
            this.btnBinDec.Name = "btnBinDec";
            this.btnBinDec.Size = new System.Drawing.Size(130, 23);
            this.btnBinDec.TabIndex = 8;
            this.btnBinDec.Text = "->";
            this.btnBinDec.UseVisualStyleBackColor = true;
            this.btnBinDec.Click += new System.EventHandler(this.btnBinDec_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(357, 150);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 21);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmConvertibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 183);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBinDec);
            this.Controls.Add(this.btnDecBin);
            this.Controls.Add(this.txtResultadoBin);
            this.Controls.Add(this.txtResultadoDec);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.lblTituloDecimalBinario);
            this.Controls.Add(this.lblTituloBinaioDecimal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConvertibilidad";
            this.Text = "Convertibilidad";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloBinaioDecimal;
        private System.Windows.Forms.Label lblTituloDecimalBinario;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtResultadoBin;
        private System.Windows.Forms.TextBox txtResultadoDec;
        private System.Windows.Forms.Button btnDecBin;
        private System.Windows.Forms.Button btnBinDec;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

