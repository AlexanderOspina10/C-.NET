
//Pedir datos
Console.WriteLine("A que distancia se encuentra su vivienda de la universidad en KM");
float distancia = float.Parse(Console.ReadLine());

Console.WriteLine("Cuales son sus ingresos familiares");
double ingresos = double.Parse(Console.ReadLine());

Console.WriteLine("Cual es su estrato socieconomico");
int estrato = int.Parse(Console.ReadLine());

//Inicializar valores
double beca = 0;

//Fecha de realización
DateTime FechaHora = DateTime.Now;

//Condicional

if (distancia>5 && ingresos<600000 && estrato <= 2)
{
    //Calculo de la beca
    beca = (1300000 * 44) / 100;
    Console.WriteLine($"Ganaste la beca, el estudio se realizo {FechaHora}, tienes una beca por valor de: {beca}");


//Condicionales para no aplicar

}else if (ingresos > 600000 && distancia < 5 && estrato > 2)
{
    Console.WriteLine("No aplica para beca, no cumples con ninguna de las politicas.");
}
else if (ingresos > 600000 && distancia < 5)
{
    Console.WriteLine("No aplica para beca, no cumples con los ingresos y la distancia.");
}
else if (distancia < 5 && estrato > 2)
{
    Console.WriteLine("No aplica para beca, no cumples con la distancia y el estrato.");
}
else if (ingresos > 600000 && estrato > 2)
{
    Console.WriteLine("No aplica para beca, no cumples con los ingresos y el estrato.");
}

else if (distancia<5)
{
    Console.WriteLine("No aplica para beca, vives muy cerca de la universidad");
}else if (ingresos > 600000)
{
    Console.WriteLine("No aplica para beca, sus ingresos son superiores a las politicas");
} else if (estrato > 2)
{
    Console.WriteLine("No aplica para beca, su estrato es mayor al solicitado");
}

    //Tecla para finalizar
    Console.WriteLine("Presiona cualquier tecla para finalizar");
    Console.ReadKey();