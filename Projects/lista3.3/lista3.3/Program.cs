using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1, ant, suce;
            Console.Write("Digite um numero: ");
            v1 = double.Parse(Console.ReadLine());
            ant = v1 - 1;
            suce = v1 + 1;

            Console.WriteLine(" O antecessor de "+ v1+ " é , " + ant +" e o sucessor é , " + suce);
            Console.ReadLine();


        }
    }
}
