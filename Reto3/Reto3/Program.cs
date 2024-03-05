
//Pedir datos
Console.WriteLine("Ingrese su salario");
double salario = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su edad");
int edad = int.Parse(Console.ReadLine());

//Inicializar variables
double subsidio = 0;
double totalPagar = 0;

//Condicionales
if (salario < 908526)
{
    if(edad < 18)
    {
        Console.WriteLine("No tiene derecho al subsidio");
    } else if (edad <= 39)
    {
        //Calculo valor del subsidio y total.
        subsidio = (salario * 5) / 100;
        totalPagar = salario + subsidio;
        Console.WriteLine($"El subsidio se aprobo por {subsidio:N}, el pago total es {totalPagar:N} ");
    } else if (edad <= 64) 
    {
        //Calculo valor del subsidio y total.
        subsidio = (salario * 7) / 100;
        totalPagar = salario + subsidio;
        Console.WriteLine($"El subsidio se aprobo por {subsidio:N}, el pago total es {totalPagar:N} ");

    }
    else
    {
        //Calculo valor del subsidio y total.
        subsidio = (salario * 10) / 100;
        totalPagar = salario + subsidio;
        Console.WriteLine($"El subsidio se aprobo por {subsidio:N}, el pago total es {totalPagar:N} ");
    }
}
else
{
    Console.WriteLine("No aplica para el subsidio");
}

Console.WriteLine("Presione cualquier tecla para finalizar");
Console.ReadKey();