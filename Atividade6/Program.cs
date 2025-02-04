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
        {//Ex: 6 Nomes dos Clientes
         // atividade 1

            
           
                string nome, sobreNome, nomeCompleto;
                string contador = "1";

                List<string> nomeClientes = new List<string>();
            do 
            { 

                Console.WriteLine("Dígite o Nome do Cliente");
                nome = Console.ReadLine();

                Console.WriteLine("Dígite o Sobrenome do Cliente");
                sobreNome = Console.ReadLine();

                nomeCompleto = nome + " " + sobreNome; // variável que recebe o nome completo.

                nomeClientes.Add(nomeCompleto);

                Console.WriteLine($" Nome Completo do Cliente: {nomeCompleto}");

                Console.WriteLine("Digite 0 para Sair!");
                contador = Console.ReadLine();
            } 
            while (contador != "0");

            Console.WriteLine(" Nome Completo do Cliente :  ");

            foreach (var nomeNaLista in nomeClientes)
            { 
                Console.WriteLine(nomeNaLista);
            }    

            
        }
    }
}
