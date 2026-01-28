using System;

class URI
{
    static void Main(String[] args)
    {
       String [] numeros = Console.ReadLine().Split(' ');

        int a = int.Parse(numeros[0]);
        int b = int.Parse(numeros[1]);
        int c = int.Parse(numeros[2]);

        int maiorab = (a + b + Math.Abs(a - b))/2; 
        int maior = (maiorab + c + Math.Abs( maiorab - c))/2;

        Console.WriteLine($"{maior} eh o maior");
    }
}