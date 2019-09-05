using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegacao
{
    public delegate void PagarEvent(double valor);

    public class Pedido
    {
        public event PagarEvent Pagar; //Ponteiro para um método 

        public void Fechar(double valor)
        {
            //delegação...
            this.Pagar(valor);
        }
    }
}
