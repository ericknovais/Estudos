using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_Metodos_Override
{
    public class Musica
    {
        public string Nome;
        public int Tamanho;
        public void Abrir()
        {
            Console.WriteLine($"Tocando música {Nome}");
        }
    }

    public class DocumentoWord
    {
        public string Nome;
        public int Tamanho;
        public void Abrir()
        {
            Console.WriteLine($"Mostrando documento do Word: {Nome}");
        }
    }

    public class Imagem
    {
        public string Nome;
        public int Tamanho;
        public void Abrir()
        {
            Console.WriteLine($"Exibindo imagem: {Nome}");
        }
    }

    public class Windows
    {
        public ArrayList _arquivos;

        public Windows()
        {
            this._arquivos = new ArrayList();
        }

        public void Add(Object arquivo)
        {
            this._arquivos.Add(arquivo);
        }

        public void Abrir(Object arquivo)
        {
            if (arquivo is Musica)
                (arquivo as Musica).Abrir();
            if (arquivo is DocumentoWord)
                (arquivo as DocumentoWord).Abrir();
            if (arquivo is Imagem)
                (arquivo as Imagem).Abrir();
        }
    }
}
