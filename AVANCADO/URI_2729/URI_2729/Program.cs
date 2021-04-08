using System;
using System.Linq;

namespace URI_2729
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] itens = {};
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalDeCasosDeTeste; i++)
            {
                itens = Console.ReadLine().Split(' ');
                itens = itens.Distinct().ToArray();
                Array.Sort(itens);
                Console.WriteLine("{0}", string.Join(" ", itens));
            }
        }
    }
}
