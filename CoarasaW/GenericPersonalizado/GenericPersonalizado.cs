using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPersonalizado
{
    public class ListaElementos<T>
    {
        private List<T> elementos;

        public ListaElementos()
        {
            elementos = new List<T>();
        }
        public void Agregar(T nuevoElemento)
        {
            elementos.Add(nuevoElemento);
        }
        public void Eleminar(T eleminarElemnto)
        {
            elementos.Remove(eleminarElemnto);
        }
        public void Listar()
        {
            foreach (var item in elementos)
            {
                Console.WriteLine("Elemnto es {0} ", item);
            }
        }

    }
}
