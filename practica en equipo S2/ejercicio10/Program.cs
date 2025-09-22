using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el número de días: ");
        int dias = int.Parse(Console.ReadLine());

        if (dias < 0)
        {
            Console.WriteLine("Error: no se pueden ingresar días negativos.");
        }
        else
        {
            int semanas = dias / 7;       // semanas completas
            int sobrantes = dias % 7;     // días que sobran

            Console.WriteLine($"\n{dias} días son {semanas} semana(s) y {sobrantes} día(s).");
        }
    }
}
