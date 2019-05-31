using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeInference
{
    public class Connection
    {
        public string ConnectionString { get; set; }
        public void Conectar()
        {
            Console.WriteLine("Conectando");
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando");
        }
    }

    public static class Fabrica
    {
        public static Connection CriarConnection()
        {
            return new Connection();
        }
    }
}
