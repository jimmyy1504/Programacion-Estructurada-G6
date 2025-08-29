Console.Write("Introduce la calificación del estudiante: ");
int calificacion = Convert.ToInt32(Console.ReadLine());

if (calificacion >= 70)
{
    Console.WriteLine("Aprobado");
}
else if (calificacion >= 50)
{
    Console.WriteLine("Recuperación");
}
else
{
    Console.WriteLine("Reprobado");
}