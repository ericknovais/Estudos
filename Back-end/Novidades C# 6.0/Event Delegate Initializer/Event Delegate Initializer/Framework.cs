using System;
using static System.Console;

namespace Event_Delegate_Initializer
{
    //public delegate void PagarEvent(double valor);
    public class Pedido
    {
        //Boleto boleto = new Boleto();
        // public event PagarEvent Pagar;
        public string Cliente { get; set; }
        public EventHandler<EventArgs> Pagar { get; set; }

        public void Fechar(double valor)
        {
            //delegação com delegate / event
            Pagar(this, new EventArgs());
        }
    }

    //public class Boleto
    //{
    //    private void Pagar(double valor)
    //    {
    //        WriteLine($"Pago valor de {valor} no boleto");
    //    }
    //}
}
