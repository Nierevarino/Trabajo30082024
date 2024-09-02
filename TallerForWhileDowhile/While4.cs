using System;

public class While4
{
    public static void TallerWhile4()
    {
        int i = int.MinValue;
        int numero;

        Console.WriteLine("Digite un numero (Digite 0 para terminar):");
        numero=int.Parse(Console.ReadLine());

        while (i != 0)
        {
            if (numero > i)
            {
                i = numero
            }
            Console.WriteLine("Digite otro numero (Digite 0 para terminar):");
            numero=int.Parse(Console.ReadLine());
        }
    }
}