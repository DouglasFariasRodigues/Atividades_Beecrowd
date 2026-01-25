using System;

class URI
{
    static void Main(String[] args)
    {
        String nome = Console.ReadLine();
        double salario_fixo = double.Parse(Console.ReadLine());
        double valor_De_vendas = double.Parse(Console.ReadLine());

        double valor_para_receber = valor_De_vendas * 0.15; 

        Console.WriteLine($"TOTAL = R$ {salario_fixo + valor_para_receber:F2}");
    }
}