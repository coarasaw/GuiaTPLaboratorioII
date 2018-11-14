using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Generar un sistema de atención al cliente mediante las clases Cliente, Negocio y PuestoAtencion
             *  Puesto Atención:
                a. numeroActual es estático y privado. Se inicializará en el constructor de clase con valor 0.
                b. El método Atender simulará un tiempo de atención a un cliente: recibirá un cliente, simulará
                un tiempo de atención mediante el método de clase Sleep de la clase Thread y retornará
                true para indicar el final de la atención.
                c. NumeroActual es una propiedad estática, encargada de incrementar en 1 al atributo
                numeroActual y luego retornarlo.
                Cliente:
                d. Dos clientes serán iguales si tienen el mismo número.
                Negocio:
                e. El constructor privado inicializará la colección y el puesto de atención como Caja1.
                f. El operador + será el único capaz de agregar un Cliente a la cola de atención. Sólo se
                agregará un Cliente si este ya no forma parte de la lista. Rehutilizar el == de Cliente.
                g. La propiedad Cliente retornará el próximo cliente en la cola de atención en el get. El set
                deberá controla que el Cliente no figure ya en la cola de atención, caso contrario lo
                agregará.
                h. El operador == retornará true si el cliente se encuentra en la colección.
                i. El operador ~(Negocio) : bool generará una atención del próximo cliente en la cola,
                utilizando la propiedad Cliente y el método Atender de PuestoAtencion. Retornará True si
                pudo realizar la operación completa.
                Generar los métodos en el Main para probar el código.
             */
            Console.Title = "Ejercicio_31";

            Cliente c1 = new Cliente(1, "Mariana");
            Cliente c2 = new Cliente(2, "Bety");

            PuestoAtencion p1 = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            PuestoAtencion p2 = new PuestoAtencion(PuestoAtencion.Puesto.Caja2);

            Negocio n1 = new Negocio("Pipo");

            if (n1 + c1)
                Console.WriteLine("Agrego un cliente");
            else
                Console.WriteLine("No Agrego cleinte");

            if (n1 + c2)
                Console.WriteLine("Agrego un cliente");
            else
                Console.WriteLine("No Agrego cleinte");

            Console.WriteLine(n1.Mostrar());
            Console.ReadKey();
        }
    }
}
