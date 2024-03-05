using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoCuent
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CuentaCorrient Cuenta1 = new CuentaCorrient(500, "Juan Gomez");
            CuentaCorrient Cuenta2 = new CuentaCorrient(2500, "Maria Lopez");

            //le pasamos los datos de cada cuenta por parametro, de una sacamos y llevamos a otra

            CuentaCorrient.transferencia(Cuenta1, Cuenta2, 200);

            //pedimos los datos de cada cuenta para ver el saldo

            Console.WriteLine(Cuenta1.getDatosCuenta());
            Console.WriteLine(Cuenta2.getDatosCuenta());


        }
    }
}