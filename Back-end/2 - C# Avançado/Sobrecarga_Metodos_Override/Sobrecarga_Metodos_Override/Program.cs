using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_Metodos_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Musica mp3 = new Musica { Nome = "This is Amarica - Gambino" };
            DocumentoWord doc = new DocumentoWord() { Nome = ".net Magazine - Artigo POO" };
            Imagem img = new Imagem() { Nome = "Aguia" };
            Windows windows = new Windows();

            windows.Add(mp3);
            windows.Add(doc);
            windows.Add(img);

            windows.Abrir(mp3);
            windows.Abrir(doc);
            windows.Abrir(img);

            Console.ReadLine();
        }
    }
}
