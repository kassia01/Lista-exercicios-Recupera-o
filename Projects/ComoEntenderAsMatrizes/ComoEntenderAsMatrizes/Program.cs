using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComoEntenderAsMatrizes
{
    class Program
    {
        static void Main(string[] args)
        { /*
            int numero1 = 4;
            int numero2 = 8;
            int numero3 = 15;
            int numero4 = 16;
            int numero5 = 23;

            if (numero1 == 16)
            {
                Console.WriteLine();
            }
            else if (numero2 == 16)
            {
                Console.WriteLine();
            }
            else if (numero3 == 16)
            {
                Console.WriteLine();
            } */
            /*
            int[] numero = new int[5];

             numero[0] = 4;
             numero[1] = 8;
             numero[2] = 15;
             numero[3] = 16;
             numero[4] = 23;

            //Console.WriteLine(numero[1]); apresenta o numero que se refere a variavel 1
           // Console.WriteLine(numero.Length); apresenta o tamanho da matriz neste caso apresentaria o numero 5
            Console.ReadLine();
            */

            // int[] numero = new int[] {4 , 8 ,15,16,23,42}; neste caso copilador criaria quantidade de matriz

            string[] nomes = new string[] { "Eddie", "Alex", "Michael", "David" };
            /*
                        for (int i = 0; i < nomes.Length; i++)
                        {
                            Console.WriteLine(nomes[i]);
                        }
                        Console.ReadLine();
                        */
            /*    foreach (string nome in nomes)
                {
                    Console.WriteLine(nome);
                }
                Console.ReadLine();

        */

            string frase = "Voce pode conseguir o que quiser na vida , se ajudar as outras pessoas conseguir o que elas querem.";
            {
                Console.WriteLine(frase);
                    }
            char[] charArray = frase.ToCharArray();
            Array.Reverse(charArray);

            foreach (char fraseChar in charArray) 
            {
                Console.Write(fraseChar);
            }
            Console.ReadLine();
        }
    }
}
