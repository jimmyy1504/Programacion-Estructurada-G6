using System.ComponentModel.Design;

namespace practica_en_equipo_S2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingresa el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el tercer número: ");
            int num3 = int.Parse(Console.ReadLine());

            int mayor = num1; // asumimos que el primero es el mayor

            if (num2 > mayor)
            {
                mayor = num2;
            }

            if (num3 > mayor)
            {
                mayor = num3;
            }

            Console.WriteLine($"\nEl número mayor es: {mayor}");
        }
    }
        
    }
}
