using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lista = new string[10];

            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");

            }
            foreach(var item in lista)
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();
        }
    }
}
