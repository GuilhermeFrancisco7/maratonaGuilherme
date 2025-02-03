using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade5
{
    internal class Program
    {
        static void Main(string[] args)
        {// Ex: 5 Sistema de Segurança
         // Atividade 1

            bool usuarioLogado = true;

            Console.WriteLine(" O USUÁRIO ESTÁ LOGADO (sim ou não)");
            string resposta = Console.ReadLine();
            usuarioLogado = resposta == "Sim";

            if (usuarioLogado)
            {
                Console.WriteLine("Usuário Logado");
            }
            else { Console.WriteLine(" Usuário Não Logado"); }
        }
    }
}
