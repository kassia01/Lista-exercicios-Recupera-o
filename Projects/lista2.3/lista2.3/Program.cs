using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Calculo estoque Médio***");
            Console.ReadLine();
            float vlMaximo,vlMinimo,media;

            Console.Write("Digite a quantidade maxima: ");
            vlMaximo = float.Parse(Console.ReadLine());
       
            Console.Write("Digite a quantidade minima: ");
            vlMinimo = float.Parse(Console.ReadLine());
   
            media = (vlMaximo + vlMinimo) / 2;
            Console.Write("A media do seu estoque é de: " + media);
            Console.ReadLine();
                
        }
    }
}
