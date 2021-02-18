using System;

class MainClass
{
    public static void Main(string[] args)
    {
        double salario, reajuste, novoSalario, percentual;
        salario = Convert.ToDouble(Console.ReadLine());

        if (salario <= 400.00)
        {
            reajuste = salario * 0.15;
            novoSalario = salario + reajuste;
            percentual = 15;

        }
        else if (salario <= 800.00)
        {
            reajuste = salario * 0.12;
            novoSalario = salario + reajuste;
            percentual = 12;

        }
        else if (salario <= 1200.00)
        {
            reajuste = salario * 0.10;
            novoSalario = salario + reajuste;
            percentual = 10;

        }
        else if (salario <= 2000.00)
        {
            reajuste = salario * 0.07;
            novoSalario = salario + reajuste;
            percentual = 7;

        }
        else
        {
            reajuste = salario * 0.04;
            novoSalario = salario + reajuste;
            percentual = 4;


        }

        Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
        Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
        Console.WriteLine("Em percentual: {0} %", percentual);
    }
}