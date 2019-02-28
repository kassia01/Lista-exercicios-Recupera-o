using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;


            Console.Write("Digite um numero : ");
            n1 = int.Parse(Console.ReadLine());
         
            Console.Write("Digite mais um numero: ");
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;
            Console.WriteLine("O resultado da soma dos numeros digitados multiplicado"+
                "pelo primeiro numero é :  "+ soma*n1);

            Console.ReadLine();
       
             
        }
        
    }
}
