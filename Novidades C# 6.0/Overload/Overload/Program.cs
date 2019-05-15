using static System.Console;
using System;

namespace Overload
{
    public class Aluno
    {
        public int Matricula { get; set; } = 0;
        public string Nome { get; set; } = "Erick";
        public override string ToString()
        {
            return $"Matricula: {Matricula} --" +
                   $" Nome: {Nome}";
        }
    }

    public class AlunoEspecial : Aluno
    {
        public string Situacao { get; set; } = "Especial";
        public override string ToString()
        {
            return $"Matricula: {Matricula} --" +
                   $" Nome: {Nome} -- Situação: {Situacao}";
        }
    }

    class Program
    {
        static void Mostrar(string obj)
        {
            WriteLine($"Motrar(string): {obj}");
        }

        static void Mostrar(int obj)
        {
            WriteLine($"Motrar(int): {obj}");
        }

        static void Mostrar(bool obj)
        {
            WriteLine($"Motrar(bool): {obj}");
        }

        static void Mostrar(object obj)
        {
            WriteLine($"Motrar(object): {obj}");
        }

        static void Mostrar(Aluno obj)
        {
            WriteLine($"Motrar(Aluno): {obj}");
        }

        static void Mostrar(AlunoEspecial obj)
        {
            WriteLine($"Motrar(AlunoEspecial): {obj}");
        }

        static void Main(string[] args)
        {
            Mostrar("Olá Mundo");
            Mostrar(10);
            Mostrar(true);
            Mostrar(new Aluno());
            Mostrar(new AlunoEspecial() { Matricula = 123, Nome = "Erick Novais" });
            ReadLine();
        }
    }
}
