using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int meses, dias;

            Console.Write("Digite quantidade de meses para calcularmos os dias"
                + " representados por eles: ");
            meses = int.Parse(Console.ReadLine());

            dias = meses * 30;

            Console.Write("A quantidade de dias em " + meses + " meses sera de : " + dias + " dias");
            Console.ReadLine();
        }
    }
}
