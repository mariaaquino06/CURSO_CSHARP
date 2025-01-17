namespace EX007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final;
            string resultado;

            Console.WriteLine("Digite a nota final do aluno");
            nota_final = Convert.ToDouble(Console.ReadLine());

            if (nota_final >= 60)
            {
                if (nota_final >= 90)
                {
                    resultado = "aprovado com mérito, parabéns!!";
                }
                else
                {
                    resultado = "aprovado!!";
                }
            }
            else if (nota_final >= 40)
            {
                resultado = "de recuperação.";
            }
            else
            {
                if (nota_final >=40)
                {
                    resultado = "Recuperação";
                }
                else
                {
                    resultado = "Reprovado";
                }

            }

            Console.WriteLine("Nota do Aluno: {0} - Resultado: {1}", nota_final, resultado);
        }
    }   
       
}
