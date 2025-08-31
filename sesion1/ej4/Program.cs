/* Desarrolle un programa que calcule el volumen total en metros cúbicos de agua 
recolectada en un tanque en una finca de Masaya, utilizando como entradas la longitud, 
el ancho y la altura del tanque, todos proporcionados por el usuario.*/

Console.WriteLine("Calculo del volumen de un tanque de agua");

Console.Write("Ingrese la unidad de medida: ");
string medida = Console.ReadLine();

Console.Write("Ingrese la longitud del tanque: ");
double l = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el ancho del tanque: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la altura del tanque: ");
double h = Convert.ToDouble(Console.ReadLine());

double v = l * a * h;
Console.WriteLine($"El volumen del tanque es de {v}{medida}");
