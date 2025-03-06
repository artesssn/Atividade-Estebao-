using System;
class Program
{
    static void Main()
    {
        double S = 0.0;
        for (int i = 1, j = 2; i <= 39; i += 2, j *= 2)
        {
            S += (double)i / j;
        }
        Console.WriteLine("{0:F2}", S);
    }
}
