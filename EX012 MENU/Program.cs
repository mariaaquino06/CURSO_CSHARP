namespace EX012_MENU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, opcao = 0;

            Console.Write("Digite o Primeiro numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            while (opcao != 5)
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - somar");
                Console.WriteLine("2 - subtrair");
                Console.WriteLine("3 - multiplicar");
                Console.WriteLine("4 - novos números");
                Console.WriteLine("5 - sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch(opcao)
                {
                    case 1: 
                        n3 = n1 + n2;
                        Console.WriteLine("A soma de {0} + {1} é igual a {2}.", n1, n2, n3);
                        break;

                    case 2: 
                        n3 = n1 - n2;
                        Console.WriteLine("A subtração de {0} - {1} é igual a {2}.", n1, n2, n3);
                        break;

                    case 3: n3 = n1 * n2;
                            Console.WriteLine("A Multiplicacao de {0} * {1} é igual a {2}.", n1, n2, n3);
                        break;

                    case 4: Console.WriteLine("Digite o primeiro numero:");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero");
                        n2 = Convert.ToInt32(Console.ReadLine()); 
                        break;

                    case 5: Console.WriteLine("Saindo");
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            }



        }
    }
}
