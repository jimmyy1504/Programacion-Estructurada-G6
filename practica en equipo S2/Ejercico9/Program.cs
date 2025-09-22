using System;

class Program
{
    static void Main()
    { int num1, num2, num3;

Console.Write("Ingresa el primer número: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Ingresa el segundo número: ");
num2 = int.Parse(Console.ReadLine());

Console.Write("Ingresa el tercer número: ");
num3 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("El número mayor es: " + num1);
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine("El número mayor es: " + num2);
}
else if (num3 > num1 && num3 > num2)
{
    Console.WriteLine("El número mayor es: " + num3);
}
else
{
    Console.WriteLine("Algunos números son iguales, por favor ingresa valores diferentes.");
}
