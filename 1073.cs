﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Coloque um numero: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 2; i <= N; i += 2)
        {
            Console.WriteLine($"{i}^2 = {i * i}");
        }
    }
}
