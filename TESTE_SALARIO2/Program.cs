namespace TESTE_SALARIO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioAtual;
            double salarioAumento; 
            Console.WriteLine("Insira seu Salário Atual R$");
            salarioAtual = Convert.ToDouble(Console.ReadLine());

            if (salarioAtual > 2500)
            {
                salarioAumento = (0.05 * salarioAtual) + salarioAtual;
                Console.WriteLine("O Novo salario é igual a {0}.", salarioAumento);  

            }
            else if (salarioAtual > 1250)
            {
                salarioAumento = (0.10 * salarioAtual) + salarioAtual;
                Console.WriteLine("O novo salario é gual a {0}.", salarioAumento);
            }
            else
            {
                salarioAumento = (0.15 * salarioAtual) + salarioAtual;
                Console.WriteLine("O novo salario é igual a {0}.", salarioAumento);
            }
           
        }
    }
}
