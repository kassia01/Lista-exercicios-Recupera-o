using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;

            Console.Write("Digite um número: ");
            n = double.Parse(Console.ReadLine());

            if (n >=0)
            {
                Console.Write("O número digitado é POSITIVO");
                Console.ReadLine();
            }
            else
            {
                Console.Write("O número digitado é NEGATIVO");
                Console.ReadLine();

            }
        }
    }
}
