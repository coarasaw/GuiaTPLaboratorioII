using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
    public partial class Ejercicio28 : Form
    {
        public Ejercicio28()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {   
            string words = richTextBox1.Text;
            int contador = 0;
            string[] split = words.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            Dictionary<string, int> Palabras = new Dictionary<string, int>();
            foreach (string s in split)
            {
                if (s.Trim() != "")
                {
                    contador++;
                    Palabras.Add(s, contador);
                }   
            }
            MessageBox.Show(contador.ToString());
            foreach (var item in Palabras)
            {
                MessageBox.Show(item.ToString());
            }

            //Para saber si esta la llave en el diccionario
            /*
             if (Palabras.ContainsKey("hola"))
             {}
             Remover sacar
             Palabra.Remove("hola");

            Iterar con la llave
            foreach (var keys in Palabara.Keys)
            {
              Console.WriteLine(Keys);
            }
             */
        }
    }
}