Console.WriteLine("Ingrese su edad");
int edad = int.Parse(Console.ReadLine());


if (edad >= 0 && edad <= 5)
{
    Console.WriteLine("Infante");
}
else if (edad > 5 && edad <= 10)
{
    Console.WriteLine("Niño");
}
else if (edad > 10 && edad <= 15)
{
    Console.WriteLine("Pre adolescente");
}
else if (edad > 15 && edad <= 18)
{
    Console.WriteLine("Adolescente");
}
else if (edad > 18 && edad <= 25)
{
    Console.WriteLine("Pre adulto");
}
else if (edad > 25 && edad <= 40)
{
    Console.WriteLine("Adulto");
}
else if (edad > 10 && edad <= 55)
{
    Console.WriteLine("Pre anciano");
} else 
{
    Console.WriteLine("Anciano");
}