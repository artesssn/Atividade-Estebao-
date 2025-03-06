using System;

class Program
{
    static void Main()
    {
        
        int N = int.Parse(Console.ReadLine());

       
        int number = 1;

       
        for (int i = 0; i < N; i++)
        {
            
            Console.WriteLine($"{number} {number + 1} {number + 2} PUM");
            number += 4;
        }
    }
}
