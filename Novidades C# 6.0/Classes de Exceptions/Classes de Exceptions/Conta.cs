using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Classes_de_Exceptions
{
    public class Conta
    {
        private const double LIMITE = -500; 
        private double _saldo = 0;
        public void Deposito(double valor)
        {
            _saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor > _saldo + LIMITE)
                throw new SaldoInsuficienteExpecion("Saldo insuficiente");
           _saldo -= valor;
        }

        public double GetSaldo()
        {
            return _saldo;
        }
    }

    [Serializable]
    public class SaldoInsuficienteExpecion : Exception
    {
        public SaldoInsuficienteExpecion()
        {
        }

        public SaldoInsuficienteExpecion(string message) : base(message)
        {
        }

        public SaldoInsuficienteExpecion(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SaldoInsuficienteExpecion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
