using MinhaPrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lanche> minhaLista = new List<Lanche>();

            minhaLista.Add(new Lanche()
            {
                Nome = "Pão de queijo",
                Quantidade = 9,
                Valor = 1.85
            });

            minhaLista.Add(new Lanche()
            {
                Nome = "Bolinho de Soya",
                Quantidade = 2,
                Valor = 7.50
            });

            for (int i = 0; i < 1; i++)
            {
                minhaLista.Add(new Lanche()
                {

                    Nome = Console.ReadLine(),
                    Quantidade = Int32.Parse(Console.ReadLine()),
                    Valor = double.Parse(Console.ReadLine()),

                });
            }

            Console.WriteLine("Removendo Item");

            /*foreach(Lanche item in minhaLista)
            {
                if(item.Quantidade == 3)
                {
                    minhaLista.Remove(item);
                    break;

                }
            }*/

            foreach (Lanche item in minhaLista)
            {
                Console.WriteLine($"Lanches disponiveis: {item.Nome}");
            }

            Console.ReadKey();
        }
    }
}
