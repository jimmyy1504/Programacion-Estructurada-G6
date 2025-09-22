namespace FuncionConsola
{
    internal class Program
    {
        static int Aumentar(int numero)
        {
            //numero++;
            return numero += 1;
        }

        public static int Aumentar(ref int numero)
        {
            return numero += 1;
        }

        static void Main(string[] args)
        {
            int num = 9;
            Console.WriteLine(num);
            Console.WriteLine(Aumentar(num));
            Console.WriteLine(num);
        }
    }
}
