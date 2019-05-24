using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores_e_Overloads
{
    public class Contato
    {
        public string Tipo;
        public string Descricao;
    }

    public class Cliente
    {
        public int Codigo;
        public string Nome;
        public Contato Contato;

        public Cliente()
        {
            this.Codigo = 0;
            this.Nome = "sem Nome";
            this.Contato = new Contato();
        }

        public Cliente(int codigo)
        {
            this.Codigo = codigo;
            this.Nome = "sem nome";
            this.Contato = new Contato();
        }

        public Cliente(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Contato = new Contato();
        }

        public override string ToString()
        {
            return $"Código:{Codigo}, Nome:{Nome}";
        }

    }

    public class ClienteVip : Cliente
    {
        public int Tempo;
        public ClienteVip(int codigo, string nome)
            : base(codigo, nome) // Chamando o construtor da class base
        {
            this.Tempo = 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.Codigo = 123;
            cliente1.Nome = "Erick Novais";
            cliente1.Contato.Tipo = "Telefone";
            cliente1.Contato.Descricao = "2738074";

            Cliente cliente2 = new Cliente(1658);
            cliente2.Nome = "Novais";
            cliente2.Contato.Tipo = "Telefone";
            cliente2.Contato.Descricao = "2738074";

            Cliente cliente3 = new Cliente(16, "Giovanna Memoli");

            ClienteVip cliente4 = new ClienteVip(577,"Luan Ferreira");

            Console.WriteLine(cliente1);
            Console.WriteLine(cliente2);
            Console.WriteLine(cliente3);
            Console.WriteLine(cliente4);
            Console.ReadLine();
        }
    }
}
