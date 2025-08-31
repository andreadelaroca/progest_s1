/* Desarrolle un programa que calcule el tiempo total en horas de un viaje en bus 
desde Managua a Granada, donde el usuario ingresa la velocidad promedio en kilómetros 
por hora como entrada, asumiendo una distancia fija de 40 kilómetros. */

Console.Write("Ingrese la velocidad promedio en Km/h: ");
double velocidad = Convert.ToDouble(Console.ReadLine());

int distancia = 40;
Console.WriteLine($"La distancia fija es de {distancia}Km");

double tiempo = distancia / velocidad;
Console.WriteLine($"El tiempo total de viaje es de {tiempo} horas.");
