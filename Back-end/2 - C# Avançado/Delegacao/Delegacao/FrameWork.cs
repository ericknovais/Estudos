using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegacao
{
    public class Boleto
    {
        public void Pagar(double valor)
        {
            Console.WriteLine($"Boleto pago no valor de {valor.ToString("c")}");
        }
    }

    public class Pedido
    {
        private Boleto _boleto = new Boleto();

        public void Fechar(double valor)
        {
            //delegação...
            this._boleto.Pagar(valor);
        }
    }
}
