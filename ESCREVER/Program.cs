namespace ESCREVER
{
    internal class Program
    {
        static void Escrever(string texto)
        {
            int tam = texto.Length + 4;
            string linha = new('*', tam);
            string TextoCentralizado= texto.PadLeft(tam - 2).PadRight(tam-2);
            Console.WriteLine(linha);
            Console.WriteLine(TextoCentralizado);
            Console.WriteLine(linha);
        }
        
        
        
        static void Main(string[] args)
        {
            Escrever("Curso C#");
            Console.WriteLine();
            Escrever(" Maria Eduarda Oliveira Aquino");
            Console.WriteLine();
            Escrever("Olá");
            Console.WriteLine(); 
        }
    }
}
