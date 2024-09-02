using System;

public class DoWhile2
{
    public static void TallerDoWhile2()
    {
        int i= 7;
        Console.WriteLine("Intenta adivinar el numero secreto, digita un numero:");
        int nmr = int.Parse(Console.ReadLine());

        do
        {
            if (nmr > i)
            {
                Console.WriteLine("El numero secreto es mas pequeño");
                Console.WriteLine("Intentalo otra vez:");
                nmr = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("El numero secreto es mas grande");
                Console.WriteLine("Intentalo otra vez:");
                nmr = int.Parse(Console.ReadLine());
            }
            
        }
        while (nmr != i)
        Console.WriteLine("Has acertado, muchas felicidades!!!");
    }
}