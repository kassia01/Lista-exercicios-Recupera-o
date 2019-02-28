using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            

            Console.Write("Digite um numero: ");

            num = double.Parse(Console.ReadLine());
       
            if (num% 2 == 0)  

            {
                Console.Write(" O numero que digitou é Par !");
                Console.ReadLine();
            }
            else
                Console.Write(" O numero que digitou é impar!");
                Console.ReadLine();

        }
    }
}
