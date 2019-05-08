using static System.Console;
using System;

namespace Expression_Bodies_Lambda_
{
    public delegate void PagarEvent(double valor);

    public class Pedido
    {
        public event PagarEvent Pagar;
        public void Fechar(double valor)
        {
            Pagar(valor);
        }
    }

    public class Calculadora
    {
        public static string Nome => "Super Calc";
        public static int Somar(int x, int y) => x + y;
        public static int Multiplicacao(int x, int y) => x * y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            var soma = Calculadora.Somar(x, y);
            WriteLine($"Usando a calculadora {Calculadora.Nome}  a soma de {x}, {y} é: {soma} ");

            x = 3;
            y = 7;
            var mult = Calculadora.Multiplicacao(x, y);
            WriteLine($"Usando a calculadora {Calculadora.Nome}  a multiplicação de {x}, {y} é: {mult} ");
            ReadKey();
        }

        private static void Lambda()
        {
            var pedido = new Pedido();
            pedido.Pagar += v => WriteLine($"Pago valor de {v}");
            pedido.Fechar(2000);
        }

        //private static void Pedido_Pagar(double valor)
        //{
        //    WriteLine($"Pago valor de {valor}");
        //}
    }
}
