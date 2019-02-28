using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double custoFinal, custoDeFabrica= 10000, fabricacao;
            Console.Write("Digite o valor do carro :");
            custoFinal = double.Parse(Console.ReadLine());
            custoFinal = custoDeFabrica + (custoDeFabrica * 0.28) + (custoDeFabrica * 0.45);
            Console.ReadLine();

            Console.Write(custoFinal);
            Console.ReadLine();

        }
        // não entendi o que fazer!
    }
}
