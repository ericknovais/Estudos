using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_E_Metodos_De_Extensao
{
   public static class MyExtensions
    {
        public static void WriteJson(this DataSet ds,string fileName)
        {
            //_ds
        }

        public static string ToUrl(this string str)
        {
            return str = $"https//{str}";
        }
    }
}
