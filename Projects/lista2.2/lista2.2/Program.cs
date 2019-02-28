using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota, totalNota = 0, media;

            Console.WriteLine("Digite o nome do aluno: ");
            string nome;
            nome = Console.ReadLine();
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Insira a {0} º nota", i + 1);
                nota = float.Parse(Console.ReadLine());
                totalNota = totalNota + nota;

            }
            media = totalNota / 5;
            Console.WriteLine(" A media do aluno: "+ nome +" foi de : " + media);
            Console.ReadLine();
        }
    }
}
