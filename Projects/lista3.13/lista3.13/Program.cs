using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            Console.Write("Digite um numero: ");
            n = double.Parse(Console.ReadLine());

            if (n > 10)
            {
                Console.Write(" O numero digitado é Maior que o numero 10!!!");
                Console.ReadLine();

            }
            else
            {
                Console.Write(" O numero digitado é Menor que o numero 10!!!");
                Console.ReadLine();
            }

        }
    }
}
