using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade8
{
    internal class Program
    {
        static void Main(string[] args)
        {// Ex : 8 Sistema de Compra
         // Atividade 1: desconto de 10%

            Console.WriteLine("Compras acima de 200,00 R$, ganhe um desconto de 10%");

            Console.WriteLine("Digite o valor da compra: ");
            double valorCompra = double.Parse(Console.ReadLine());

            if(valorCompra >= 200)
            {
                Console.WriteLine("Sua Compra teve desconto de 10%");
                double desconto = valorCompra * 0.10;
                double valorFinal = valorCompra - desconto;

                Console.WriteLine(" Valor Final: " + valorFinal + ", Valor do desconto foi: " + desconto);

            }
            else { Console.WriteLine("Adicione mais itens ao carrinho para ganhar o desconto de 10%"); }
        }
    }
}
