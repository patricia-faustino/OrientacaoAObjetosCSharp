﻿using System;
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
            Cliente gabriela = new Cliente();
            gabriela.nome = "Gabriela";
            gabriela.cpf = "434.562.878-20";
            gabriela.profissao = "Desenvolvedora C#";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = gabriela;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            conta.titular.nome = "Gabriela Costa";

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);


            Console.ReadLine();
        }
    }
}
