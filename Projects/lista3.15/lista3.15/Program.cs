using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Digite um numero e veremos quais os numeros pares existente entre eles: ");
            int x=0 ,y ;
            y = int.Parse(Console.ReadLine());

            while (x <=y)
            {            
            
                Console.WriteLine(x);

                x += 2;
            }
            Console.ReadLine();
        }
    }
}
