using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o numero de quantidade para teste:");
        int N = int.Parse(Console.ReadLine());
        int inCount = 0;
        int outCount = 0;

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Digite o nimero :");
            int X = int.Parse(Console.ReadLine());
            if (X >= 10 && X <= 20)
            {
                inCount++;
            }
            else
            {
                outCount++;
            }
        }

        Console.WriteLine($"{inCount} in");
        Console.WriteLine($"{outCount} out");
    }
}
