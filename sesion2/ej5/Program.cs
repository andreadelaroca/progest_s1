// Crear un programa que determine si un año es bisiesto usando if y operadores lógicos.

Console.Write("Ingrese un año: ");
int bisiesto = Convert.ToInt32(Console.ReadLine());

if (bisiesto % 4 == 0 && bisiesto % 100 != 0 || bisiesto % 400 == 0)
{
    Console.WriteLine($"{bisiesto} es un año bisiesto");
}
else
{
    Console.WriteLine($"{bisiesto} no es un año bisiesto");
}