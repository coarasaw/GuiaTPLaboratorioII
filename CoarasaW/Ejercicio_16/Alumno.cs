using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_16
{
    public class Alumno
    {
        static int contador;
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public int legajo;
        public string nombre;
        public string apellido;


        static Alumno()
        {
            contador = 1;
        }
        public Alumno()
        {
            _notaFinal = 0;
        }
        public Alumno(int legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public byte Nota1
        {
            get { return this._nota1; }
            set { this._nota1 = value; }
        }

        public byte Nota2
        {
            get { return this._nota2; }
            set { this._nota2 = value; }
        }

        public float NotaFinal
        {
            get { return this._notaFinal; }
            set { this._notaFinal = value; }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.Nota1 = notaUno;
            this.Nota2 = notaDos;
        }


        public void CalcularFinal()
        {
            Random calc = new Random(DateTime.Now.Millisecond);

            if (Nota1 >= 4 && Nota2 >= 4)
            {
                this._notaFinal = calc.Next(0, 10);
                Thread.Sleep(150);
            }
            else
            {
                this._notaFinal = -1;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Apellido:    " + this.apellido);
            sb.AppendLine("Nombre:      " + this.nombre);
            sb.AppendLine("Legajo:      " + this.legajo);
            if (this._notaFinal != -1)
                sb.AppendLine("El final es: " + this._notaFinal);
            else
                sb.AppendLine("Alumno desaprobado");
            return sb.ToString();
        }
    }
}
