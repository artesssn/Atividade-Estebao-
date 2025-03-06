using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o numero de quantidade  de teste: ");
        if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
        {
            Console.WriteLine("Entrada  ta invalida.Quero numero inteiro e positivo.");
            return;
        }

        int coelhos = 0, ratos = 0, sapos = 0, total = 0;

        for (int i = 0; i < N; i++)
        {
            Console.Write("Digite a quantidade que tuquer e nao esqueça de selecionar a cobaia (C, R, S): ");
            string[] entrada = Console.ReadLine().Split();

            if (entrada.Length != 2 || !int.TryParse(entrada[0], out int quantidade) || !char.TryParse(entrada[1], out char tipo))
            {
                Console.WriteLine("Entrada invalida. Digite a quantidade e o tipo de cobaia corretamente.");
                i--;
                continue;
            }

            switch (char.ToUpper(tipo))
            {
                case 'C':
                    coelhos += quantidade;
                    break;
                case 'R':
                    ratos += quantidade;
                    break;
                case 'S':
                    sapos += quantidade;
                    break;
                default:
                    Console.WriteLine("Tipo invalido. Use 'C' para coelhos, 'R' para ratos e 'S' para sapos.");
                    i--;
                    continue;
            }

            total += quantidade;
        }

        if (total == 0)
        {
            Console.WriteLine("Nenhuma cobaia foi registrada.");
            return;
        }

        double percCoelhos = (coelhos / (double)total) * 100;
        double percRatos = (ratos / (double)total) * 100;
        double percSapos = (sapos / (double)total) * 100;

        Console.WriteLine($"Total: {total} cobaias");
        Console.WriteLine($"Total de coelhos: {coelhos}");
        Console.WriteLine($"Total de ratos: {ratos}");
        Console.WriteLine($"Total de sapos: {sapos}");
        Console.WriteLine($"Percentual de coelhos: {percCoelhos:F2} %");
        Console.WriteLine($"Percentual de ratos: {percRatos:F2} %");
        Console.WriteLine($"Percentual de sapos: {percSapos:F2} %");
    }
}