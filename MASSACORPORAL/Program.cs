namespace MASSACORPORAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu Peso:");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua Altura");
            double altura = Convert.ToDouble(Console.ReadLine());

            
            double imc = peso / altura;
            Console.WriteLine($"O seu IMC é igual a: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do Peso.");


            }
            if (imc < 25) 
            {
                Console.WriteLine("Seu peso está normal"); 
            }

            if ( imc < 30)
            {
                Console.WriteLine("Você está com Sobrepeso");
            }

            if (imc < 40 )
            {
                Console.WriteLine("Você está com obesidade grau um");
            }
           

             
            

            
        }
    }
}
