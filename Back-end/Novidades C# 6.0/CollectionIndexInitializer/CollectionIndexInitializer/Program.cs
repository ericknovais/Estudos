using System;
using System.Collections.Generic;
using static System.Console;

namespace CollectionIndexInitializer
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Alunos = new Dictionary<int, Aluno>()
            {
                [1] = new Aluno() { Nome = "Erick", Sobrenome = "Novais" },
                [2]= new Aluno() { Nome = "Giovanna", Sobrenome = "Memoli" }
            };

            WriteLine("Informe a chave");
            int index = Convert.ToInt32(ReadLine());
            WriteLine($"Aluno: {Alunos[index].Nome} {Alunos[index].Sobrenome}");
            ReadLine();
        }
    }
}
