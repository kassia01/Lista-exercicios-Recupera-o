using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            double emp, juros,taxa, qtdParc , porc;
            Console.Write(" Digite o valor do emprestimo: ");
            emp = double.Parse(Console.ReadLine());

            Console.Write(" Digite o valor da taxa: ");
            taxa = double.Parse(Console.ReadLine());
            porc = taxa / 100;
            
            Console.Write(" Digite quantidade de parcelas: ");
            qtdParc = double.Parse(Console.ReadLine());

            juros = emp * porc * qtdParc;

            Console.Write("O juros a pagar será de: "+ juros);
            Console.ReadLine();

        }
    }
}
