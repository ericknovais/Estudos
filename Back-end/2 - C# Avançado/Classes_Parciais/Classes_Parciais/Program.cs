using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Parciais
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Usuario(codigo: 1, nome: "Erick Novais", senha: "Colg@te01");

            if (user.Autenticar())
                Console.WriteLine("Usúario autenticado com sucesso");
            else
                Console.WriteLine("Credenciais inválidas");
            Console.ReadLine();

        }
    }
}
