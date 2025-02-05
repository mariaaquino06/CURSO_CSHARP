namespace FATORIAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool mostrar = false;
            
            Console.WriteLine("Digite um Número inteiro não negativo:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("vOCÊ QUER VER OS CALCULOS?  (s/n)");
            string resp = Console.ReadLine().ToLower();
            Console.WriteLine(); 

            if ( resp == "s") {mostrar = true;}

            Console.WriteLine(fatorial(num, mostrar ));
        }

        static int fatorial(int n, bool show = false)
        {
            int f = 1;
            for (int i = n; i > 0; i--)
            {
                if (show)
                {
                    Console.Write(i + " ");
                    if (i > 1)
                    {
                        Console.Write("x ");
                    }
                    else
                    {
                        Console.Write("= ");
                    }



                }

                f *= i;



            }
            return f;



        }
    }   
       
}
