﻿using System;

class Program
{
    static void Main()
    {

        int N;

        Console.WriteLine("Quantos testes quer faze =");

        if (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
        {
            Console.WriteLine("Número inválido de pares.");
            return;
        }
        for (int i = 0; i < N; i++)
        {
            
            string[] input = Console.ReadLine().Split();
            if (input.Length != 2)
            {
                Console.WriteLine("Entrada inválida. Insira dois inteiros.");
                continue;
            }

            int X, Y;

            // Try to parse the integers
            if (!int.TryParse(input[0], out X) || !int.TryParse(input[1], out Y))
            {
                Console.WriteLine("Entrada inválida. Insira inteiros validos.");
                continue;
            }

            if (Y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double result = (double)X / Y;
                Console.WriteLine($"{result:F1}");
            }
        }
    }
}
