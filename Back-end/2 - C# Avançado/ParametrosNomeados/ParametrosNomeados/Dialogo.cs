using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosNomeados
{
    public class DialogoBad
    {
        public void Show(string mensagem, bool mostrarBotaoOk,
                         bool mostrarBotaoNo, bool mostrarBotaoCancel, int delay)
        {
            Console.WriteLine(mensagem);
        }
    }

    public class Dialogo
    {
        public void Show(DialogoParams parametros)
        {
            Console.WriteLine(parametros.Mensagem);
        }
    }

    public class DialogoParams
    {
        public string Mensagem;
        public bool MostrarBotaoOk;
        public bool MostrarBotaoNo;
        public bool MostrarBotaoCancel;
        public int Delay;
    }
}
