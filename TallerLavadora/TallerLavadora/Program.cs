using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerLavadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreCliente;
            Lavadora lavadora = new Lavadora(0, new List<string>());

            do
            {
                Console.WriteLine("Ingrese la cantidad de kilos a lavar (debe ser entre 10 y 30 kg):");
                double kilos = double.Parse(Console.ReadLine());
                if (kilos < 10 || kilos > 30)
                {
                    Console.WriteLine("La cantidad de kilos debe estar entre 10 y 30. Por favor, inténtelo nuevamente.");
                    continue;
                }

                Console.WriteLine("Ingrese su nombre:");
                nombreCliente = Console.ReadLine();

                List<string> tiposRopa = new List<string>();

                lavadora = new Lavadora(kilos, tiposRopa);

                Lavadora.IniciarContadorTiempo(); // Iniciar contador de tiempo al comenzar el lavado

                lavadora.CicloTerminado(nombreCliente);

                Console.WriteLine("Presione 'Q' para salir o cualquier tecla para continuar lavando:");
            } while (Console.ReadLine().ToUpper() != "Q");

            Lavadora.MostrarResultados();
            Console.ReadKey();
        }
    }
}