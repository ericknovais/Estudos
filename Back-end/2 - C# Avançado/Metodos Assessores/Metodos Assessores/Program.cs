using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Assessores
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.setCliente("Erick Novais");
            conta.Depositar(1000);
            conta.Sacar(200);
            Console.WriteLine($"Cliente:`{conta.getCliente()}");
            Console.WriteLine($"Saldo na data {DateTime.Now} é de {conta.getValor()}");
            Console.ReadLine();
        }
    }
}
