namespace EX_DATAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meses = {"Janeiro","Fevereiro","Março","Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro" };
            int[] dias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; 
            for (int i = 0; i < meses.Length; i++)
            {
                Console.WriteLine("O mês de " + meses[i] + "tem" + dias[i] + "dias.");

            }
            string[] semana = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };


            
        }
    }
}
