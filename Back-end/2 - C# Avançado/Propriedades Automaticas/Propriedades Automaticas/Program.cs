using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades_Automaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Codigo = 555;
            funcionario.Nome = "Erick Novais";
            funcionario.Salario = 2200;
        }
    }
}
