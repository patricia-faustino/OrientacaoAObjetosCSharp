
namespace _01_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        //static: propriedade pertecente a classe
        public static int TotalDeContasCriadas { get; private set; }

        private int _agencia;
        public int Agencia { 
            get
            {
                return _agencia;
            }
            set
            { 
                if(value <= 0)
                {
                    return;
                }
                _agencia = value;
            } 
        }
        public int Numero { get; set; }

        private double _saldo = 100;

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
        }
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value >= 0)
                {
                    _saldo = value;
                }
                return;

            }

        }

   

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

    }

}
