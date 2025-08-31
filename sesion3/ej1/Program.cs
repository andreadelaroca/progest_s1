// Validar si una entrada es un número positivo

string entrada = string.Empty;
bool entradaValida = false;

while (!entradaValida)
{
    Console.Write("Ingrese un número positivo: ");
    string? entradaUsuario = Console.ReadLine();

    if (int.TryParse(entradaUsuario, out int numero) && numero > 0)
    {
        entrada = entradaUsuario;
        entradaValida = true;
    }
    else
    {
        Console.WriteLine("Entrada inválida. Intente de nuevo.");
    }
}

Console.WriteLine($"Número ingresado: {entrada} (positivo)");
