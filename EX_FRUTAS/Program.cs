namespace EX_FRUTAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas ={"Tomate", "morango", "Limão", "Laranja", "Pessego", "Melancia", "Uva" };
            double[] valores = { 10, 12, 7, 14, 18, 11, 15 };

            for (int i = 0; i < frutas.Length; i++)
            {
             Console.WriteLine("{0} ---> R$ {1}", frutas[i], valores[i]);
             
            }
            Console.WriteLine("A fruta com maior preço é:");
            Console.WriteLine(valores.Max());
        }
    }
}
