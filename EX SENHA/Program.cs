namespace EX_SENHA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123"; // Senha correta 
            string senhaDigitada; // Senha digitada pelo usuário
            int tentativas = 0; // Contador de Tentativas
            
            // Loop para solicitar a senha do usuário
            do
            {
                Console.Clear();
                Console.WriteLine("Digite a Senha");
                
                senhaDigitada = Console.ReadLine();
                tentativas++; // Incrementa o contador de tentativas
                
                // verifica se a senha digitada é diferente da senha correta
                if (senhaDigitada != senha && tentativas < 3)
                {
                 Console.WriteLine("Senha Incorreta");
                 Console.WriteLine("Você ainda tem " + ( 3 - tentativas) +  " Tentativa(s)");
                 Console.ReadKey();
                } 
                else if (senhaDigitada != senha && tentativas == 3)
                {
                 return;
                }
                
            } while (senhaDigitada != senha);

            Console.Clear ();
            Console.WriteLine("Senha Correta - Tentativas:" + tentativas); 

        }
    }
}
