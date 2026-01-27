using System;

class URI
{
    static void Main(String[] args)
    {
        double raio = double.Parse(Console.ReadLine());
        double pi = 3.14159;
        Console.WriteLine($"VOLUME = {(4/3.0) * pi * (raio * raio * raio):F3}");
    }
}