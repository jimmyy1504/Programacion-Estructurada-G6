namespace funcion1
{
    internal class Program
    {
        static String Saludar(string nombre)
        {
            return $"hola {nombre}, mucho gusto";
        } 
        //Leer la edad y decir si es niño (0-13), joven (14-18), adulto (19-++)
        static void Main(string[] args)
        {
            Console.Write("Introduce tu edad: ");
            int edad = int.Parse(Console.ReadLine()!);

            if (edad >= 0 && edad <= 13)
            {
                Console.WriteLine("Eres un niño");
            }
            else if (edad <= 18)
            {
                Console.WriteLine("Eres un joven");
            }
            else
            {
                Console.WriteLine("Eres un adulto");
            }


            static void Main(string[] args)
            {
                String nombre;
                Console.Write("Dime tu nombre: ");
                nombre = Console.ReadLine()!;
                Console.WriteLine(Saludar(nombre));
            }
        }
    }
}