using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    internal class Program
    {
        static void Main(string[] args)
        {// EX: 3 laços: For, While, Do While e Foreach
            //Atividade 1

            //  usando For

            Console.WriteLine("Números Ímpares de 1 a 100 (FOR)");
            int numeros, impar = 0;

            for (numeros = 0; numeros < 100; numeros++)
            {
                if (numeros % 2 != 0) { impar = numeros; }
                Console.WriteLine($" Os números ímpares de 1 até 100 são : {impar}");
            }

            // usando While
            numeros = 1;  // verificando se o número é ímpar atraves da Soma de + 2 ao número atual.
            impar = 1;    // * OBS: a Varíavel "numeros" não pode iniciar em 0"

            Console.WriteLine("números ímpares de 1 até 100( While");
            while (numeros <= 100)
            {
                Console.WriteLine($" Os números ímpares de 1 até 100 são : {impar}");
                impar = numeros += 2;
            }

            // usando DO While

            numeros = 1;
            impar = 1;

            Console.WriteLine("números ímpares de 1 até 100( Do While");
            do
            {
                Console.WriteLine($" Os números ímpares de 1 até 100 são : {impar}");
                impar = numeros += 2;
            }while (numeros <= 100);

            //Atividade 2

            List<string> Cidade = new List<string>(5) // arry tipo list para armazenar os nomes das cidades
            { "São Paulo","Rioa de Janeiro","Santo André", "Alagoas", "São Carlos"};

            foreach(var cidades in Cidade)
            {  Console.WriteLine("O Nome das Cidades são : "+cidades); }
        }
    }
}
