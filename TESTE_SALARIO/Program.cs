namespace TESTE_SALARIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario;
            Console.WriteLine("");
            Console.WriteLine("Insira o Valor do seu Salário");
            
            salario = Convert.ToDouble(Console.ReadLine());
         
            
            if (salario > 2500)
            {
                salario += (0.05 * salario);
                Console.WriteLine("O Aumento de salário é de R$");
            }
            else if (salario > 1250)
            {

               
            }
        }



    }
}
