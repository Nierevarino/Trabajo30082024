using System;

public class Punto5
{
    public static void Taller5()
    {
        int[] numeros= { -1, -2, -3,};
        int contador = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] < 0)
            {
                contador++;
            }
        }
        Console.WriteLine(contador);

    }
}