using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedido = new Pedido();
            pedido.Pagar += (v => Console.WriteLine($"Pago boleto no valor de {v}")); //Lambda 
            pedido.Fechar(valor: 2000);
            Console.ReadLine();
        }
    }
}
