using static System.Console;

namespace Null_Conditional_Operator
{
    class Program
    {

        static void Main(string[] args)
        {
            var en = new Aluno()
            {
                Matricula = 123,
                Nome = "Erick Novais",
                Curso = new Curso()
                {
                    NomeCurso = "Analise e desenvolvimento de sistemas",
                    Area = new Area() { NomeArea = "Ciências Exatas" }
                },

            };
            WriteLine($"Matricula: {en.Matricula}\nNome: {en.Nome}");
            WriteLine($"Curso: {en?.Curso?.NomeCurso ?? " Sem Curso"}");
            WriteLine($"Area: {en?.Curso?.Area?.NomeArea ?? " Sem Area"}");
            //if (en.Curso !=null)
            //{
            //    WriteLine($"Curso:{en.Curso.NomeCurso}");
            //    if (en.Curso.Area != null)
            //        WriteLine($"Area:{en.Curso.Area.NomeArea}");
            //}
            //else
            //    WriteLine("Aluno não tem curso / area");
            ReadLine();
        }
    }

    public class Aluno
    {
        public int Matricula { get; set; } = 0;
        public string Nome { get; set; } = "Sem nome";
        public Curso Curso { get; set; }

    }

    public class Curso
    {
        public int Codigo { get; set; } = 0;
        public string NomeCurso { get; set; } = "Sem nome";
        public Area Area { get; set; }
    }

    public class Area
    {
        public string NomeArea { get; set; }
    }
}
