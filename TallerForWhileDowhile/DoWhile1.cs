using System;

public class DoWhile1
{
    public static void TallerDoWhile1()
    {
        int contador = 0;

        Console.WriteLine("Digite un numero (Digite 0 para terminar):");
        int i = int.Parse(Console.ReadLine());

        do
        {
            if (numero == 7)
            {
                contador++;
            }
            Console.WriteLine("Digite otro numero (Digite 0 para terminar):");
            i =int.Parse(Console.ReadLine());
        }
        while (i != 0)
    }
}