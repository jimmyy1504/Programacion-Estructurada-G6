using System.ComponentModel.Design;

namespace try2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introducir edad: ");
            int edad;
            edad = int.Parse(Console.ReadLine());
            if (edad > 14)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }
         }

    }
}
