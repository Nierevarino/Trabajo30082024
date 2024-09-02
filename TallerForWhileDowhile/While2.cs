using System;

public class While2
{
    public static void TallerWhile2()
    {
        Console.WriteLine("Ingrese un numero");
        int i =int.Parse(Console.ReadLine());
        int suma =0;

        while (i != 0)
        {
        suma=suma+i;
        Console.WriteLine("Ingrese otro numero");
        i =int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"La suma de tus numeros es: {suma}");

    }
}