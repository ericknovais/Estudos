using System;
using static System.Console;

namespace Nameof_Operator
{
    public class Professor
    {
        public string Matricula { get; set; } = "0";
        public string Nome { get; set; } = "Sem nome";
        public DateTime Data { get; set; } = DateTime.Now;
        public override string ToString()
        {
            return $"Matricula: {Matricula},Nome: {Nome}, Data: {Data}";
        }
    }

    public static class Relatorio
    {
        public static void Imprimir(Professor prof)
        {
            WriteLine("Relatorio:");
            WriteLine(prof?.ToString() ?? $"O parâmetro de nome " +
                                               $"{nameof(prof)} não pode ser nulo");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Professor EN = null;
            WriteLine(EN?.ToString() ?? $"Objeto {nameof(EN)} não instanciado");
            Relatorio.Imprimir(EN);

            EN = new Professor()
            {
                Matricula = "357",
                Nome = "Erick Novais"
            };

            WriteLine(EN.ToString());
            ReadLine();
        }
    }
}
