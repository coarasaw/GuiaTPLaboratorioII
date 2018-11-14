using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                // if(this != value) SI NO esta la sobre carga +
                //    this.clientes.Enqueue(value)
                bool Esta_si_no = this + value;
            }
        }

        public static bool operator ~(Negocio n)//Alt + 126
        {
            Cliente cli = n.Cliente;

            return n.caja.Atender(cli); 
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if (n!=c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }

        public static bool operator ==(Negocio n,Cliente c)
        {
            bool estaCliente = false;

            foreach (Cliente item in n.clientes)
            {
                if (item == c)
                {
                    estaCliente = true;
                    break;
                }
            }

            return estaCliente;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre Negocio " + this.nombre);
            sb.AppendLine("Caja           " + this.caja.ToString());
            foreach (Cliente item in clientes)
            {
                sb.AppendLine("Nombre Cliente " +item.Nombre);
                sb.AppendLine("Nro Cliente    " + item.Numero.ToString());
            }
            sb.AppendLine("---");
            return sb.ToString();
        }
    }
}
