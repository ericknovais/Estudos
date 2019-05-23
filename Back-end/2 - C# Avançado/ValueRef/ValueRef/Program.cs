using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueRef
{
    public class PosicaoClass // reference type 
    {
        public int x;
        public int y;
    }

    class Program
    {
        public static void Dobrar(ref int valor)
        {
            // Se o parâmetro não e passado como referencia
            // e criado uma copia do parâmetro (Criando um novo local de memoria)
            // passado deixando assim o valor passado 
            // sem nem uma modificação.
            // Agora se o parâmetro for passado como referencia, não e uma copia e sim 
            // o mesmo local de memoria sendo assim vai ser alterado aquele valor passado
            valor *= 2;
        }

        public static void Dobrar(PosicaoClass valor)
        {
            valor.x *= 2;
            valor.y *= 2;
        }

        static void Main(string[] args)
        {
            PosicaoClass pos1 = new PosicaoClass(); //Alocando memoria para um ponteiro
            pos1.x = 10;                           // Uma nova instancia. 
            pos1.y = 20;

            PosicaoClass pos2 = new PosicaoClass(); //Alocando memoria 
            pos2.x = 30;
            pos2.y = 40;
            Dobrar(pos1);
            Dobrar(pos2);
            Console.WriteLine(pos1.x); // Não precisa ser passado com ref pois uma 
            Console.WriteLine(pos1.y); // class já é uma referencia
            Console.WriteLine(pos2.x);
            Console.WriteLine(pos2.y);
            Console.ReadLine();
        }

        private static void DobrarValue()
        {
            int x = 10;
            Dobrar(ref x);
            Console.WriteLine(x);
        }

        private static void RefTypeInt()
        {
            PosicaoClass pos1 = new PosicaoClass(); //Alocando memoria para um ponteiro
            pos1.x = 10;                           // Uma nova instancia. 
            pos1.y = 20;

            PosicaoClass pos2 = new PosicaoClass(); //Alocando memoria 
            pos2.x = 30;
            pos2.y = 40;
            pos2 = pos1; // apontando ambos para a  mesma posiçao de memória.
            pos2.x = 50;
            Console.WriteLine(pos1.x);
            Console.WriteLine(pos1.y);
            Console.WriteLine(pos2.x);
            Console.WriteLine(pos2.y);
        }

        private static void ValueTypeInt()
        {
            int x = 10;
            int y = 20;
            y = x; //cópia
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
