namespace TESTE_MEDIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media, n1, n2;
            Console.WriteLine("Digite a primeira nota");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            n2 = Convert.ToDouble(Console.ReadLine());

            media = (n1 + n2) / 2;

            Console.WriteLine("A média é: {0}", media);

        }
    }
}
