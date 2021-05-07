using System; 

class URI {

    static void Main(string[] args) { 

        int anos = 0, mes = 0;
        int n = int.Parse(Console.ReadLine());

        while(n >= 365)
        {
            n -= 365;
            anos++;
        }

        while(n >= 30)
        {
            n -= 30;
            mes++;
        }

        Console.WriteLine("{0} ano(s)", anos);
        Console.WriteLine("{0} mes(es)", mes);
        Console.WriteLine("{0} dia(s)", n);

    }

}