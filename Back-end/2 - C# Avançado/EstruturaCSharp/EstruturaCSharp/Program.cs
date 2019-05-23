using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaCSharp
{
    public class PosicaoClass
    {
        public int x;
        public int y;
        public override string ToString()
        {
            return $"X - {x.ToString()} Y - {y.ToString()}";
        }
    }

    public struct PosicaoStruct
    {
        public int x;
        public int y;
        public override string ToString()
        {
            return $"X - {x.ToString()} Y - {y.ToString()}";
        }
    }

    public enum Role
    {
        Arquiteto,
        Developer,
        Tester
    }

    public enum Color
    {
        Vermelo = 0,
        Verde = 1,
        Azul = 2
    }

    public enum FormaDePagamento
    {
        Boleto,
        Cartao,
        Cheque
    }

    class Program
    {
        static void Main(string[] args)
        {
            PosicaoClass pos1 = new PosicaoClass();
            pos1.x = 10;
            pos1.y = 20;

            PosicaoStruct pos2 = new PosicaoStruct(); // ValeuType
            pos2.x = 30;
            pos2.y = 40;

            PosicaoStruct pos3 = pos2; //Copia
            pos3.y = 50;

            FormaDePagamento formaPagto = FormaDePagamento.Boleto;
            Role role = Role.Arquiteto;
            Color cor = Color.Azul;

            Console.WriteLine(pos1);
            Console.WriteLine(pos2.ToString());
            Console.WriteLine(pos3.ToString());
            Console.WriteLine(formaPagto);
            Console.WriteLine(role);
            Console.WriteLine(cor);

            Console.ReadLine();
        }
    }
}
