using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_Metodos_Override
{
    public abstract class Arquivo
    {
        public string Nome;
        public int Tamanho;
        public virtual void Abrir()
        {
            Console.WriteLine($"Abrindo arquivo: {Nome}");
        }
    }

    public class Musica : Arquivo
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine($"Tocando a música: {Nome}");
        }
    }

    public class DocumentoWord : Arquivo
    {
        public override void Abrir()
        {
            Console.WriteLine($"Exibindo arquivo Word: {Nome}");
        }
    }

    public class Imagem : Arquivo
    {

        public override void Abrir()
        {
            Console.WriteLine($"Exibindo imagem: {Nome}");
        }
    }

    public class Txt : Arquivo
    {
        public override void Abrir()
        {
            Console.WriteLine($"Exibindo arquivo texto: {Nome}");
        }
    }

    public class Windows
    {
        public List<Arquivo> _arquivos;

        public Windows()
        {
            this._arquivos = new List<Arquivo>();
        }

        public void Add(Arquivo arquivo)
        {
            this._arquivos.Add(arquivo);
        }

        public void Abrir(Arquivo arquivo)
        {
            //Delegação
            //if (arquivo is Musica)
            //    (arquivo as Musica).Abrir();
            //if (arquivo is DocumentoWord)
            //    (arquivo as DocumentoWord).Abrir();
            //if (arquivo is Imagem)
            //    (arquivo as Imagem).Abrir();
            //if (arquivo is Txt)
            //    (arquivo as Txt).Abrir();

            arquivo.Abrir();
        }

        public void AbrirTodos()
        {
            foreach (Arquivo arquivo in _arquivos)
                Abrir(arquivo);
        }
    }
}
