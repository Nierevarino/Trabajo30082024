using System;

public class Switch1
{
    public static void TallerSwitch1()
    {
        Console.WriteLine("Digita un numero del 1 al 7 y te dire a que dia de la semana corresponde:");
        int i = int.Parse(Console.ReadLine());

        switch (i)
        {
            case 1:
            Console.WriteLine($"{i} Dia corresponde al Lunes");
            break;

            case 2:
            Console.WriteLine($"{i} Dia corresponde al Martes");
            break;

            case 3:
            Console.WriteLine($"{i} Dia corresponde al Miercoles");
            break;

            case 4:
            Console.WriteLine($"{i} Dia corresponde al Jueves");
            break;

            case 5:
            Console.WriteLine($"{i} Dia corresponde al Viernes");
            break;

            case 6:
            Console.WriteLine($"{i} Dia corresponde al Sabado");
            break;

            case 7:
            Console.WriteLine($"{i} Dia corresponde al Domingo");
            break;

            default:
            Console.WriteLine($"Digitacion no valida");
            break;
        }

    }
}