using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosNomeados
{
    class Program
    {
        static void Main(string[] args)
        {
            var dlg = new DialogoBad();
            dlg.Show(mensagem: "Confirmar Operação?", mostrarBotaoOk: true,
                     mostrarBotaoNo: true, mostrarBotaoCancel: false, delay: 10);

            var parametros = new DialogoParams()
            {
                Mensagem = "Confirmar Operação?",
                MostrarBotaoOk = true,
                MostrarBotaoNo = true,
                MostrarBotaoCancel = false,
                Delay = 10
            };

            var dlg2 = new Dialogo();
            dlg2.Show(parametros: parametros);
            Console.ReadLine();
        }
    }
}
