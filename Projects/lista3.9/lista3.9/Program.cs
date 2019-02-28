using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, taxa, porc, slAtual,reaj;

            Console.Write("Digite seu salrio atual: ");
            slAtual = double.Parse(Console.ReadLine());
            Console.Write("Digite a porcentagem de reajuste: ");
            taxa = double.Parse(Console.ReadLine());
            porc = taxa / 100;
            reaj = slAtual * porc;
            salario = slAtual + reaj;
            Console.Write("Seu salario apos o reajuste será de: " + salario);
            Console.ReadLine();
        }
    }
}
