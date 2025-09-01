// Determinar si un número ingresado es positivo, negativo o cero usando if.

Console.Write("Ingrese un numero: ");
int num = Conver.ToInt32(Console.ReadLine());

if (num == 0)
{
    Console.WriteLine($"{num} es 0");
}
else
{
    if (num > 0)
    {
        Console.WriteLine($"{num} es positivo");
    }
    else
    {
        Console.WriteLine($"{num} es negativo");
    }
}