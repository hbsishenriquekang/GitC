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
            string[,] listaDeNome = new string[5,2];

            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                listaDeNome[i, 0] = i.ToString();
                listaDeNome[i, 1] = $"Felipe_{i}";

            }
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                Console.WriteLine($"ID:{listaDeNome[i,0]} - Nome: {listaDeNome [i,1]}");
            }
            
            Console.ReadKey();
        }
    }
}
