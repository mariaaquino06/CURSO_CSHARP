using System.Data;

namespace CALCULO_TRIANGULO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Cálculo de área do Triângulo");
            Console.WriteLine("=============================");
            Console.WriteLine(" ");

            Console.WriteLine("Digite a Base do Triângulo");
            int b  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a Altura do Triângulo"); 
            int a = Convert.ToInt32(Console.ReadLine());

            AreaTerreno(b, a);
        }
        static void AreaTerreno (int b, int a)
        {
            int ba = b * a / 2;

            Console.WriteLine($"A área do Triângulo é igual a {b} * {a} / 2 = {ba}"); 

        }



    }
}
