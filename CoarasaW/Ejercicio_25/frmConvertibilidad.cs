using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conversion;

namespace Ejercicio_25
{
    public partial class frmConvertibilidad : Form
    {
        public frmConvertibilidad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDecBin_Click(object sender, EventArgs e)
        {
            double AsignarNum2;
            if (!Double.TryParse(txtDecimal.Text, out AsignarNum2))
            {
                errorProvider2.SetError(txtDecimal, "Debe ingresar un número");
                MessageBox.Show("Debe ingresar un número");
                txtDecimal.Focus();
                return;
            }
            else
            {
                errorProvider2.SetError(txtDecimal, "");
                String varDecBin = Conversor.DecimalBinario(AsignarNum2);
                txtResultadoBin.Text = varDecBin;
            }
         }

        private void btnBinDec_Click(object sender, EventArgs e)
        {
            double AsignarNum1;
            if (!Double.TryParse(txtBinario.Text, out AsignarNum1))
            {
                errorProvider1.SetError(txtBinario, "Debe ingresar un número");
                MessageBox.Show("Debe ingresar un número");
                txtBinario.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtBinario, "");
                Double varBinDec = Conversor.BinarioDecimal(AsignarNum1.ToString());
                txtResultadoDec.Text = varBinDec.ToString(); 
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBinario.Text = "";
            txtDecimal.Text = "";
            txtResultadoBin.Text = "";
            txtResultadoDec.Text = "";
        }
    }
}
