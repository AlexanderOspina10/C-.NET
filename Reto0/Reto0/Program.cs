using System.Timers;


//Pedir datos
Console.WriteLine("Ingrese el nombre");
string nombre = Console.ReadLine();

Console.WriteLine("Ingrese su sueldo");
double sueldo = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el numero de sus hijos");
int hijos = int.Parse(Console.ReadLine());


//Inicializar variables
double bono = 0;
double totalPagar = 0;


//Condiciones

if (hijos == 0 && sueldo <= 1160000)
{
    bono = 0;
    totalPagar = 0;
    Console.WriteLine($"{nombre} el bono es: {bono:N} y el total a pagar con el sueldo es: {sueldo:N}");

} else if (hijos <= 3 && sueldo <= 2320000)
{
    //Realizar el porcentaje del bono a pagar
    bono = (sueldo * 10) / 100;
    totalPagar = sueldo + bono;
    Console.WriteLine($"{nombre} el bono es: {bono:N} y el total a pagar con el sueldo es: {totalPagar:N}");

} else if (hijos < 5 && sueldo <= 1160000)
{
    //Realizar el porcentaje del bono a pagar
    bono = (sueldo * 25) / 100;
    totalPagar = sueldo + bono;
    Console.WriteLine($"{nombre} el bono es: {bono:N} y el total a pagar con el sueldo es: {totalPagar:N}");

} else
{
    bono = 0;
    Console.WriteLine($"{nombre} el bono es: {bono:N} y el total a pagar con el sueldo es: {sueldo:N}");
}

//Tecla para que el sistema finalice

Console.WriteLine("Presione cualquier tecla para finalizar");
Console.ReadKey();