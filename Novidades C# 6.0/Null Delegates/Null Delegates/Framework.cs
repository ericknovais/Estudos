using System;
using static System.Console;

namespace Null_Delegates
{
    //public class Boleto
    //{
    //    public void Pagar(double valor)
    //    {
    //        WriteLine($"Pago valor de {valor} no boleto");
    //    }
    //}

    public delegate void PagarEvent(double valor);

    public class Pedido
    {
        //Boleto boleto = new Boleto();

        public event PagarEvent Pagar;
        public void Fechar(double valor)
        {
            //Delegação com delegate / event
            Pagar?.Invoke(valor);
        }
    }
}
