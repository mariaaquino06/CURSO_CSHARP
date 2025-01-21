namespace TESTE__TRIANGULO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            Console.WriteLine("Teste de Triângulos");
            Console.WriteLine("===================");

            Console.WriteLine("Digite o Valor do Lado A");
            ladoA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Valor do Lado B");
            ladoB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Valor do Lado C");
            ladoC = Convert.ToInt32(Console.ReadLine());

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))
            {
                Console.WriteLine("==========================================");               
                Console.WriteLine("Os valores informados formam um Triângulo");
                Console.WriteLine("==========================================");
            } 
            else 
            {
                Console.WriteLine("==============================================");
                Console.WriteLine("Os valores informados, NÃO formam um Triângulo");
                Console.WriteLine("==============================================");
            }
              
            


             
        }
    }
}
