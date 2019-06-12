using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesIndexadas
{
    public class Produto
    {
        private List<string> _itens;
        public Produto()
        {
            this._itens = new List<string>();
        }

        public void Add(string item)
        {
            this._itens.Add(item);
        }

        public string Get(int index)
        {
            return this._itens[index];
        }

        //Propriedade indexada
        public string this[int index]
        {
            get
            {
                // return Get(index); // Mesma coisa para os 2 
                return this._itens[index]; 
            }
        }

        public int this[string nome]
        {
            get
            {
                return this._itens.IndexOf(nome);
            }
        }
    }
}
