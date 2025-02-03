using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade12
{
    internal class Program
    {
        static void Main(string[] args)
        {// Ex: 12 Sistema de desconto
            //Atividade 1

            Console.WriteLine("Digite o Valor da Compra: ");
            double ValorCompra = double.Parse(Console.ReadLine());
            double desconto;
            double valorTotal;

            if(ValorCompra >= 100) 
            {
                desconto = ValorCompra * 0.05;
                valorTotal = ValorCompra - desconto;

                Console.WriteLine($" Valor total:{valorTotal}  , desconto aplicado foi de : {desconto}");
            }
            else if(ValorCompra >100 && ValorCompra < 300)
            {
                desconto = ValorCompra * 0.10;
                valorTotal = ValorCompra - desconto;

                Console.WriteLine($" Valor total:{valorTotal}  , desconto aplicado foi de : {desconto}");
            }
            else 
            {
                desconto = ValorCompra * 0.15;
                valorTotal = ValorCompra - desconto;

                Console.WriteLine($" Valor total:{valorTotal}  , desconto aplicado foi de : {desconto}");
            }
        }
    }
}
