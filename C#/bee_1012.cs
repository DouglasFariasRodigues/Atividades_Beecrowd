using System;


class URI
{
    static void Main(String[] args)
    {
        String [] comprimentos = Console.ReadLine().Split(' ');
        double a = double.Parse(comprimentos[0]);
        double b = double.Parse(comprimentos[1]);
        double c = double.Parse(comprimentos[2]);

        double triangulo = (a *  c) / 2;
        double raio_do_circulo = 3.14159 * (c * c);
        double trapezio =(a + b) * c /2;
        double quadrado = b * b;
        double retangulo = a * b;

        Console.WriteLine($"TRIANGULO: {triangulo:F3}\nCIRCULO: {raio_do_circulo:F3}\nTRAPEZIO: {trapezio:F3}\nQUADRADO: {quadrado:F3}\nRETANGULO: {retangulo:F3}");

    }
}