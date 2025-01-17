namespace EX003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            float num4, num5;

            Console.WriteLine("Digite um Número:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite Outro Número:");
            num2 = Convert.ToInt32(Console.ReadLine());

            num3 = num1 + num2;
            Console.WriteLine("A Soma de {0} + {1} = {2}",num1,num2,num3);

            num3 = num1 - num2;
            Console.WriteLine("A Subtração de {0} - {1} = {2}", num1,num2,num3);

            num3 = num1 * num2;
            Console.WriteLine("A Multiplicação de {0} * {1} = {2}", num1, num2, num3);

            num3 = num1 / num2;
            Console.WriteLine("A Divisão de {0} / {1} = {2}", num1, num2, num3);

            num3 = num1 % num2;
            Console.WriteLine("O resto da Divisão de {0} % {1} = {2}", num1, num2, num3);

            num4 = 35f;
            num5 = num1 / num4; 
            Console.WriteLine("A Divisão de {0} / {1} = {2}",num1, num4, num5);









        

        }
    }
}
