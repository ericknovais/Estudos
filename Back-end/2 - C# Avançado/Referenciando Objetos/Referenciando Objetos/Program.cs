using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referenciando_Objetos
{
    public class Cliente // Reference type
    {
        public int Codigo;
        public string Nome;
        public string Telefone;
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo: {Codigo}");
            sb.AppendLine($"Nome: {Nome}");
            sb.AppendLine($"Telefone: {Telefone}");
            return sb.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Cliente cliente1 = new Cliente();
            cliente1.Codigo = 123;
            cliente1.Nome = "Novais";
            cliente1.Telefone = "27380748";

            Cliente cliente2; //Declaração, não esta sendo alocado.
            cliente2 = new Cliente(); // Agora sendo instanciado, novo espado em memoria 
            //cliente2 = cliente1; // Apontando para a mesma posição em memoria do cliente1
            cliente2.Nome = "Roberto";

            Console.WriteLine(cliente1);
            Console.WriteLine(cliente2);
            if (cliente1.Equals(cliente2))
                Console.WriteLine("cliente1 é o cliente2 são os mesmos objetos");
            else
                Console.WriteLine("cliente1 é o cliente2 são diferentes");
            //Console.WriteLine(cliente.Codigo);
            //Console.WriteLine(cliente.Nome);
            //Console.WriteLine(cliente.Telefone);
            Console.ReadLine();
        }

        private static void MostrarValueTypes()
        {
            int x = 10;
            string s = "Erick Novais";
            bool b = false;
            Console.WriteLine(x); // ValueType
            Console.WriteLine(s); // ValueType
            Console.WriteLine(b); // ValueType
        }
    }
}
