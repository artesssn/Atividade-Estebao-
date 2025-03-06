using System;

class Program
{
    static void Main()
    {
        for (int I = 1; I <= 9; I += 2)
        {
            int J = 7 + (I - 1) * 2;

            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine($"I={I} J={J}");
                J--;
            }
        }
    }
}
