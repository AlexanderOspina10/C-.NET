using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainVehiculo
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            //CREAR UN ARREGLO DE VEHICULOS
            Vehiculo[] misVehiculos = new Vehiculo[4];

            //FIJA UN VEHICULO EN MI ARREGLO INSTANCIADO DESDE LA CLASE PADRE

            misVehiculos[0] = new Vehiculo("GH67", "FERRARI", "A89");


            //AQUI SE APLICA EL POLIMORFISMO
            //GUARDE UNA INSTANCIA DE UNA CLASE HIJA
            misVehiculos[1] = new VehiculoTurismo(4, "GH56","HOLA","CHAO");
            misVehiculos[2] = new VehiculoDeportivo("SFS65","SADSA515","DSA5D1AS",500);
            misVehiculos[3] = new VehiculoFurgoneta("DASDA","SDAD6","ADD6SAD36",2500);

            foreach (Vehiculo vehiculo in misVehiculos)
            {
                Console.WriteLine(vehiculo.mostrarDatos());
                Console.WriteLine("");
            }

        }
    }
}
