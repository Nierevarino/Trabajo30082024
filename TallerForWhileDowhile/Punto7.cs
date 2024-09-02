using System;
using System.Runtime;

public class Punto7
{
    public static void Taller7()
    {
        Console.WriteLine("Digite un numero:");
        int nmr = int.Parse(Console.ReadLine());
        for (int i = 1; i <=nmr; i++)
        {
            Console.WriteLine($"Numero {i}");
        }
    }
}