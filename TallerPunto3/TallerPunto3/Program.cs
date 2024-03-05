Console.WriteLine("Ingrese la velocidad en la que va");
int velocidad = int.Parse(Console.ReadLine());

DateTime FechaHora = DateTime.Now;

if (velocidad < 30)
{
    Console.WriteLine($"Está transitando por una Zonas Escolares a {velocidad}KM/H, la velocidad maxima es 30KM/H,{FechaHora}");
}else if (velocidad < 60)
{
    Console.WriteLine($"Está transitando por una Vías Urbanas a {velocidad}KM/H, la velocidad maxima es 60KM/H,{FechaHora}");
}else if (velocidad < 80)
{
    Console.WriteLine($"Está transitando por una Vías Rurales a {velocidad}KM/H, la velocidad maxima es 80KM/H,{FechaHora}");
}
else
{
    Console.WriteLine($"Está transitando por una Rutas Nacionale a {velocidad}KM/H, la velocidad maxima es 100KM/H,{FechaHora}"); 
}

Console.WriteLine("Presione cualquier tecla para finalizar");
Console.ReadKey();