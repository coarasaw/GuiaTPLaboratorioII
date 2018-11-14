using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace SerializacionXML
{
    public class Persona
    {
        public string nombre;
        public int edad;
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.nombre = "Mariana";
            p.edad = 35;

            XmlSerializer xs = new XmlSerializer(typeof(Persona));
            using (Stream s = File.Create(@"c:persona.xml"))
            {
                xs.Serialize(s, p);
            }

            Persona p2 = new Persona();
            using (Stream s = File.OpenRead(@"c:persona.xml"))
            {
                p2 = (Persona)xs.Deserialize(s);
            }

            Console.WriteLine("El nombre es {0} y tiene {1}", p2.nombre, p2.edad);
            Console.ReadKey();
        }
    }
}
