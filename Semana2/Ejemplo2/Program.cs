





namespace Exception1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float num1, num2, resultado;
                Console.WriteLine("Dime un numero: ");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Dime otro numero: ");
                num2 = float.Parse(Console.ReadLine());
                if (num2 =!0)
                resultado = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {resultado}");
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine("Error: No se puede dividir entre 0.");
            }
            finally
            {
                Console.WriteLine("Este bloque siempre se ejecuta");
            }
        }
    }
}
