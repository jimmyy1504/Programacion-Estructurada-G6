namespace try1
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Exception ex;
                Console.Write("UAM");
                Console.WriteLine(" - Managua");
                int num;
                Console.WriteLine("Dime tu edad:");
                num = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
