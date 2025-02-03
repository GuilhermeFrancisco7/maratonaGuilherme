using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade9
{
    internal class Program
    {
        static void Main(string[] args)
        { // Ex: 9 cadastro de Produtos
          // Atividade 1

            Console.WriteLine("Digite o Nome do Produto, Valor e quantidade (Digite 0 para sair)");
            string nomeProduto;
            double precoProduto;
            int quantidade;
            string resposta = "";

            // entrada de informações

            do
            {
                Console.WriteLine("Digite o Nome do Produto: ");
                nomeProduto = Console.ReadLine();

                Console.WriteLine("Digite o Preço do Produto: ");
                precoProduto = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a Quantidade do Produto: ");
                quantidade = int.Parse(Console.ReadLine());

                if(quantidade == 0) { Console.WriteLine("Produto fora de estoque."); }

                Console.Clear();

                // Exibição das informações
                Console.WriteLine(" INFORMAÇÕES DO ESTOQUE!");
                Console.WriteLine();
                Console.WriteLine($"Nome do Produto: {nomeProduto}, Preço do Produto: {precoProduto}," +
                    $" Quantidade em estoque: {quantidade} ");

                // Controle do Loop
                Console.WriteLine("Gostaria de Continuar a Inserir informações? (S/N)");
                resposta =Console.ReadLine();
            }
            while (resposta.ToUpper() == "S");

           


        }
    }
}
