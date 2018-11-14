using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericPersonalizado;

namespace GenericPersonalizadoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Eejmplo de Generic <T>";

            ListaElementos<int> listaEntera = new ListaElementos<int>();
            Console.WriteLine("Lista Entra");
            Console.WriteLine("-----------");
            listaEntera.Agregar(1);
            listaEntera.Agregar(2);
            listaEntera.Agregar(3);
            listaEntera.Listar();
            Console.WriteLine("Eliminar de la Lista 2");
            Console.WriteLine("-----------");
            listaEntera.Eleminar(2);
            Console.WriteLine("Lista Entra");
            Console.WriteLine("-----------");
            listaEntera.Listar();
            Console.WriteLine();
            Console.WriteLine("Lista Cadena");
            Console.WriteLine("------------");
            ListaElementos<string> listaCadena = new ListaElementos<string>();
            listaCadena.Agregar("Wally");
            listaCadena.Agregar("Tammy");
            listaCadena.Agregar("Mariana");
            listaCadena.Listar();
            Console.WriteLine("Eliminar de la Lista Tammy");
            Console.WriteLine("-----------");
            listaCadena.Eleminar("Tammy");
            Console.WriteLine("Lista Cadena");
            Console.WriteLine("------------");
            listaCadena.Listar();
            Console.ReadKey();
        }
    }
}
