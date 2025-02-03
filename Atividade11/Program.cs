using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11
{
    internal class Program
    {
        static void Main(string[] args)
        {// Ex: 11  Sistema de Login
            // Atividade 1

            string user = "admin";
            string senha = "1234";

            string userResposta;
            string senhaResposta;
            bool loginSucesso = false;

            do
            {
                Console.WriteLine("Digite o seu Usuario: ");
                 userResposta = Console.ReadLine();

                Console.WriteLine("Digite sua senha: ");
                 senhaResposta = Console.ReadLine();

                if (user == userResposta && senha == senhaResposta)
                {
                    Console.WriteLine("Acesso Feito com sucesso");
                    loginSucesso = true;
                }

                else 
                {
                    Console.WriteLine("Usuário ou Senha incorretos!");
                }

            } while (!loginSucesso);
        }
    }
}
