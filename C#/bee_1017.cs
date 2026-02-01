using System;

class URI
{
    static void Main(String[] args)
    {
        int Tempo_gasto = int.Parse(Console.ReadLine());
        int velocidade_media = int.Parse(Console.ReadLine());

        double distancia_percorrida = Tempo_gasto * velocidade_media;
        
        Console.WriteLine($"{distancia_percorrida / 12 :F3}");
    }
}