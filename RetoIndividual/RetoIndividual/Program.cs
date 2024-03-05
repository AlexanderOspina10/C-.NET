

//Pedir Datos
Console.WriteLine("Ingrese el nombre del empleado");
String nombre = Console.ReadLine();

Console.WriteLine("Ingrese su codigo de empleado");
int codigo = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de horas");
double horas =  double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el valor de la hora");
double valorHora = double.Parse(Console.ReadLine());

//Calculo del total
double totalPagar = horas * valorHora;

//Sin formato
Console.WriteLine($"{nombre} - {codigo}, el valor a cancelar por las {horas} horas laborades es: " + totalPagar);
Console.WriteLine("Presiona una tecla para continuar..");
Console.ReadKey();

//formato de pesos y dos decimas por encima
Console.WriteLine($"{nombre} - {codigo}, el valor a cancelar por las {horas} horas laborades es: {totalPagar:C2} ");
Console.WriteLine("Presiona una tecla para continuar..");
Console.ReadKey();

//formato de pesos y redondeado al número más cercano y a 2 decimales
double totalPagarRedondeado = Math.Ceiling(totalPagar * 100) / 100; 
Console.WriteLine($"{nombre} - {codigo}, el valor a cancelar por las {horas} horas laborades es: {totalPagarRedondeado:C2} ");
Console.WriteLine("Presiona una tecla para continuar..");
Console.ReadKey();

//Condicional de +2 salarios minimos
if (totalPagar > 2600000)
{
    Console.WriteLine("No recibe auxilio de transporte");
} else
{
    Console.WriteLine("Recibe auxilio de transporte");
}







