using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessores__e_Propriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            
            try
            {
                aluno.Matricula = 123;
                aluno.Nome = "Erick";
                aluno.Mensalidade = -454;
                aluno.Tipo = TipoAluno.Regular;
            }
            catch (MesalidadeNegativaException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
