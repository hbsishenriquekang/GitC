using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregaInformacoesEListaElasEmTela();

            Console.ReadKey();
            
        }
        public static void CarregaInformacoesEListaElasEmTela(ref string[,] arrayBi)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                arrayBi[i, 0] = i.ToString();
                arrayBi[i, 1] = $"Felipe_{i}";

            }
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                Console.WriteLine($"ID:{arrayBi[i, 0]} - Nome: {arrayBi[i, 1]}");
            }
        }
    }
}
