using System.Runtime.Serialization;


Console.WriteLine("Colocar signo de pesos y separadores de mil: ");
double precioVenta = 100767.89;

Console.WriteLine($"El precio de venta es : {precioVenta:C}");
Console.ReadKey();
Console.WriteLine("-----------------------------------------------------");


//Formatear porcentaje

Console.WriteLine("Formateo porcentaje usando ToString");
double porcentaje = 0.15;
string porcentajeFormateado = porcentaje.ToString("P");
Console.WriteLine("El porcentaje de 0.15 es: "+porcentajeFormateado);
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("Presiona una tecla para continuar");
Console.ReadKey();


Console.WriteLine("Mostrar dos decimales");
double dosdecimales = 10345456.78898;
Console.WriteLine($"El valor con dos decimales es: {dosdecimales:F2}");
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("Presiona una tecla para continuar");
Console.ReadKey();


Console.WriteLine("Mostrar diferentes formatos");
int numero = 1234567;
string numeroFormateado1 = numero.ToString("N"); //
string numeroFormateado2 = numero.ToString("N2"); //
string numeroFormateado3 = numero.ToString("D8"); //
string numeroFormateado4 = string.Format("{0:C}", numero);
Console.WriteLine("Salida formato 1 " + numeroFormateado1);
Console.WriteLine("Salida formato 2 " + numeroFormateado2); //
Console.WriteLine("Salida formato 3 " + numeroFormateado3); //
Console.WriteLine("Salida formato 4 " + numeroFormateado4); //
Console.WriteLine("------------------------------------------------------ ");
Console.WriteLine("Presiona una tecla para continuar..");
Console.ReadKey();
Console.WriteLine("Esto tardará 8 segundos en ejcutar");
Thread.Sleep(8000);
Console.WriteLine("------------------------------------------------------ ");
Console.WriteLine("Presiona una tecla para continuar..");
Console.ReadKey();
Console.WriteLine("Formateo de cadenas:");
string nombre = "Juan";

int edad = 30;
string formatoCadena1 = string.Format("Mi nombre es: {0} y tengo {1} años.",
nombre, edad); //
string formatoCadena2 = $"Mi nombre es {nombre} y tengo {edad} años."; //
string formatoCadena3 = string.Format("El número es: {0,-10}", 42); //
string formatoCadena4 = string.Format("El número es: {0,10}", 42); //
Console.WriteLine(formatoCadena1); //
Console.WriteLine(formatoCadena2); //
Console.WriteLine(formatoCadena3); //
Console.WriteLine(formatoCadena4); //
Console.WriteLine("------------------------------------------------------ ");
Console.WriteLine("Presiona una tecla para continuar..");
Console.ReadKey();
// Formateo de fecha y hora
Console.WriteLine("Formateo de Fecha y hora:");
DateTime fechaHoraActual = DateTime.Now;
string formatoFecha1 = fechaHoraActual.ToString("d"); //
string formatoFecha2 = fechaHoraActual.ToString("D"); //
string formatoHora = fechaHoraActual.ToString("T"); //
Console.WriteLine("Formato d fecha 1 " + formatoFecha1);
Console.WriteLine("Formato d fecha 2 " + formatoFecha2);
Console.WriteLine("Formato hora " + formatoHora); //
Console.WriteLine("------------------------------------------------------ ");
Console.WriteLine("Presiona una tecla para continuar..");
Console.ReadKey();
Console.WriteLine("Formateo de valores booleanos:");
bool esVerdadero = true;
string valorBooleano1 = esVerdadero.ToString(); //
string valorBooleano2 = esVerdadero.ToString().ToUpper(); //
string valorBooleano3 = esVerdadero ? "Sí" : "No"; //
Console.WriteLine(valorBooleano1); //
Console.WriteLine(valorBooleano2); //
Console.WriteLine(valorBooleano3); //
Console.WriteLine("------------------------------------------------------ ");
Console.WriteLine("Presiona una tecla para continuar..");
Console.ReadKey();

//Cambiar el color del texto usando Console.ForegroundColor:
Console.ForegroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Color Azul");
Console.ResetColor();//resetear Color
Console.WriteLine("Texto normal");
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("Fondo amarillo");
Console.WriteLine("Presiona una tecla para continuar...");
Console.ReadKey();
//Limpiar la consola
Console.WriteLine("Limpiando La consola");
Console.Clear();










