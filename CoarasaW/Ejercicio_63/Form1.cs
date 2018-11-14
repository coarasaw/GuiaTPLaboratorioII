using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio_63
{
    public partial class Form1 : Form
    {
        Thread t;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void lblFechaHora_Click(object sender, EventArgs e)
        {
            
        }
        public void AsignarHora()
        {
            while(true)
            {
                Thread.Sleep(1000);
                if (this.lblFechaHora.InvokeRequired)
                {
                    this.lblFechaHora.BeginInvoke((MethodInvoker)delegate ()
                        {
                            lblFechaHora.Text = DateTime.Now.ToString("G");
                        }
                    );
                }
                else
                {
                    lblFechaHora.Text = DateTime.Now.ToString("G");
                }
            }    
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Creo el hilo
            t = new Thread(AsignarHora);
            // Inicio el Hilo
            t.Start();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t.IsAlive)
            {
                t.Abort();
            }
        }
    }
}
