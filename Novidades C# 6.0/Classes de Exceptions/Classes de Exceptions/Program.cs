using static System.Console;
using static System.Convert;

namespace Classes_de_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Informe valor a depositar:");
            var v1 = ToDouble(ReadLine());
            WriteLine("Informe valor a sacar:");
            var v2 = ToDouble(ReadLine());
            var c = new Conta();
            c.Deposito(v1);
            c.Sacar(v2);
            WriteLine($"Seu saldo é {c.GetSaldo()}");
            ReadLine();
        }
    }
}
