using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Convert;

namespace Lambda_Debugging
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public double Mensalidade { get; set; }
    }

    public static class Repositorio
    {
        public static List<Aluno> GetAlunos()
        {
            var lista = new List<Aluno>();
            lista.Add(new Aluno() { Matricula = 1, Nome = "Erick", Mensalidade = 454 });
            lista.Add(new Aluno() { Matricula = 2, Nome = "Caio", Mensalidade = 500 });
            lista.Add(new Aluno() { Matricula = 3, Nome = "Leonardo", Mensalidade = 500 });
            lista.Add(new Aluno() { Matricula = 4, Nome = "Paulo", Mensalidade = 50 });
            return lista;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var matricula = ToInt32(ReadLine());
            var alunos = Repositorio.GetAlunos();
            var query = alunos.Where(a => a.Matricula == matricula);
            var aluno = query.FirstOrDefault(); 
            WriteLine($"O aluno de Matricula {aluno.Matricula} se chama {aluno.Nome}");
            ReadLine();
        }
    }
}
