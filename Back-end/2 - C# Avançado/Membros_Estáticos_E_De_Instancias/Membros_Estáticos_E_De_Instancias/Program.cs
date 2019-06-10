using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membros_Estáticos_E_De_Instancias
{
    class Program
    {
        static void Main(string[] args)
        {
            var conv1 = new ConversorInstancia();
            var conv2 = new ConversorInstancia();

            ConversorInstancia.temperatura = 30;
            var celsius = conv1.CelsiusToFah();
            //ConversorInstancia.temperatura = 70;
            var fan = conv2.FahToCelsius();

            Console.WriteLine($"celsius: {celsius}");
            Console.WriteLine($"fan: {fan}");
            Console.ReadLine();
        }

        private static void TesteStaticClass()
        {
            var temperatura = 35.0;
            temperatura = ConversorStatic.CelsiusToFah(temperatura);
            Console.WriteLine(temperatura);
        }
    }
}
