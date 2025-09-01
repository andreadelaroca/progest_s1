// Repetir el ej3 usando switch con rangos aproximados.

Console.Write("Ingrese su nota: ");
int nota = Convert.ToDouble(Console.ReadLine());
char n;

if (70 <= nota <= 100)
{
    n = 'A';
}
else if (50 <= nota <= 69)
{
    n = 'B';
}
else if (0 <= nota <= 50)
{
    n = 'C';
}
else
{
    Console.WriteLine("Nota invalida");
}

switch (n)
{
    case 'A':
        Console.WriteLine("Aprobo");
        break;
    case 'B':
        Console.WriteLine("Debe asistir a recuperacion");
        break;
    case 'C':
        Console.WriteLine("Reprobo");
        break;
    default:
        break;
}