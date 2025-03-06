using System;

class Program
{
    static void Main()
    {
 
        int N = int.Parse(Console.ReadLine());

    
        if (N <= 0 || N >= 13)
        {
            Console.WriteLine("O numero  tem que estar entre  1 a 12.");
            return;
        }

        int factorial = 1;

        for (int i = N; i > 0; i--)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }
}
