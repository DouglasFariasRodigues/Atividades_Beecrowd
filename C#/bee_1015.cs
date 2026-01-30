using System;
using System.Runtime.CompilerServices;

class URI
{
    static void Main(String[] args)
    {
        String[] x = Console.ReadLine().Split(' ');
        double x1 = double.Parse(x[0]);
        double y1 = double.Parse(x[1]);

        String [] y = Console.ReadLine().Split(' ');
        double x2 = double.Parse(y[0]);
        double y2 = double.Parse(y[1]);

        double dif_x = x2 - x1;
        double dif_y = y2 - y1;


       double distancia = Math.Sqrt(Math.Pow(dif_x,2) + Math.Pow(dif_y,2));

        Console.WriteLine($"{distancia:f4}");
    }
}