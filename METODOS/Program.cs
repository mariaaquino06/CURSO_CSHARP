namespace METODOS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Saudacao("Maria Eduarda");
            Soma(50, 63);
         
        }
        static void Saudacao(string nome)
        {
            Console.WriteLine($"Olá {nome}, Seja bem-vindo(a)!");

        }
        static void Soma(int a, int b)
        {
         int resultado = a + b;
            Console.WriteLine($"A soma de {a} + {b} é igual a {resultado}");
        }
    }
}
