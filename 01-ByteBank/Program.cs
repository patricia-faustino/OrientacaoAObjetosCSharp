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
            ContaCorrente conta = new ContaCorrente();
            conta.Saldo = (-10);
            Cliente cliente = new Cliente();
            cliente.nome = "Patricia";
            cliente.profissao = "Desenvolvedora";
            cliente.cpf = "434.545.654-20";

            conta.Titular = cliente;

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.nome);


            Console.ReadLine();
        }
    }
}
