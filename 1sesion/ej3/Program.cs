Console.WriteLine("Introduce la velocidad en km/h a la que va el ciclista: ");
double velocidad = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Introduce el tiempo en horas que hizo el ciclista: ");
double tiempo = Convert.ToDouble(Console.ReadLine());
if (velocidad <= 0 || tiempo <= 0)
{
Console.WriteLine("Los valores deben ser positivos");
}
else 
{
double distancia = velocidad * tiempo; 
Console.WriteLine($"La distancia recorrida en el malecon de San Juan del Sur fue de: {distancia:F2} km");
}