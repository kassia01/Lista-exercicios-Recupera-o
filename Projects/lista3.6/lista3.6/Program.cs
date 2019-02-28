using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, total = 0, media;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite {0} º : ", i+1);
                valor = double.Parse(Console.ReadLine());
                total = total + valor ;
            }
            media = total / 5;
            Console.Write("A media dos valores digitados é : " + media);
            Console.ReadLine();
        }
    }
}
