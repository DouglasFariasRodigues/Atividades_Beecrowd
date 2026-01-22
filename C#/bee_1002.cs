using System;

class URI
{
    static void Main(String[] args)
    {
        double raio = double.Parse(Console.ReadLine());

        double pi = 3.14159;

        double area = pi * (raio * raio);

        Console.WriteLine($"A={area:F4}");
    }
}