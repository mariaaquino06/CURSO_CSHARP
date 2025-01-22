namespace TESTE_BANCO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorCasa, salario, prestacaoMensal;
            int anosEmprestimo, mesesEmprestimo;

            Console.WriteLine("Digite o Valor da casa:");
            valorCasa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite seu Salario:");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quantos anos de emprestimo:");
            anosEmprestimo = Convert.ToInt32(Console.ReadLine());

            mesesEmprestimo = anosEmprestimo * 12;

            prestacaoMensal = valorCasa / mesesEmprestimo; 

            if (prestacaoMensal < salario * 0.30)
            {
                Console.WriteLine("Emprestimo Aceito");
                Console.WriteLine("Parcelas: {0}", mesesEmprestimo);
                Console.WriteLine("Valor: {0} mensais", prestacaoMensal);

            }
            else
            {

                Console.WriteLine("Emprestimo Negado");
                Console.WriteLine("O valor das prestações ultrapassam 30% do seu salário.");

            }
        }
    }
}
