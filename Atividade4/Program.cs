using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    internal class Program
    {
        static void Main(string[] args)
        {// Ex : 4 condicionais (if, else, else if, switch)
         // Atividade 1

            int idade;
            Console.WriteLine("Digite a sua ídade : ");
            idade= Convert.ToInt32(Console.ReadLine());

            if (idade < 12)
            {
                Console.WriteLine(" Criança");
            }
            else if (idade > 12 && idade < 18)
            {
                Console.WriteLine(" Adolescente");
            }
            else { Console.WriteLine(" Adulto"); }

            // Atividade 2 Switch

            Console.WriteLine(" Digite um número de 1 até 7 para saber qual o dia da Semana!");
            int numero = Convert.ToInt32(Console.ReadLine());

            switch (numero) 
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;

                case 2:
                    Console.WriteLine("Segunda-Feira");
                    break ;

                case 3:
                    Console.WriteLine("Terça-Feira");
                    break;

                case 4:
                    Console.WriteLine("Quarta-Feira");
                    break;

                case 5:
                    Console.WriteLine("Quinta-Feira");
                    break;

                case 6:
                    Console.WriteLine("Sexta-Feira");
                    break;

                case 7:
                    Console.WriteLine("Sábado");
                    break;

                default: 
                    Console.WriteLine("Opção Inválida!");
                    break;
            }

        }
    }
}
