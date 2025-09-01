// Pedir un número entre 1 y 7 y mostrar el día de la semana con switch.

Console.Write("Ingrese un numero entro 1 y 7: ");
int diaSemana = Convert.ToInt32(Console.ReadLine());
string nombreDia;

switch (diaSemana)
{
    case 1:
        nombreDia = "Lunes";
        break;
    case 2:
        nombreDia = "Martes";
        break;
    case 3:
        nombreDia = "Miercoles";
        break;
    case 4:
        nombreDia = "Jueves";
        break;
    case 5:
        nombreDia = "Viernes";
        break;
    case 6:
        nombreDia = "Sabado";
        break;
    case 7:
        nombreDia = "Domingo";
        break;
    default:
        nombreDia = "Dia invalido";
        break;
}

Console.WriteLine($"El dia {diaSemana} es {nombreDia}");