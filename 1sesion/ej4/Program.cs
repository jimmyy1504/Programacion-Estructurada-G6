Console.WriteLine("Introduce la longitud del tanque en metros : ");
double longitud = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Introduce la altura del tanque en metros : ");
double altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Introduce el ancho del tanque en metros : ");
double ancho = Convert.ToDouble(Console.ReadLine());

if (ancho < 0 || longitud < 0 || altura < 0)
{
    Console.WriteLine("Los valores deben ser positivos");
}
else
{
    double volumen = longitud * ancho * altura;
    Console.WriteLine($"El volumen del tanque es de {volumen:F3} metros^3");
}