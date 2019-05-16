using System;
using static System.Console;
using static System.Convert;

namespace Event_Delegate_Initializer
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Informe valor do pedido");
            var valor = ToDouble(ReadLine());
            var pedido = new Pedido()
            {
                Cliente = "Erick",
                Pagar = (s, e) => { WriteLine("Pago no Boleto"); }
            };
            pedido.Fechar(valor);
            ReadLine();
        }

        //private static void Pedido_Pagar(object sender, EventArgs e)
        //{
        //    WriteLine($"Pago no boleto");
        //}
    }
}
