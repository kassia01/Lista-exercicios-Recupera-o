using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteracaofor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i);

                if (i == 7)
                {
                    Console.WriteLine("Encontrado o sete !");
                    break;
                }

                for (int valor = 0; valor < 15; valor++)
                {
                    Console.WriteLine(valor);
                }
            }
            Console.ReadLine();
        }
    }
}
