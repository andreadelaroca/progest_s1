/* Desarrolle un programa que calcule la cantidad total de baldes de leche producida 
en un día en una lechería de Estelí, utilizando como entradas el volumen promedio 
por vaca en litros y el número total de vacas ordeñadas, ambos proporcionados por 
el usuario (1 balde = 20 litros). */

Console.WriteLine("Calculo de total de baldes de leche producida en un dia");

Console.Write("Ingrese el volumen promedio en litros: ");
double v = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el numero total de vacas ordeñadas: ");
int vacas = Convert.ToInt32(Console.ReadLine());

double baldes = (v * vacas) / 20;
Console.WriteLine($"La cantidad total de baldes producido es de {baldes}l");