using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempC , tempF  ;
            Console.Write(" Qual a temperatura aqui: ");     
            tempC = double.Parse(Console.ReadLine());

            tempF = ((tempC * 1.8) + 32);
            Console.ReadLine();
      

            Console.Write(" Você sabia que esta temperatura em Fahrenheit é : " + tempF);
            Console.ReadLine();

        }
    }
}
