using System;

public class Punto10
{
    public static void Taller10()
    {
        int[] numeros = { 4, 7, 1, 3, 9 };
        int suma = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }
        Console.WriteLine(suma);

    }
}