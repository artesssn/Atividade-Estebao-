namespace _1132
{
    using System;

    class Program
    {
        static void Main()
        {
           
            string[] input = Console.ReadLine().Split();

           
            if (input.Length != 2)
            {
                Console.WriteLine("Por favor, insira  dois numeros inteiros.");
                return;
            }

            int X, Y;

            // Try to parse the integers
            if (!int.TryParse(input[0], out X) || !int.TryParse(input[1], out Y))
            {
                Console.WriteLine("Entrada esta inválida. Insira inteiros válidos.");
                return; 
            }

           
            int start = Math.Min(X, Y);
            int end = Math.Max(X, Y);
            int sum = 0;

           
            for (int i = start; i <= end; i++)
            {
                if (i % 13 != 0)
                {
                    sum += i;
                }
            }

      
            Console.WriteLine(sum);
        }
    }
}
