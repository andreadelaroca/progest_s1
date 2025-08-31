// contar las vocales en una cadena usando foreach

Console.Write("Ingrese una frase: ");
string frase = Console.ReadLine().ToLower();
int contadorVocales = 0;

foreach (char c in frase)
{
    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
    {
        contadorVocales++;
    }
}

Console.WriteLine($"La frase tiene {contadorVocales} vocales");
