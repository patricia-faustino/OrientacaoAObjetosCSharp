using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Cliente gabriela = new Cliente();
            gabriela.nome = "Gabriela";
            gabriela.cpf = "434.562.878-20";
            gabriela.profissao = "Desenvolvedora C#";*/

            ContaCorrente conta = new ContaCorrente();
            //conta.titular = new Cliente();
            //conta.titular.nome = "Gabriela Costa";
            //conta.titular.cpf = "434.562.878-20";
            //conta.titular.profissao = "Desenvolvedora C#";
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            if (conta.titular == null)
            {
                Console.WriteLine("Ops. A referência está apontando para NULL.");
            }


            Console.WriteLine(conta.titular);

            //Console.WriteLine(gabriela.nome);
           // Console.WriteLine(conta.titular.nome);
           //Console.WriteLine(conta.titular.cpf);
           // Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();
        }
    }
}
