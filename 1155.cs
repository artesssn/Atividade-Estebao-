using System;

class Program
{
    static void Main()
    {
     
        double S = 0.0;

      
        for (int i = 1; i <= 100; i++)
        {
            S += 1.0 / i;
        }

        Console.WriteLine($"{S:F2}");
    }
}