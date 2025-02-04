namespace CONTADOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contador(1, 10, 1);
            Contador(10, 0, 2);

            Escrever("Agora é sua vez de personalizar a contagem!");
            Console.WriteLine("Digite o início: ");
            int ini = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o fim: ");
            int final = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o passo: ");
            int pass = Convert.ToInt32(Console.ReadLine());

            Contador(ini, final, pass);
        }

        static void Contador(int inicio, int fim, int passo)
        {
         Escrever($"Contagem de {inicio} até {fim} de {passo} em {passo}");
            Thread.Sleep(2000);

            if (passo < 0)
            {
                passo *= -1;
            }

         
            if (inicio < fim)
            {
              int cont = inicio;
                while (cont <= fim)
                {
                    Console.Write($"{cont} ");
                    Thread.Sleep(500);
                    cont += passo; 
                }
                Console.WriteLine("Fim!");
               
            }
            else
            {
                int cont = inicio;
                while (cont >= fim)
                {
                    Console.Write($"{cont} ");
                    Thread.Sleep(500);
                    cont -= passo;
                }
                Console.WriteLine("Fim!");
            }

        }
        static void Escrever(string texto)
        {
            int tam = texto.Length + 4;
            string linha = new('=', tam);
            string TextoCentralizado = texto.PadLeft(tam - 2).PadRight(tam - 2);
            Console.WriteLine(linha);
            Console.WriteLine(TextoCentralizado);
            Console.WriteLine(linha);
        }
    }
}
