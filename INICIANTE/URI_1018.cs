using System; 

class URI 
  
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            int cedula100 = 0, cedula50 = 0, cedula20 = 0, cedula10 = 0, cedula5 = 0, cedula2 = 0, cedula1 = 0;
            
            Console.WriteLine("{0}", valor);
            
            //primeira logica... 
            /*cedula100 = valor / 100;
            valor = valor % 100;
            cedula50 = valor / 50;
            valor = valor % 50;
            cedula20 = (valor / 20);
            valor = valor % 20;
            cedula10 = (valor / 10);
            valor = valor % 10;
            cedula5 = (valor / 5);
            valor = valor % 5;
            cedula2 = (valor / 2);
            valor = valor % 2;
            cedula1 = (valor / 1);*/
            
            /* segunda lógica...
            cedula100 = valor / 100;
            valor = valor - (cedula100 * 100);
            cedula50 = valor / 50;
            valor = valor - (cedula50 * 50);
            cedula20 = (valor / 20);
            valor = valor - (cedula20 * 20);
            cedula10 = (valor / 10);
            valor = valor - (cedula10 * 10);
            cedula5 = (valor / 5);
            valor = valor - (cedula5 * 5);
            cedula2 = (valor / 2);
            valor = valor - (cedula2 * 2);
            cedula1 = (valor / 1);
            */

            //terceira logica...
            //aqui pode se criar um contador como variavel... mas só para para exemplificar utilizei as
            //mesmas variáveis dos exemplos anteriores 
            while (valor >= 100)
            {
                valor = valor - 100;
                cedula100++;
            }

            while(valor >= 50)
            {
                valor = valor - 50;
                cedula50++;
            }

            while (valor >= 20)
            {
                valor = valor - 20;
                cedula20++;
            }

            while (valor >= 10)
            {
                valor = valor - 10;
                cedula10++;
            }

            while (valor >= 5)
            {
                valor = valor - 5;
                cedula5++;
            }

            while (valor >= 2)
            {
                valor = valor - 2;
                cedula2++;
            }

            while (valor >= 1)
            {
                valor = valor - 1;
                cedula1++;
            }

            Console.WriteLine("{0} notas de R$ 100,00", cedula100);
            Console.WriteLine("{0} notas de R$ 50,00", cedula50);
            Console.WriteLine("{0} notas de R$ 20,00", cedula20);
            Console.WriteLine("{0} notas de R$ 10,00", cedula10);
            Console.WriteLine("{0} notas de R$ 5,00", cedula5);
            Console.WriteLine("{0} notas de R$ 2,00", cedula2);
            Console.WriteLine("{0} notas de R$ 1,00", cedula1);

            Console.ReadKey();

        }
    }
