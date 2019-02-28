using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisoes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Grande oferta de Bob");
           Console.Write("Escolha uma porta: 1, 2 ou 3: ");
           string valorUsuario = Console.ReadLine();

           string mensagem;
           if (valorUsuario == "1") 

            mensagem = "Voce ganhou um carro novo!!!!";


           else if (valorUsuario == "2") 
            mensagem = " Você ganhou um barco novo !!!!!";


           else if (valorUsuario == "3") 
            mensagem = "Voce ganhou um gato novo!!!!";


            else
           {  mensagem = " Desculpa opção invalida :( !";
               //   mensagem = mensagem + "Voce perdeu !!!"; ou pode usar
               mensagem += " Voce perdeu!!!"; 


           }
           Console.WriteLine(mensagem);
           Console.ReadLine();

   if, else íf , else so precisa abrir { } se o codigo obter mais que uma linha
           declarar variavel fora 
           */

            Console.WriteLine("Grande oferta de Bob");
            Console.Write("Escolha uma porta: 1, 2 ou 3: ");
            string valorUsuario = Console.ReadLine();

            string mensagem = (valorUsuario == "1") ? "barco" : " fios de fiapos";

            //Console.Write(" Voce ganhou um ");
            //Console.Write(mensagem);
            //Console.Write(".");

            //Console.WriteLine(" Voce ganhou um {0}.", mensagem);
            // {0} significa pegue o 1 item apos a virgula 

            Console.WriteLine("Voce digitou o numero {0}, assim sendo voce ganhou um {1}.", valorUsuario, mensagem);

            Console.ReadLine();

        }
    }
}

  
 