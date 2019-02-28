using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Nível profissional de Candidato");
            Console.ReadLine();
            float anoExp;
            Console.Write("Digite o tempo de experiencia do candidato a vaga: ");
            anoExp = float.Parse(Console.ReadLine());

            if (anoExp < 2)
            {
                Console.Write("O nivel do candidato é -> Junior");
                Console.ReadLine();
            }

            else if (anoExp >= 2 && anoExp <= 5)
            {
                Console.Write("O nivel do candidato é -> Pleno");
                Console.ReadLine();
            }
               
            else
	        {
                Console.Write("O nivel do candidato é -> Senior");
                Console.ReadLine();
            
            }
        }
    }
}
