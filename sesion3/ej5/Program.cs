// calculo de factorial

int numero;

Console.WriteLine("Ingreso un numero entero positivo: ");
numero = int.Parse(Console.ReadLine());

int factorial = 1;
for (int i = 1; i <= numero; i++)
{
    factorial *= i;
}

Console.WriteLine($"El factorial de {numero} es {factorial}");
