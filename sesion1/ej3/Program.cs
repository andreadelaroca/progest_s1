/* Desarrolle un programa que calcule la distancia total recorrida en kilómetros 
por un ciclista en el malecón de San Juan del Sur, utilizando como entradas la 
velocidad promedio en kilómetros por hora y el tiempo recorrido, ambos proporcionados 
por el usuario. */

Console.WriteLine("Calculo de distancia recorrida en Km");

Console.Write("Ingrese la velocidad promedio en Km/h: ");
double velocidad = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el tiempo total: ");
double tiempo = Convert.ToDouble(Console.ReadLine());

double distancia = velocidad * tiempo;
Console.WriteLine($"La distancia total recorrida es de {distancia}Km");
