using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Valor inteiro:");
        int X = int.Parse(Console.ReadLine());

        Console.WriteLine("Coloca outro inteiro:");
        int Y = int.Parse(Console.ReadLine());

        if (X > Y)
        {
            int temp = X;
            X = Y;
            Y = temp;
        }

        int soma = 0;

        for (int i = X + 1; i < Y; i++)
        {
            if (i % 2 != 0)
            {
                soma += i;
            }
        }

        Console.WriteLine($"A soma dos mpares de {X} e {Y} = {soma}");
    }
}
