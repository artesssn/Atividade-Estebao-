﻿using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Digite o numero de quantidade para teste: ");
        if (int.TryParse(Console.ReadLine(), out int N))
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite tres numeros separados por espaco: ");
                string[] valores = Console.ReadLine().Split(' ');

                if (valores.Length == 3 &&
                    double.TryParse(valores[0], NumberStyles.Float, CultureInfo.InvariantCulture, out double num1) &&
                    double.TryParse(valores[1], NumberStyles.Float, CultureInfo.InvariantCulture, out double num2) &&
                    double.TryParse(valores[2], NumberStyles.Float, CultureInfo.InvariantCulture, out double num3))
                {
                    double mediaPonderada = (num1 * 2 + num2 * 3 + num3 * 5) / 10;
                    Console.WriteLine($"Média Ponderada: {mediaPonderada:F1}", CultureInfo.InvariantCulture);
                }
                else
                {
                    Console.WriteLine("Entrada invalida. Digite trrs numeros validos.");
                }
            }
        }
        else
        {
            Console.WriteLine("Entrada invalida. Digite um numero inteiro.");
        }
    }
}