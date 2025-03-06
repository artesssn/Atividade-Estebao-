using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int X = int.Parse(input[0]);
        int Y = int.Parse(input[1]);w
        for (int i = 1; i <= Y; i++)
        {
            Console.Write(i);
            if (i % X == 0 || i == Y)
                Console.WriteLine();
            else
                Console.Write(" ");
        }
    }
}