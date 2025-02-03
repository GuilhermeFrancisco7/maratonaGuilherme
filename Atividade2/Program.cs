using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {// Ex: 2 Calculos Matemáticos
            // atividade 1 

            Console.WriteLine("Escolha qual tipo de Operação quer fazer! ( digite 1 para soma, 2 para Subtração, 3 para Multiplicação e 4 Para Divisão)");
            string resposta = Console.ReadLine();

            Console.WriteLine(" Digite o Primeiro Número: ");
            double num1= double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o Segundo Número: ");
            double num2 = double.Parse(Console.ReadLine());

            if (resposta == "1")
            {
                Console.WriteLine("Operação escolhida: Soma");
                Console.WriteLine();
                Console.WriteLine($"Resultado da Operação: {num1} + {num2} é igual {num1 + num2}");
            }
            else if (resposta == "2")
            {
                Console.WriteLine("Operação escolhida: Subtração");
                Console.WriteLine();
                Console.WriteLine($"Resultado da Operação: {num1} - {num2} é igual {num1 - num2}");
            }
            else if(resposta == "3")
            {
                Console.WriteLine("Operação escolhida: Multiplicação");
                Console.WriteLine();
                Console.WriteLine($"Resultado da Operação: {num1} * {num2} é igual {num1 * num2}");
            }
            else
            {
                Console.WriteLine("Operação escolhida: Divisão");
                Console.WriteLine();
                Console.WriteLine($"Resultado da Operação: {num1} / {num2} é igual {num1 / num2}");
            }

            // Atividade 2 - calculo do PI

            const double pi = (double)Math.PI;
            double raio;
            double area;

            Console.WriteLine(" Digite um número para calacular a area: ");
            raio= double.Parse(Console.ReadLine());

            area = pi *(raio*raio);
            Console.WriteLine($"Área : {area} ");

        }
    }
}
