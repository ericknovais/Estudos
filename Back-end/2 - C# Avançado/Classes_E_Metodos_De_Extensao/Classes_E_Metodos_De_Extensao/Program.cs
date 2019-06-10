using System;
using System.Data;

namespace Classes_E_Metodos_De_Extensao
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "impacta.edu.br";
            Console.WriteLine(url.ToUrl());
            Console.ReadLine();
        }

        private static void ExemploDeEstensaoNoDataSet()
        {
            DataSet ds = new DataSet();
            ds.WriteJson("dados.js");
            ds.WriteXml("dados.xml");
        }
    }
}
