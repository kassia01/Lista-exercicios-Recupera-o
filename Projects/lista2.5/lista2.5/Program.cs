using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Orçamento para festa Infantil**");
            Console.ReadLine();
            float qntConvidados;
            Console.Write("Digite aqui a quantidade de convidados: ");
            qntConvidados = float.Parse(Console.ReadLine());

            if (qntConvidados > 100)
            {
                Console.Write("Sua festa custará:R$ " + qntConvidados * 45);
                Console.ReadLine();

          
            }
            else
            {
                Console.Write("Sua festa custará:R$ " + qntConvidados * 35);
                Console.ReadLine();
            }
        } 
        
    }
}
