using System;
using static System.Console;
using static System.DateTime;

namespace String_Interpolation
{
    public class Pessoa
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var p = new Pessoa()
            {
                Matricula = 168,
                Nome = "Erick",
                Sobrenome = "Novais Da Hora"
            };

            //WriteLine("Bem-vindo " + p.Nome + " " + p.Sobrenome + "(" +
            //    p.Matricula + "), este é o C# 6");

            //WriteLine(string.Format("Bem-vindo {0} {1} ({2}), este é o C# 6",p.Nome,p.Sobrenome,
            //    p.Matricula));

            //String Interpolation 
            WriteLine($"Bem-vindo {p.Nome,10} {p.Sobrenome} " +
                      $"({p.Matricula}), este é o C# 6.0");

            WriteLine($"Olá, agora são {Now.ToString()}");

            ReadLine();
        }
    }
}
