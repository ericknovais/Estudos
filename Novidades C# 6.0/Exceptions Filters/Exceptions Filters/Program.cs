using System;
using static System.Console;

namespace Exceptions_Filters
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 0;
            int r1 = 0;
            int r2 = 0;

            try
            {
                r1 = x / y;
                WriteLine($"{x} dividido por {y} é igual a {r1}");

                r2 = checked(x * y);
                WriteLine($"{x} dividido por {y} é igual a {r2}");
            }
            //catch (DivideByZeroException e)
            //{
            //    WriteLine($"Mensagem: {e.Message}");
            //}
            //catch (OverflowException e)
            //{
            //    WriteLine($"Mensagem: {e.Message}");
            //}
            //catch (ArithmeticException e)
            //{
            //    WriteLine($"Erro aritimético: {e.Message}");
            //}
            catch (Exception e) when (e.Message.ToUpper().Contains("ESTOURO"))
            {
                WriteLine($"Mensagem: {e.Message}");
            }
            catch (Exception e) when (e.Message.ToUpper().Contains("ZERO"))
            {
                WriteLine($"Mensagem: {e.Message}");
            }
        }
    }
}
