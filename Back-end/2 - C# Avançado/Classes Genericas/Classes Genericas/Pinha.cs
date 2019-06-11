using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Genericas
{
    public class Pinha<T>
    {
        int pos = 0;
        T[] itens = new T[100];
        public void Push(T item)
        {
            itens[pos] = item;
            pos++;
        }

        public T Pop()
        {
            pos--;
            return itens[pos];
        }
    }

    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
