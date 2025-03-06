using System;

class Program
{
    static void Main()
    {
       
        int N = int.Parse(Console.ReadLine());

      
        if (N <= 1 || N >= 1000)
        {
            Console.WriteLine("Po o numero tem que estar entre o numero 1 a 1000");
            return;
        }

       
        for (int i = 1; i <= N; i++)
        {
        
            for (int j = 1; j <= 2; j++)
            {

                int firstNumber = i;
                int square = firstNumber * firstNumber;

                int secondNumber = firstNumber + j;
                int cube = secondNumber * secondNumber * secondNumber;

                Console.WriteLine($"{firstNumber} {square} {cube}");
            }
        }
    }
}