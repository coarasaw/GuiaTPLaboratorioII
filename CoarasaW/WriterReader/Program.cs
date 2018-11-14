using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WriterReader";
            string[] nombres = new string[] { "Anger Arias", "Mariana Gonzalez" };

            using (StreamWriter escribir = new StreamWriter(@"c:nombres.txt"))
            {
                foreach (string item in nombres)
                {
                    escribir.WriteLine(item);
                }
            }

            using (StreamReader leer = new StreamReader(@"c:nombres.txt"))
            {
                string linea;
                while ((linea = leer.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }

            Console.ReadKey();

            //try
            //{
            //    string[] dirs = Directory.GetDirectories(@"c:\", "p*", SearchOption.TopDirectoryOnly);
            //    Console.WriteLine("The number of directories starting with p is {0}.", dirs.Length);
            //    foreach (string dir in dirs)
            //    {
            //        Console.WriteLine(dir);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("The process failed: {0}", e.ToString());
            //}


            //// Get the directories currently on the C drive.
            //DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();

            //// Write each directory name to a file.
            //using (StreamWriter sw = new StreamWriter("CDriveDirs.txt"))
            //{
            //    foreach (DirectoryInfo dir in cDirs)
            //    {
            //        sw.WriteLine(dir.Name);

            //    }
            //}

            //// Read and show each line from the file.
            //string line = "";
            //using (StreamReader sr = new StreamReader("CDriveDirs.txt"))
            //{
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            //Console.ReadKey();
        }
    }
}
