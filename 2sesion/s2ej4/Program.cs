Console.Write("Introduce la calificación del estudiante: ");
int calificacion = Convert.ToInt32(Console.ReadLine());

switch (calificacion)
{
    case int n when n >= 70:
        Console.WriteLine("Aprobado");
        break;
    case int n when n >= 50 && n <= 69:
        Console.WriteLine("Recuperación");
        break;
    case int n when n < 50:
        Console.WriteLine("Reprobado");
        break;
    default:
        Console.WriteLine("Calificación inválida");
        break;
}
