using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 999, b = 555, c = 0 ;
            c = a;
            a = b;
            b = c;
            Console.Write("O valor de A é: " + a + "  O valor de B é: " + b);
            Console.ReadLine();
        }
    }
}
