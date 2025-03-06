   using System;

    class Program
    {
        static void Main()
        {
         
            string[] input = Console.ReadLine().Split();

         
            if (input.Length != 2)
            {
                Console.WriteLine("Insira dois nUmeros inteiros positivos.");
                return; 
            }

            int X, Y;

            // Try to parse the integers
            if (!int.TryParse(input[0], out X) || !int.TryParse(input[1], out Y) || X <= 0 || Y <= 0)
            {
                Console.WriteLine("Invalido.");
                return; 
            }

            // Determine the range
            int start = Math.Min(X, Y);
            int end = Math.Max(X, Y);

      
            var validNumbers = new List<int>();

        
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    validNumbers.Add(i);
                }
            }

            foreach (var number in validNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }