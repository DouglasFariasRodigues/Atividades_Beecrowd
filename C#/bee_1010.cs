using System;
using System.Globalization;

class URI
{
    static void Main(String[] args)
    {
        String [] peca1 = Console.ReadLine().Split(' ');

        int numero_pecas1 = int.Parse(peca1[1]);
        double valor_unitario1 = double.Parse(peca1[2],CultureInfo.InvariantCulture);

        String [] peca2 = Console.ReadLine().Split(' ');

        int numero_pecas2 = int.Parse(peca2[1]);
        double valor_unitario2 = double.Parse(peca2[2],CultureInfo.InvariantCulture);

        Console.WriteLine($"VALOR A PAGAR: R$ {(numero_pecas1 * valor_unitario1) + (numero_pecas2 * valor_unitario2):F2}");





    }
}