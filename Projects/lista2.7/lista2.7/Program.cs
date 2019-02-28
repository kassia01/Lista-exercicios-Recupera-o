using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota, totalNota = 0, faltas, media;

            Console.WriteLine("Digite o nome do aluno: ");
            string nome;
            nome = Console.ReadLine();


            for (int i = 0; i < 4; i++)
            {
                Console.Write("Insira a {0} º nota:  ", i + 1);
                nota = float.Parse(Console.ReadLine());
                totalNota = totalNota + nota;
            }
            
            media = totalNota / 4;

            Console.Write("Digite a quantidade de faltas do aluno " + nome + ": ");
            faltas = float.Parse(Console.ReadLine());

            if (media >= 5 && faltas < 10)
            {
                Console.WriteLine("A media do aluno: " + nome + " foi de:  " + media + "-> APROVADO");
            }
            else if (media < 5 && faltas < 10)
            {
                Console.WriteLine("A media do aluno: " + nome + " foi de:  " + media + "->RECUPERAÇÃO");
            }
            else if (faltas > 10)
                    {
                Console.WriteLine("Aluno: " + nome + "->REPROVADO POR FALTA!");
            }
        Console.ReadLine();
        }
    }
}
