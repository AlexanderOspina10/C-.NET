using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TallerEvaluativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO AL REGISTRO DE GYM SYSTEM");
            Console.WriteLine("Ingrese su nombre completo");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su documento de identidad");
            double documento = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su EPS");
            string eps = Console.ReadLine();
            Console.WriteLine("Ingrese su correo eletronico");
            string correo = Console.ReadLine();
            Console.WriteLine("Ingrese su direccion");
            string direccion = Console.ReadLine();
            Console.WriteLine("Ingrese su numero celular personal");
            double celular = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su fecha de nacimiento");
            string fechaNacimiento = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su grado de escolaridad: Bachiller\nTecnico\nTecnologo\nProfesional\nEspecialista");
            string escolaridad = Console.ReadLine();
            Console.WriteLine("Ingrese su peso");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su estatura");
            double estatura = double.Parse(Console.ReadLine());
            DateTime fechaRegistro = DateTime.Now;
            Console.WriteLine("Ingrese sus comorbilidades");

            Console.WriteLine("1.Enfermedades y trastornos del sistema nervioso.\n2.Enfermedades y trastornos del oído, nariz, boca y garganta.\n3.Enfermedades y trastornos del sistema respiratorio." +
                "\n4.Enfermedades y trastornos del sistema circulatorio.\n5.Enfermedades y trastornos del sistema digestivo.\n6.NO TIENE");
            int opcion=int.Parse(Console.ReadLine());

            string comorbilidades = "";

            if (opcion==1)
            {
                comorbilidades = "Enfermedades y trastornos del sistema nervioso";
            } else if (opcion==2)
            {
                comorbilidades = "Enfermedades y trastornos del oído, nariz, boca y garganta";
            }
            else if (opcion == 3)
            {
                comorbilidades = "Enfermedades y trastornos del sistema respiratorio.";
            }
            else if (opcion == 4)
            {
                comorbilidades = "Enfermedades y trastornos del sistema circulatorio.";
            }
            else
            {
                comorbilidades = "NO TIENE";
            }

            Console.WriteLine("Ingrese su metodo de pago:\n1.contado\n2.tarjeta credito");
            int metodoPago = int.Parse(Console.ReadLine());

            double valorPagar = 0;
            string metodo = "";

            if (metodoPago == 1)
            {
                valorPagar = 70000 - ((70000) * 10) / 100;
                metodo = "contado";
                
            }else if (metodoPago == 2)
            {
                valorPagar = 70000;
                metodo = "tarjeta credito";
            }

            double imc = (peso) / (estatura) * 2;

            if (edad<15)            {
                Console.WriteLine($"Por tu edad {edad} no es posible ingresar al gym todavía");
            }
            else if (imc<16.00)
            {
               
               Console.WriteLine("registro existoso!");
                Console.WriteLine("Su peso es demasiado bajo - Consulte su médico.");
                Console.WriteLine($"los datos de ingresos son:\nNombre:{nombre}\nDocumento:{documento}\nEps:{eps}\nCorreo:{correo}\nDireccion{direccion}\nTelefono:{celular}\nFecha de nacimiento:{fechaNacimiento}" +
                    $"\nedad:{edad}\ngrado de escolaridad:{escolaridad}\ncomorbilidades:{comorbilidades}\npeso:{peso:F2}\nestatura:{estatura:F2}");
                Console.WriteLine($"Metodo de pago{metodo} y el valor a pagar es {valorPagar}");

            }
            else if (imc < 16.99)
            {
                Console.WriteLine("registro existoso!");
                Console.WriteLine("Su peso es bajo - Incluya calorías y carbohidratos en su dieta.");
                Console.WriteLine($"los datos de ingresos son:\nNombre:{nombre}\nDocumento:{documento}\nEps:{eps}\nCorreo:{correo}\nDireccion{direccion}\nTelefono:{celular}\nFecha de nacimiento:{fechaNacimiento}" +
                   $"\nedad:{edad}\ngrado de escolaridad:{escolaridad}\ncomorbilidades:{comorbilidades}\npeso:{peso:F2}\nestatura:{estatura:F2}");
                Console.WriteLine($"Metodo de pago{metodo} y el valor a pagar es {valorPagar}");
            }
            else if(imc < 18.49)
            {
                Console.WriteLine("registro existoso!");
                Console.WriteLine("Su peso es ligeramente bajo - Mejore sus hábitos alimenticios.");
                Console.WriteLine($"los datos de ingresos son:\nNombre:{nombre}\nDocumento:{documento}\nEps:{eps}\nCorreo:{correo}\nDireccion{direccion}\nTelefono:{celular}\nFecha de nacimiento:{fechaNacimiento}" +
                   $"\nedad:{edad}\ngrado de escolaridad:{escolaridad}\ncomorbilidades:{comorbilidades}\npeso:{peso:F2}\nestatura:{estatura:F2}");
                Console.WriteLine($"Metodo de pago{metodo} y el valor a pagar es {valorPagar}");
            }
            else if (imc < 24.99)
            {
                Console.WriteLine("registro existoso!");
                Console.WriteLine("Usted tiene un peso saludable");
                Console.WriteLine($"los datos de ingresos son:\nNombre:{nombre}\nDocumento:{documento}\nEps:{eps}\nCorreo:{correo}\nDireccion{direccion}\nTelefono:{celular}\nFecha de nacimiento:{fechaNacimiento}" +
                  $"\nedad:{edad}\ngrado de escolaridad:{escolaridad}\ncomorbilidades:{comorbilidades}\npeso:{peso:F2}\nestatura:{estatura:F2}");
                Console.WriteLine($"Metodo de pago{metodo} y el valor a pagar es {valorPagar}");


            }
            else if (imc < 29.99)
            {
                Console.WriteLine("registro existoso!");
                Console.WriteLine("Su peso es levemente alto - Procure hacer ejercicio.");
                Console.WriteLine($"los datos de ingresos son:\nNombre:{nombre}\nDocumento:{documento}\nEps:{eps}\nCorreo:{correo}\nDireccion{direccion}\nTelefono:{celular}\nFecha de nacimiento:{fechaNacimiento}" +
                  $"\nedad:{edad}\ngrado de escolaridad:{escolaridad}\ncomorbilidades:{comorbilidades}\npeso:{peso:F2}\nestatura:{estatura:F2}");
                Console.WriteLine($"Metodo de pago{metodo} y el valor a pagar es {valorPagar}");
            }
            else if (imc<34.99)
            {
                Console.WriteLine("registro existoso!");
                Console.WriteLine("Su peso es alto - Controle su dieta y realice ejercicio.");
                Console.WriteLine($"los datos de ingresos son:\nNombre:{nombre}\nDocumento:{documento}\nEps:{eps}\nCorreo:{correo}\nDireccion{direccion}\nTelefono:{celular}\nFecha de nacimiento:{fechaNacimiento}" +
                 $"\nedad:{edad}\ngrado de escolaridad:{escolaridad}\ncomorbilidades:{comorbilidades}\npeso:{peso:F2}\nestatura:{estatura:F2}");
                Console.WriteLine($"Metodo de pago{metodo} y el valor a pagar es {valorPagar}");

            }
            else if (imc < 39.99)
            {
                Console.WriteLine("registro existoso!");
                Console.WriteLine("Su peso es muy alto - Visite a su médico y controle su dieta.");
                Console.WriteLine($"los datos de ingresos son:\nNombre:{nombre}\nDocumento:{documento}\nEps:{eps}\nCorreo:{correo}\nDireccion{direccion}\nTelefono:{celular}\nFecha de nacimiento:{fechaNacimiento}" +
                 $"\nedad:{edad}\ngrado de escolaridad:{escolaridad}\ncomorbilidades:{comorbilidades}\npeso:{peso:F2}\nestatura:{estatura:F2}");
                Console.WriteLine($"Metodo de pago{metodo} y el valor a pagar es {valorPagar}");

            }
            else
            {
                Console.WriteLine("registro existoso!");
                Console.WriteLine("Su peso es excesivamente alto - Visite a su médico cuanto antes.");
                Console.WriteLine($"los datos de ingresos son:\nNombre:{nombre}\nDocumento:{documento}\nEps:{eps}\nCorreo:{correo}\nDireccion{direccion}\nTelefono:{celular}\nFecha de nacimiento:{fechaNacimiento}" +
                 $"\nedad:{edad}\ngrado de escolaridad:{escolaridad}\ncomorbilidades:{comorbilidades}\npeso:{peso:F2}\nestatura:{estatura:F2}");
                Console.WriteLine($"Metodo de pago{metodo} y el valor a pagar es {valorPagar}");

            }

        }
    }
}

