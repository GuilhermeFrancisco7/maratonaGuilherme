using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade10
{
    internal class Program
    {
        static void Main(string[] args)
        { //Ex: 10 Calculaora Simples ( + - * / )
          // Atividade 1

            Console.WriteLine("Calculadora das Quatros Operações Básicas! ");

            Console.WriteLine("Selecione o tipo de Operação desejada, (Soma = 1 ), (Subtração = 2 ) , (Multipicação = 3) e (Divisão = 4)! ");
            int operacao = int.Parse(Console.ReadLine());

            double nume1, nume2;

            Console.WriteLine("Digite o Prímeiro Número :");
            nume1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Número :");
            nume2 = double.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    Console.WriteLine("OPERAÇÃO ESCOLHIDA FOI SOMA.");
                    Console.WriteLine($"Resultado da Soma de {nume1} + {nume2} = {nume1 + nume2}");
                    break;

                case 2:
                    Console.WriteLine("OPERAÇÃO ESCOLHIDA FOI SUBTRAÇÃO.");
                    Console.WriteLine($"Resultado da Subtração de {nume1} - {nume2} = {nume1 - nume2}");
                    break;

                case 3:
                    Console.WriteLine("OPERAÇÃO ESCOLHIDA FOI MULTIPLICAÇÃO.");
                    Console.WriteLine($"Resultado da Multiplicação de {nume1} * {nume2} = {nume1 * nume2}");
                    break;

                case 4:
                    Console.WriteLine("OPERAÇÃO ESCOLHIDA FOI Divisão.");
                    Console.WriteLine($"Resultado da Divisãa de {nume1} / {nume2} = {nume1 / nume2}");
                    break;


            }
        }
    }
}
