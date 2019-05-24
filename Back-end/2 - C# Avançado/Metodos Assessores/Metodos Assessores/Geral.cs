using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Assessores
{
    public class Conta
    {
        private string _cliente;
        private double _valor;

        public Conta(string nomeCliente)
        {
            this._cliente = nomeCliente;
        }

        public Conta()
        {

        }

        public void Sacar(double valor)
        {
            this._valor -= valor;
        }

        public void Depositar(double valor)
        {
            this._valor += valor;
        }

        public double getValor()
        {
            return this._valor;
        }

        public string getCliente()
        {
            return this._cliente;
        }

        public void setCliente(string value)
        {
            this._cliente = value;
        }
    }
}
