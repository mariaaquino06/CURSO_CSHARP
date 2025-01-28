namespace EX030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NUMERO = 3; 

            while (NUMERO < 5)
            {
                NUMERO++;
                Console.WriteLine("Curso C#");

            }

            do
            {
                NUMERO++;
                Console.WriteLine("Curso C#");

            } while (NUMERO < 5);
        }
    }
}
