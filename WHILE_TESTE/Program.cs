namespace WHILE_TESTE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String genero;

            Console.WriteLine("Digite o Gênero: ");
            genero = Console.ReadLine().ToUpper();

            while (genero != "F" && genero != "M")
            {

                Console.WriteLine("Digite o Gênero: ");
                genero = Console.ReadLine(); 

            }
            Console.WriteLine("Bem vindos e Bem vindas ao Curso de C#");


        }   


    }    
}
