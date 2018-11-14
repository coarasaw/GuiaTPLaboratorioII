using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace Ejercicio_23
{
    public partial class ConversorDinero : Form
    {
        public ConversorDinero()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEuro_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            //Validar que solo permita ingresar datos numéricos
            double AsignarNum1;
            if (!Double.TryParse(txtEuro.Text, out AsignarNum1))
            {
                errorProvider1.SetError(txtEuro, "Debe ingresar un número");
                MessageBox.Show("Debe ingresar un número Euro");
                txtEuro.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtEuro, "");
                Euro convEuroAEuro = new Euro(AsignarNum1);
                Pesos convEurosAPesos = (Pesos)convEuroAEuro;
                Dolar convEuroADolar = (Dolar)convEuroAEuro;

                txtEuroAEuro.Text = convEuroAEuro.GetCantidad().ToString("#,###0.####");
                txtEuroADolar.Text = convEuroADolar.GetCantidad().ToString("#,###0.####");
                txtEuroAPesos.Text = convEurosAPesos.GetCantidad().ToString("#,###0.####");
            }         
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            //Validar que solo permita ingresar datos numéricos
            double AsignarNum2;
            if (!Double.TryParse(txtDolar.Text, out AsignarNum2))
            {
                errorProvider2.SetError(txtDolar, "Debe ingresar un número");
                MessageBox.Show("Debe ingresar un número Dolar");
                txtEuro.Focus();
                return;
            }
            else
            {
                errorProvider2.SetError(txtDolar, "");
                Dolar convDolarDolar = new Dolar(AsignarNum2);
                Euro convDolarEuro = (Euro)convDolarDolar;
                Pesos convDolarPesos = (Pesos)convDolarDolar;
            
                txtDolarEuro.Text = convDolarEuro.GetCantidad().ToString("#,###0.####");
                txtDolarDolar.Text = convDolarDolar.GetCantidad().ToString("#,###0.####");
                txtDolarPesos.Text = convDolarPesos.GetCantidad().ToString("#,###0.####");
            }
        }

        private void ConversorDinero_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertPesos_Click(object sender, EventArgs e)
        {
            //Validar que solo permita ingresar datos numéricos
            double AsignarNum3;
            if (!Double.TryParse(txtPesos.Text, out AsignarNum3))
            {
                errorProvider3.SetError(txtDolar, "Debe ingresar un número");
                MessageBox.Show("Debe ingresar un número Pesos");
                txtEuro.Focus();
                return;
            }
            else
            {
                errorProvider3.SetError(txtPesos, "");
                Pesos convPesosPesos = new Pesos(AsignarNum3);
                Dolar convPesosDolar = (Dolar)convPesosPesos;
                Euro convPesosEuro = (Euro)convPesosPesos;
                
                txtPesosAEuro.Text = convPesosEuro.GetCantidad().ToString("#,###0.####");
                txtPesosADolar.Text = convPesosDolar.GetCantidad().ToString("#,###0.####");
                txtPesosAPesos.Text = convPesosPesos.GetCantidad().ToString("#,###0.####");
            }
        }
    }
}
