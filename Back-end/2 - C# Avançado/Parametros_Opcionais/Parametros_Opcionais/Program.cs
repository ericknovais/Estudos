using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametros_Opcionais
{
    class Program
    {
        static void Main(string[] args)
        {
            var caixaDialogo = new CaixaDialogo();
            caixaDialogo.Show(mensagem: "Confirmar?", ok: true, no: true);


            var caixaDialogo2 = new CaixaDialogo();
            caixaDialogo2.Show(mensagem: "Excluir?", ok: true, no: true);
            Console.ReadLine();
        }
    }
}
