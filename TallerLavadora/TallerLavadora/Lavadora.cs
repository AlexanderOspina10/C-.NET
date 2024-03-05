using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using WMPLib;


namespace TallerLavadora
{
    class Lavadora
    {
        // Atributos
        private double kilos;
        private int tiempoExtra;
        private List<string> tiposRopa;
        private static int clientesAtendidos = 0;
        private static double gananciasTotales = 0;
        private static DateTime tiempoInicio; // Tiempo de inicio del lavado
        

        // Constructor
        public Lavadora(double kilos, List<string> tiposRopa)
        {
            this.kilos = kilos;
            this.tiposRopa = tiposRopa;

    
        }

        // Getters y Setters
        public double Kilos
        {
            get { return kilos; }
            private set { kilos = value; }
        }


        // Métodos


        private void LlenarAgua()
        {
            WindowsMediaPlayer wplayer;

           

            Console.WriteLine("Llenando...");
            wplayer = new WindowsMediaPlayer();
            wplayer.URL = @"D:\Escritorio\C#.NET\TallerLavadora\Sonidos\Llenado.mp3";
            wplayer.controls.play();
            Thread.Sleep(7000);
            wplayer.controls.pause();
            
          
        }

        private void Lavar()
        {
            WindowsMediaPlayer wplayer;

            

            Console.WriteLine("Lavando...");
            wplayer = new WindowsMediaPlayer();
            wplayer.URL = @"D:\Escritorio\C#.NET\TallerLavadora\Sonidos\Lavado.mp3";
            wplayer.controls.play();
            Thread.Sleep(7000);
            wplayer.controls.pause();

        }

        private void Enjuagar()
        {
            WindowsMediaPlayer wplayer;

            Console.WriteLine("Enjuagando...");
            wplayer = new WindowsMediaPlayer();
            wplayer.URL = @"D:\Escritorio\C#.NET\TallerLavadora\Sonidos\Enjuagar.mp3";
            wplayer.controls.play();
            Thread.Sleep(7000);
            wplayer.controls.pause();
        }

        private void Secar()
        {
            WindowsMediaPlayer wplayer;


            Console.WriteLine("Secando...");
            wplayer = new WindowsMediaPlayer();
            wplayer.URL = @"D:\Escritorio\C#.NET\TallerLavadora\Sonidos\Secar.mp3";
            wplayer.controls.play();
            Thread.Sleep(7000);
            wplayer.controls.pause();

        }

        public void CicloTerminado(string nombreCliente)
        {
            try
            {
                Console.WriteLine("Ingrese el tipo de ropa  a lavar:\n1.algodon,lycra,seda,delicada,tela\n2.jean, campera, sucia, rigida\n3.sabana, toalla, acolchado, cortina");
                

                tiposRopa = new List<string>();
                string tipoRopa = Console.ReadLine();
                tiposRopa.Add(tipoRopa);

                //Variable para validar la recomendacion de la temperatura
                string validacionTipo = tipoRopa.ToLower();

                // Recomendaciones de lavado
                Console.WriteLine("Recomendaciones de lavado:");
                if (validacionTipo == "color" || validacionTipo == "algodon" || validacionTipo == "lycra" || validacionTipo == "seda" || validacionTipo == "delicada" || validacionTipo == "tela")
                {
                    Console.WriteLine("Agua fría (hasta 20 º): se recomienda para ropa de colores, algodón, lycra, sedas, prendas delicadas y telas que puedan achicarse.");
                }
                else if (validacionTipo == "jean" || validacionTipo == "campera" || validacionTipo == "sucia" || validacionTipo == "rigida")
                {
                    Console.WriteLine("Agua tibia (entre 30 a 50º): se recomienda para jeans, camperas, ropa muy sucia o poco delicada.");
                }
                else if (validacionTipo == "toalla" || validacionTipo == "sabana" || validacionTipo == "acolchado" || validacionTipo == "cortina")
                {
                    Console.WriteLine("Agua caliente (entre 55 a 90º): se recomienda para toallas, sábanas o acolchados, telas blancas gruesas y cortinas de baño.");
                }
                else
                {
                    Console.WriteLine("No se tiene una recomendación precisa de la temperatura para el tipo de ropa ingresado");
                }


                LlenarAgua();
                Lavar();
                Enjuagar();

                Console.WriteLine("¿Desea secar la ropa ahora? (S/N)");
                string opcion = Console.ReadLine();

                if (opcion.ToUpper() == "S")
                {
                    Secar();
                }
                else
                {
                    Console.WriteLine("Proceso de secado detenido. Presione 'Reanudar' cuando esté listo para continuar.");
                    while (Console.ReadLine().ToUpper() != "REANUDAR")
                    {
                        Console.WriteLine("Presione 'Reanudar' para continuar.");
                    }
                    Secar(); // Continuar secado una vez se reanude
                }

                // Calcular costo del lavado
                double costoLavado = kilos * 4000; // $4000 por kilo
                if (tipoRopa.ToLower() == "color" || tipoRopa.ToLower() == "algodon")
                {
                    costoLavado *= 1.05; // Aumento del 5% para ropa de color o algodón
                }

                // Calcular ganancias para el dueño
                double gananciaDueño = costoLavado * 0.3;

                // Calcular costo total para el cliente con IVA incluido
                double costoTotalCliente = costoLavado * 1.19; // IVA del 19%

                // Actualizar contador de clientes atendidos y ganancias totales
                clientesAtendidos++;
                gananciasTotales += gananciaDueño;

                Console.WriteLine($"Cliente: {nombreCliente}");
                Console.WriteLine($"Fecha y hora del lavado: {DateTime.Now}");

                // Mostrar tiempo total de lavado
                TimeSpan tiempoLavado = DateTime.Now - tiempoInicio;
                Console.WriteLine($"Tiempo total de lavado: {tiempoLavado.TotalMinutes} minutos ({tiempoLavado.TotalSeconds} segundos)");


                // Calcular consumo de energía
                double consumoEnergia = (tiempoLavado.TotalMinutes) / 3600000; // Convertir a kWh

                // Calcular costo de energía
                double costoEnergia = consumoEnergia * 516.72; // $/kWh

                // Mostrar resultados
                Console.WriteLine("Ciclo terminado!");
                Console.WriteLine($"Costo de lavado (IVA incluido): ${costoTotalCliente}");
                Console.WriteLine($"Ganancia del dueño: ${gananciaDueño}");
                Console.WriteLine($"Costo de energía: ${costoEnergia}");
                Console.WriteLine($"Cantidad de kWh consumidos: {consumoEnergia} kWh");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public static void MostrarResultados()
        {
            Console.WriteLine($"Clientes atendidos: {clientesAtendidos}");
            Console.WriteLine($"Ganancias totales: ${gananciasTotales}");
        }

        // Método para iniciar el contador de tiempo al comenzar el lavado
        public static void IniciarContadorTiempo()
        {
            tiempoInicio = DateTime.Now;
        }
    }

}