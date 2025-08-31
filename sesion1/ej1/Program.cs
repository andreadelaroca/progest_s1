/* Desarrolle un programa que calcule el área total en manzanas de un terreno rectangular, 
donde el usuario ingresa la longitud y el ancho en varas (1 manzana = 1,428.8 varas²), 
utilizando una cantidad fija de 5 varas de ancho y la longitud como entrada. */

Console.Write("Ingrese la longitud del terreno en varas: ");
double longitud = Convert.ToDouble(Console.ReadLine());

int ancho = 5;
Console.Write($"El valor fijo del ancho son {ancho} varas.");

double areaVaras = longitud * ancho;
double areaManzanas = areaVaras / 1428.8;

Console.WriteLine($"El area en varas cuadradas es de {areaVaras}");
Console.WriteLine($"El area en manzanas es de {areaManzanas}");
