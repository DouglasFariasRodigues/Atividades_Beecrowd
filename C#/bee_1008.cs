using System;

class URI{
    static void Main(String[] args)
    {
        int numero = int.Parse(Console.ReadLine());
        int horas_trabalhadas = int.Parse(Console.ReadLine());
        double valor_por_horas = double.Parse(Console.ReadLine());


        Console.WriteLine($"NUMBER = {numero}\nSALARY = U$ {horas_trabalhadas * valor_por_horas :F2}");
    }
}