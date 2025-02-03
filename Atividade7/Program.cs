using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7
{
    internal class Program
    {
        static void Main(string[] args)
        { // Ex : 7 Tabuada do 7
            // Atividade 1

            const int numero = 7; // constante do número 7
            int multipli = 0;    // multiplicador iniciado em 0, sempre que o loop repitir acresenta + 7
            int cont;           // contador do loop, serve para finalizar o loop após a 10º vez. 

            Console.WriteLine(" Tabuada do Número 7, indo do 1 ao 10");

            for (cont = 1; cont <= 10; cont++)
            {
                multipli = multipli + 7;
                Console.WriteLine($" O Número {numero} Vezes o {cont} é : {multipli}"); 
            }
        }
    }
}
