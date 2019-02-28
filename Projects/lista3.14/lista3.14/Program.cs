using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =0 , cont = 0;
            Console.Write(" Digite um número: ");
            n = int.Parse(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                if (n % i == 0)
                {
                    cont++;
                }
            }
            if (cont==2)
            
            {
                Console.Write(" O numero " + n + "; é PRIMO");
                Console.ReadLine();
            }

            else
            {
                Console.Write("O numero " + n + "; não é Primo");
                Console.ReadLine();
            }
        }
    }
}
