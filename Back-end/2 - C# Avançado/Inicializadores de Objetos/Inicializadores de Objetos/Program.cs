using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicializadores_de_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Ator ator = new Ator()
            {
                Codigo = 1,
                Nome = "Michael",
                Filmes = new List<Filme>()
                {
                        new Filme(){ Nome = "Prison Break" , Ano = 2005},
                        new Filme(){ Nome = "Programa", Ano= 2013 }
                }
            };
            Console.WriteLine($"ID: {ator.Codigo}, Nome: {ator.Nome}");
            Console.WriteLine("Filmes:");
            for (int i = 0; i < ator.Filmes.Count; i++)
            {
                Console.WriteLine($" {ator.Filmes[i].Nome} Ano:{ator.Filmes[i].Ano}");
            }
            Console.ReadKey();
        }
    }
}
