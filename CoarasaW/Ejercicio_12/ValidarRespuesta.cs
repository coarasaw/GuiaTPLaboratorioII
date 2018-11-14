using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_12
{
    public static class ValidarRespuesta
    {
        static public bool Validar(string caracter)
        {
            bool verdadero = true;

            if (caracter == "S" || caracter == "s")
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
