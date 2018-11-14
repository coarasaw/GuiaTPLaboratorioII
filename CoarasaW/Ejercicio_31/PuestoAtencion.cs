using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*
 * Puesto Atención:
                a. numeroActual es estático y privado. Se inicializará en el constructor de clase con valor 0.
                b. El método Atender simulará un tiempo de atención a un cliente: recibirá un cliente, simulará
                un tiempo de atención mediante el método de clase Sleep de la clase Thread y retornará
                true para indicar el final de la atención.
                c. NumeroActual es una propiedad estática, encargada de incrementar en 1 al atributo
                numeroActual y luego retornarlo.
                
 */
namespace Ejercicio_31
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public int NumeroActual
        {
            get { return numeroActual++ ; }        
        }

        static PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public bool Atender(Cliente cli)
        {
            Thread.Sleep(2000);
            return true; 
        }
        public override string ToString()
        {
            return Puesto.Caja1.ToString();
        }
        public enum Puesto
        {
            Caja1,
            Caja2
        }
    }
}
