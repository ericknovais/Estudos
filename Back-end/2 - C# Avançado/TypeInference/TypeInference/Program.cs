using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeInference
{
    class Program
    {
        static void Main(string[] args)
        {
            InferenciaTipo();
        }

        private static void Dinamico()
        {
            // Palavar rezervada dynamic quando você não sabe, qual é o tipo do que sera 
            // retornado, mas a aplicação só ira saber qual o tipo em tempo de execução 
            // da aplicação
            dynamic con = Fabrica.CriarConnection();
            con.Teste = "Banco";
        }

        private static void InferenciaTipo()
        {
            // Palavra rezervada var para quando você não sabe, qual é o tipo do que sera
            // retornado, então o compilador da um jeito de saber qual é esse tipo e 
            // atribua o tipo a variavel isso em tempo de compilação
            var connection = new Connection() { ConnectionString = "BANCO" };
            connection.Conectar();
            connection.Fechar();
            Console.ReadKey();
        }
    }
}
