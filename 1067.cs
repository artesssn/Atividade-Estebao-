//1067
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escreva um valor inteiro entre 1 e 1000:");
        if (int.TryParse(Console.ReadLine(), out int X) && X >= 1 && X <= 1000)
        {
            Console.WriteLine($"Numeros impares de 1 ate {X}:");
            for (int i = 1; i <= X; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
        }
    }
}
