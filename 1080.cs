using System;

class Program
{
    static void Main()
    {
        int maxValue = int.MinValue;
        int maxPosition = -1;

        Console.WriteLine("Escreva  100 numeros :/1" +
            "1:");

        for (int i = 1; i <= 100; i++)
        {
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                if (value > maxValue)
                {
                    maxValue = value;
                    maxPosition = i;
                }
            }
            else
            {
                Console.WriteLine("Entrada invalida. Digite um numero inteiro.");
                i--;
            }
        }

        Console.WriteLine($"Maior valor: {maxValue}");
        Console.WriteLine($"Posição: {maxPosition}");
    }
}