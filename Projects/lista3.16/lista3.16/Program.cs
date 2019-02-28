using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3._16
{
    class Program
    {
        static void Main(string[] args)

        {
            int n, escolha = 0, cont = 0;
                
                Random segredo = new Random();
                n = Convert.ToInt32(segredo.Next(1, 10));
                n = 5;
                
                Console.WriteLine("**** Jogo da Adivinhação ****");
                Console.WriteLine("Adivinhe o número que eu pensei\n" +
                " o número está entre 1 e 10): ");
               
                try
                {
                
                    while (cont <= 3 && escolha != n)
                    {
                        escolha = Convert.ToInt32(Console.ReadLine());
                        
                        if (escolha > n)
                           
                            Console.WriteLine("Errado. O número é menor.");
                       
                        else if (escolha < n)
                           
                            Console.WriteLine("Errado. O número é maior.");
                        
                        else if (escolha == n && cont == 0)
                          
                            Console.WriteLine("Incrível! Você acertou na primeira!");
                        /* Se o usuário acertou depois de uma ou
                         mais tentativas...*/
                        else
                            // ... o programa informa isso.
                            Console.WriteLine("Acertou! " + n + " é o número!");
                       
                        cont++;
                    }
                    /* Comando utilizado para manter as informações na tela
                     após o acerto do número.*/
                    Console.ReadKey();
                }
                /* Se o que estiver contido no bloco de códigos
                 do try não conseguir processar o que o usuário digitou...*/
                catch
                {
                    // ... o programa informa isso.
                    Console.WriteLine("Sinto muito, você perdeu.\n" +
                        "Não deixe em branco e digite apenas números!!!");
                    /* Deixa as informações na tela até o usuário pressionar
                     alguma tecla.*/
                    Console.ReadKey();
                }
            }
        }
    }

