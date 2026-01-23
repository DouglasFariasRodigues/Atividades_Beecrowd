using System;

class URI
{
    static void Main(String[] args)
    {
        double a = double.Parse(Console.ReadLine()) * 2;
        double b = double.Parse(Console.ReadLine()) * 3;
        double c = double.Parse(Console.ReadLine()) * 5;

        double media = (a + b + c) / 10;

        Console.WriteLine($"MEDIA = {media :F1}");
    }
}