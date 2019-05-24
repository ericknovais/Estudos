using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades_Automaticas
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {
            this.Codigo = 0;
            this.Nome = "Sem Nome";
            this.Salario = 0;
        }

        public Funcionario(int codigo, string nome, double salario)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Salario = salario;
        }
    }
}
