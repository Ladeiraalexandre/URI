
using System;

class URI
{

    static void Main(string[] args)
    {

        int km = int.Parse(Console.ReadLine());
        double tempo = (60 * km) / 30;

        Console.WriteLine(tempo.ToString() + " minutos");

    }

}