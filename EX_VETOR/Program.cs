namespace EX_VETOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] num = new int[5];
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            num[3] = 40;
            num[4] = 50;
            num[5] = 60; // erro, passou dos limites do vetor, vetor só vai até 4 posições

            Console.WriteLine(num[1]);

            int[] n = new int[5] { 10, 20, 30, 50, 60};

            Console.WriteLine(n[0]);

            int[] numero = { 10, 20, 30, }; 
            
         
            Random random = new Random();

            int[] vetor = new int[10];
            for (int i = 0;i < 10;i++)
            {
             vetor[i] = random.Next(1,100);
             Console.WriteLine(vetor[i]);

            }

            Console.WriteLine();
            double[] reais = new double[10];
            for (int i = 0; i < 10; i++)
            {
                reais[i] = random.NextDouble() * 10000;
                Console.WriteLine(reais[i].ToString("P2"));

            } */

            string[] nomes = { "Maria", "Neymar", "Junior", "Rayane", "Cristyne", "Juan" };

            for (int i = 0; i < nomes.Length;i++) 
            {
                if (i<nomes.Length - 1)
                {
                 Console.Write(nomes[i]);

                }
                else
                {

                    Console.WriteLine(nomes[i] + ".");
                }

             
            }
        
        
        }





    }
}
