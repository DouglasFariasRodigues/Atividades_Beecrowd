using System;

class URI
{
    static void Main(String[] args)
    {
        double num = double.Parse(Console.ReadLine()) * 3.5;
        double num1 = double.Parse(Console.ReadLine()) * 7.5;

        double media = (num + num1) / 11;

        Console.WriteLine($"MEDIA = {media:F5}");

    }
}