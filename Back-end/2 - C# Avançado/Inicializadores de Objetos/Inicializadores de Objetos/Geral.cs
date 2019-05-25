using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicializadores_de_Objetos
{
    public class Ator
    {
        public int Codigo;
        public string Nome;
        public List<Filme> Filmes;

        //public Ator(int codigo, string nome, string filme)
        //{
        //    this.Codigo = codigo;
        //    this.Nome = nome;
        //    this.Filme = filme;
        //}

        //public Ator(string nome)
        //{
        //    this.Nome = nome;
        //}

        //public Ator(int codigo)
        //{
        //    this.Codigo = codigo;
        //}

        //public Ator()
        //{

        //}
    }

    public class Filme
    {
        public string Nome;
        public int Ano;
    }
}
