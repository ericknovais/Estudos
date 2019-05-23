using static System.Console;
using static System.Convert;

namespace Null_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Informe valor do pedido:");
            var valor =ToDouble(ReadLine());
            var pedido = new Pedido();
            pedido.Pagar += p => WriteLine($"Pago valor de {p} no boleto");
            pedido.Fechar(valor);
        }

        //private static void Pedido_Pagar(double valor)
        //{
        //    WriteLine($"Pago valor de {valor} no boleto");
        //}
    }
}
