using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual seu nome? ");
            string nome;
            nome = Console.ReadLine();
            double valor1, valor2, valor3, media;

            Console.Write("Olá  " + nome + " digite o 1º valor: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.Write("Olá  " + nome + " digite o 2º valor: ");
            valor2 = double.Parse(Console.ReadLine());

            Console.Write("Olá  " + nome + " digite o 3º valor: ");
            valor3 = double.Parse(Console.ReadLine());

            media = (valor1 + valor2 + valor3) / 3;

            Console.Write(" A MEDIA DOS NUMEROS DIGITADOS É : " + media);
            Console.ReadLine();

        }
    }
}
