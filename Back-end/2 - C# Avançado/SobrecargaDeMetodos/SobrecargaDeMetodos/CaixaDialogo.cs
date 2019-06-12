using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaDeMetodos
{
    public class CaixaDialogo
    {
        // default
        public void Show(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        public void Show(string mensagem, double delay)
        {
            Show(mensagem); // default
        }

        public void Show(string mensagem, int delay, bool ok, bool no)
        {
            Show(mensagem); // default
        }
    }
}
