using System;
using System.Reflection.Metadata;

public class Punto9
{
    public static void Taller9()
    {
        int numero = 29;
        bool esPrimo = true;
        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
            {
                esPrimo = false;
                break;
            }
        }
        Console.WriteLine($"El número {numero} {(esPrimo ? "es" : "no es")} primo.");
    }
}