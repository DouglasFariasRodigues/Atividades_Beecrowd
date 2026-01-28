using System;

class URI
{
    static void Main(String[] args)
    {
        int x = int.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        Console.WriteLine($"{x / y :F3} km/l");
    }
}