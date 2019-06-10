using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membros_Estáticos_E_De_Instancias
{
    public static class ConversorStatic
    {
        public static double CelsiusToFah(double temperatura)
        {
            return (temperatura * 9 / 5) + 32;
        }

        public static double FahToCelsius(double temperatura)
        {
            return (temperatura * -32) + 9 / 5;
        }
    }

    public class ConversorInstancia
    {
        public static double temperatura;

        public double CelsiusToFah()
        {
            return (temperatura * 9 / 5) + 32;
        }

        public double FahToCelsius()
        {
            return (temperatura * -32) + 9 / 5;
        }
    }
}
