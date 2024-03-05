//Pedi datos
Console.WriteLine("Ingrese la edad");
int edad = int.Parse(Console.ReadLine());

//Convertir string a todo miniscula
Console.WriteLine("¿Está inscrito al programa?");
string respuesta = Console.ReadLine().ToLower();

//condicional para aprobación
if (edad >= 18 && edad <= 25)
{
    if (respuesta == "si")
    {
        Console.WriteLine($"Puedes pasar tienes {edad} años");
    }
}
else
{
    Console.WriteLine($"Acceso no aprobado, tienes {edad} años ");
}

Console.WriteLine("Presione cualquier tecla para finalizar");
Console.ReadKey();