using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {

            /* int x;
             int y;

             x = 7;
             y = x + 3;

             Console.WriteLine(y);
             Console.ReadLine();
           */

            Console.WriteLine(" Qual é o seu nome?");
            Console.Write(" Digite seu nome: ");
            string nome;
            nome = Console.ReadLine();

            string sobrenome;
            Console.WriteLine(" Qual seu sobrenome ? ");
            sobrenome = Console.ReadLine();
            Console.WriteLine(" Ola," + nome + " " + sobrenome);
            Console.ReadLine();
          


        }
    }
}
