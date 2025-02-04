namespace VOTACAO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual ano você nasceu?"); 
            int nascimento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(voto(nascimento));
        }

        static string voto(int ano)
        {
            DateTime dataAtual = DateTime.Now;
            int anoAtual = dataAtual.Year;
            int idade = anoAtual - ano; 
            if (idade < 16)
            {
                return $"Com {idade} anos: Você não Vota.";
            }
            else if (idade >= 18 && idade < 70)
            {
                return $"Com idade {idade} anos: Você vota.";
            }
            else
            {
                return $"Com  idade {idade} anos: Seu voto é opcional.";
            }
        }
    }
}
