namespace CALCULO_AREA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" =====================");
            Console.WriteLine(" Controle de Terrenos");
            Console.WriteLine(" =====================");
            Console.WriteLine(" ");

            Console.WriteLine("Digite a Largura do Terreno (m): ");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o comprimento do Terreno (m): ");
            double comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            AreaTerreno(largura, comprimento);
        }
        static void AreaTerreno(double L, double c)
        {
            double a = L * c;
            Console.WriteLine($" A área do terreno de {L}m * {c}m é de {a:F2}m².");

        }

    }
}
