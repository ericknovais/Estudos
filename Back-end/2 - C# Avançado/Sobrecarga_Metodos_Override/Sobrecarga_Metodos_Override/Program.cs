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
            Arquivo mp3 = new Musica { Nome = "This is Amarica - Gambino" };
            Arquivo doc = new DocumentoWord() { Nome = ".net Magazine - Artigo POO" };
            Arquivo img = new Imagem() { Nome = "Aguia" };
            Arquivo texto = new Txt() { Nome = "Lista de Compras" };
            Windows windows = new Windows();

            windows.Add(mp3);
            windows.Add(doc);
            windows.Add(img);
            windows.Add(texto);
            windows.AbrirTodos();

            //windows.Abrir(mp3);
            //windows.Abrir(doc);
            //windows.Abrir(img);

            Console.ReadLine();
        }
    }
}
