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
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);


            Console.WriteLine($"Saldo do Bruno: {contaDoBruno.saldo}");

            Console.WriteLine($"Saldo do Gabriela: {contaDaGabriela.saldo}");

            Console.WriteLine(resultadoTransferencia);

            contaDaGabriela.Transferir(100, contaDoBruno);

            Console.ReadLine();
        }
    }
}
