using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Genericas
{
    class Program
    {
        static void Main(string[] args)
        {
            var pinha1 = new Pinha<string>();
            pinha1.Push("Teste2");
            pinha1.Push("Teste");
            var pinha2 = new Pinha<int>();
            pinha2.Push(10);
            pinha2.Push(20);
            var pinha3 = new Pinha<Cliente>();
            pinha3.Push(new Cliente { Id = 1, Nome = "Erick Novais" });
            pinha3.Push(new Cliente { Id = 2, Nome = "Giovanna" });
            Cliente cliente = pinha3.Pop();

        }
    }
}
