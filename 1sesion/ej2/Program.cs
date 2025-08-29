const double Distancia = 40.0;

Console.WriteLine("Introduce la velocidad en km/h la que va el bus: ");
double velocidad = Convert.ToDouble(Console.ReadLine());

if (velocidad <= 0)
{
Console.WriteLine("La velocidad debe ser mayor que 0");
}
else
{ 
double tiempo = Distancia / velocidad;
Console.WriteLine($"El tiempo toal que tomara el viaje es de {tiempo:F2} horas");
}
