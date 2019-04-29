using System;
using static System.Console;

namespace Auto_Property_Initializer
{
    class Program
    {
        static void Main(string[] args)
        {
            var gp = new Aluno(); // { Matricula = 123, Nome = "Erick Novais" };
            WriteLine($"{Aluno.Matricula} - {gp.Nome} - {gp.Status}");
            ReadLine();
        }
    }
}
