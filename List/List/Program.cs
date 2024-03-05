using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> empleados = new List<string>();
            empleados.Add("Alex");
            empleados.Add("Johany");
            empleados.Add("Sebas");
            empleados.Add("Oscar");
            empleados.Add("Pacho");
            empleados.Add("Wiliam");
            //Console.WriteLine(empleados[3]);
            //empleados.Sort();
            //empleados.Insert(1, "Alisson");
            //empleados.Remove("Oscar");
            //empleados.RemoveAt(1);
            //for (int i = 0; i < empleados.Count; i++)
            //{

            //    Console.WriteLine(empleados[i]);

            //}

            foreach (var todos in empleados)
            {
                Console.WriteLine(todos);
                
            }

        }
    }
}
