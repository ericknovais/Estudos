using System;
using static Util.Calc;
using static System.Console;

namespace Using_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = Somar(3, 5); //Static
            WriteLine(r);
            ReadLine();
            new Util.Calc().Teste(); //Instaciado
        }
    }
}
