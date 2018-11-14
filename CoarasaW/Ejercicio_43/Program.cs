using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_43";

            AutoF1 a1 = new AutoF1(3, "Honda");
            AutoF1 a2 = new AutoF1(4, "Susuki", 5);
            //AutoF1 a3 = new AutoF1(2, "Lotus");

            MotoCross m1 = new MotoCross(1, "Honda");
            //MotoCross m2 = new MotoCross(2, "Susuki");
            //MotoCross m3 = new MotoCross(2, "Zanella");

            Competencia c1 = new Competencia(3, 10, TipoCompetencia.F1);
            //Competencia c2 = new Competencia(3, 3, TipoCompetencia.MotoCross);

            //if (a1 == a2)
            //{
            //    Console.WriteLine("Autos Iguales");
            //}
            //else
            //{
            //    Console.WriteLine("Autos no iguales");
            //}

            try
            {
                
                //bool ok = (c1 + a2);
                bool ok2 = (c1 + m1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                //Console.WriteLine(e.Message);
                //Console.WriteLine(e.InnerException.Message);
                //throw new CompetenciaNoDisponibleException(e.Message, "Competencia", "Operator +");
               
            }
            Console.ReadKey();
        }
    }
}
