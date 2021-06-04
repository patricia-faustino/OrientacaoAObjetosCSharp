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
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;


            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();



            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;


            Console.WriteLine($"Igualdade referência: { contaDaGabriela == contaDaGabrielaCosta}");

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine($"Igualdade valor: {idade == idadeMaisUmaVez}");

            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine($"Igualdade referência: { contaDaGabriela == contaDaGabrielaCosta}");

            contaDaGabriela.saldo = 300;

            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);

            Console.ReadLine();
        }
    }
}
