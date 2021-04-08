using System;

namespace Pink_Cerebro
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdNumeroLista = int.Parse(Console.ReadLine());
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;

            string[] n = Console.ReadLine().Split(' ');


            for (int i = 0; i < qtdNumeroLista; i++)
            {
                int numero = int.Parse(n[i]);

                num2 = (numero % 2 == 0) ? num2 += 1 : num2;
                num3 = (numero % 3 == 0) ? num3 += 1 : num3;
                num4 = (numero % 4 == 0) ? num4 += 1 : num4;
                num5 = (numero % 5 == 0) ? num5 += 1 : num5;
            }

            Console.WriteLine("{0} Multiplo(s) de 2", num2);
            Console.WriteLine("{0} Multiplo(s) de 3", num3);
            Console.WriteLine("{0} Multiplo(s) de 4", num4);
            Console.WriteLine("{0} Multiplo(s) de 5", num5);
        }
    }
}
