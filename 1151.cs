using System;

class Program
{
    static void Main()
    {

        int N = int.Parse(Console.ReadLine());

        if (N <= 0 || N >= 46)
        {
            Console.WriteLine("Tem que estar dentre 1 a 45 :/");
            return;
        }

      
        int[] fibonacci = new int[N];

     
        if (N >= 1) fibonacci[0] = 0; 
        if (N >= 2) fibonacci[1] = 1;

       
        for (int i = 2; i < N; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        Console.WriteLine(string.Join(" ", fibonacci));
    }
}
