using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametros_Opcionais
{
    public class CaixaDialogo
    {
        public void Show(string mensagem, bool ok, bool no, bool cancel = false, int delay = 10)
        {
            Console.WriteLine(mensagem);
        }
    }
}
