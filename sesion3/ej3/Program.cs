// Calcular la suma de todos los numeros pares entre 1 y n usando while

Console.Write("Ingrese un numero limite: ");
int limite = Convert.ToInt32(Console.ReadLine());

int suma = 0;
int contador = 2;

while (contador <= limite)
{
    suma += contador;
    contador += 2;
}

Console.WriteLine($"La suma de los numeros pares del 1 al {limite} es: {suma}");
