using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesIndexadas
{
    class Program
    {
        static void Main(string[] args)
        {
            var produtos = new Produto();
            produtos.Add("Iphone X Plus");
            produtos.Add("Moto E 7 Plus");
            produtos.Add("Sansung JS9");

            Console.WriteLine(produtos[0]);
            Console.WriteLine(produtos[1]);
            Console.WriteLine(produtos[2]);
            Console.WriteLine($"A posição do item iPad é {produtos["Iphone X Plus"]}");
            Console.ReadKey();
        }
    }
}
