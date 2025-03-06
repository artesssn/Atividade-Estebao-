using System;

class Program
{
    static void Main()
    {

        int N = int.Parse(Console.ReadLine());


        if (N <= 1 || N >= 1000)
        {
            Console.WriteLine("Tem que estar entre 1 a 1000");
            return;
        }


        for (int i = 1; i <= N; i++)
        {
            // Calculate square and cube
            int square = i * i;
            int cube = i * i * i;

            Console.WriteLine($"{i} {square} {cube}");
        }
    }
}