using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaDeMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            var caixaDialogo = new CaixaDialogo();
            caixaDialogo.Show(mensagem: "Confirmar?");
            caixaDialogo.Show(mensagem: "Excluir?", delay: 10.0);
            caixaDialogo.Show(mensagem: "Alterar?", delay: 10, ok: true, no: true);
            Console.ReadLine();
        }
    }
}
