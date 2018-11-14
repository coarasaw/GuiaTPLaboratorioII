using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_11
{
    public class Validaciones
    {
        static public bool Validar(int valor, int min, int max)
        {
            bool verdadero = true;

            if (valor >= min && valor <= max)
            {
                return verdadero;
            }
            else
            {
                return verdadero = false;
            }

        }
    }
}
