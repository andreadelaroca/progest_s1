/* Evaluar la calificación de un estudiante y mostrar si aprobó (≥70), 
recuperación (50–69) o reprobó (<50) con if. */

Console.Write("Ingrese su nota: ");
double nota = Convert.ToDouble(Console.ReadLine());

if (100 >= nota >= 70)
{
    Console.WriteLine("Aprobo");
}
else if (50 <= nota <= 69)
{
    Console.WriteLine("Debe asistir a recuperacion");
}
else if (0 <= nota <= 50)
{
    Console.WriteLine("Reprobo");
}
else
{
    Console.WriteLine("Nota invalida");
}