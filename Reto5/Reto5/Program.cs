using System.Diagnostics;

//Opciones de switch
Console.WriteLine("Bienvenido a la tienda virtual, seleccione el producto");
Console.WriteLine("1.Teclado inalámbrico");
Console.WriteLine("2.Mouse inalámbrico");
Console.WriteLine("3.DRON con cámara");
Console.WriteLine("4.Tablet Huawei");
Console.WriteLine("5.Portátil Lenovo E480");
Console.WriteLine("6.Xbox 360");
int opcion = int.Parse(Console.ReadLine());

//Inicialización de variables
double valorProducto = 0;
double descuento = 0;
double totalPagar = 0;
double Iva = 0;


//Casos de la opcion
switch (opcion)
{
    case 1:
        valorProducto = 32000;
        descuento = (valorProducto * 3) / 100;
        totalPagar = valorProducto - descuento;
        Console.WriteLine($"El valor del producto es {valorProducto:N}, tiene un descuento de {descuento:N} y el valor total a pagar es {totalPagar:N}"); 
        break;
    case 2:
        valorProducto = 25000;
        descuento = 0;
        totalPagar = valorProducto - descuento;
        Console.WriteLine($"El valor del producto es {valorProducto:N}, tiene un descuento de {descuento:N} y el valor total a pagar es {totalPagar:N}");
        break;
    case 3:
        valorProducto = 10000;
        descuento = (valorProducto * 5) / 100;
        totalPagar = valorProducto - descuento;
        Console.WriteLine($"El valor del producto es {valorProducto:N}, tiene un descuento de {descuento:N} y el valor total a pagar es {totalPagar:N}");

        break;
    case 4:
        valorProducto = 155000;
        descuento = (valorProducto * 8) / 100;
        totalPagar = valorProducto - descuento;
        Console.WriteLine($"El valor del producto es {valorProducto:N}, tiene un descuento de {descuento:N} y el valor total a pagar es {totalPagar:N}");

        break;
    case 5:
        valorProducto = 1345000;
        Iva = (valorProducto * 19) / 100;
        totalPagar = valorProducto + Iva;
        Console.WriteLine($"El valor del producto es {valorProducto:N}, tiene un iva de {Iva:N} y el valor total a pagar es {totalPagar:N}");
        break;
    case 6:
        valorProducto = 1490000;
        Iva = (valorProducto * 19) / 100;
        totalPagar = valorProducto + Iva;
        Console.WriteLine($"El valor del producto es {valorProducto:N}, tiene un iva de {Iva:N} y el valor total a pagar es {totalPagar:N}");
        break;

    default:
        Console.WriteLine("Opción no valida, el producto no existe");
        break;
}

Console.WriteLine("Presione cualquier tecla para finalizar");
Console.ReadKey();