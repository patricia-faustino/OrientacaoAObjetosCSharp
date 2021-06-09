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
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            ContaCorrente conta = new ContaCorrente(867, 867712540);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 867712520);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
