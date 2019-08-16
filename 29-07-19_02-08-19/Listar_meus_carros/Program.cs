using Listar_meus_carros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar_meus_carros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carros> minhaLista = new List<Carros>();

            while(true)
            {
                Console.Clear();
                Console.WriteLine("1- Adicionar carro");
                Console.WriteLine("2- Listar carros");
                int opcao = Int32.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        minhaLista.Add(new Carros()
                        {

                            Modelo = Valores("Modelo"),
                            Ano = Int32.Parse(Valores("Ano")),
                            Placa = Valores("Placa"),
                            Cv = Int32.Parse(Valores("Cv")),

                        });
                        Console.Clear();
                    }
                }
                if (opcao == 2)
                {
                    foreach (Carros item in minhaLista)
                    {
                        Console.WriteLine($"Modelos disponiveis: {item.Modelo} Ano: {item.Ano} Placa: {item.Placa} Cv: {item.Cv}");

                    }
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        public static string Valores(string nome)
        {
            Console.WriteLine($"Informe o valor no campo {nome}");
            return Console.ReadLine();

        }
        
    }
}
