using System;

public class Switch2
{
    public static void TallerSwitch2()
    {
        Console.WriteLine("Digita un numero");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Digita otro numero");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("Tabla de opciones:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicacion");
        Console.WriteLine("4. Division");
        Console.WriteLine("Digita un numero segun el tipo de calculo que quieres ejecutar:");
        int i = int.Parse(Console.ReadLine());

        switch (i)
        {
            case 1:
            Console.WriteLine($"{x} + {y} = {x+y}");
            break;

            case 2:
            Console.WriteLine($"{x} - {y} = {x-y}");
            break;

            case 3:
            Console.WriteLine($"{x} X {y} = {x*y}");
            break;

            case 4:
            Console.WriteLine($"{x} / {y} = {x/y}");
            break;

            default:
            Console.WriteLine($"Digitacion no valida");
            break;
        }

    }
}