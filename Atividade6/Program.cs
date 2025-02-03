using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6
{
    internal class Program
    {
        static void Main(string[] args)
        {// Ex : 6 nomes dos Clientes
            // atividade 1

            string nome, sobreNome, nomeCompleto;
            string contador = "1";
            List<string> nomeCliente = new List<string>(); // Lista que vai receber os Nomes Completos.

            do
            {
                Console.Clear();
                Console.WriteLine("Digite o Nome do Cliente :");
                nome = Console.ReadLine();

                Console.WriteLine("Digite o Sobrenome do Cliente :");
                sobreNome = Console.ReadLine();

                nomeCompleto = nome + " " + sobreNome;

                nomeCliente.Add(nomeCompleto);

                Console.WriteLine($"O nome completo do cliente é : {nomeCompleto}");

                Console.WriteLine("Digite 0 para sair");
                contador = Console.ReadLine();
            } while (contador != "0");

            Console.WriteLine("Os Nomes completos dos clientes são : ");

            foreach (var nomes in nomeCliente) // Loop para ler os nomes na lista e escrever na tela.
            {
                Console.WriteLine(nomes);
            }
        }
    }
}
