using static System.Console;

namespace Get_Read_Only
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Conta() { Cliente = "Erick Novais" };
            c.Depositar(500);
            WriteLine($"Prezado {c.Cliente}, seu saldo é {c.Saldo}");
            ReadLine();
        }

    }
}
