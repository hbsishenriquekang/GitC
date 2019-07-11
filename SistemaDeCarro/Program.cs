using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaDeCarro
{
    class Program
    {
        static string[,] baseDeDados;
        static void Main(string[] args)
        {
            CarregaDados();

            TelaInicial();


            if(Menu() == 1)
            {

                if(MenuLocacao() == 1)
                {
                    PesquisaPesquisa();

                }
            }
            Console.ReadKey();
        }
        public static void TelaInicial()
        {
            WriteAt("Seja bem vindo ao sistema de locação de carros", 25, 3);
            Thread.Sleep(300);
            WriteAt("Pressione qualquer tecla para continuar", 25, 8);

            Console.ReadKey();
            Console.Clear();

        }

        public static int Menu()
        {
            TextoLento("Menu Inicial");
            TextoLento("1 - Alocar um carro");
            TextoLento("2 - Opções");
            TextoLento("3 - Sair");
            TextoLento("Digite o número desejado para continuar: ");
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            Console.Clear();

            return opcao;

        }
        public static int MenuLocacao()
        {
            TextoLento("1 - Pesquisar");
            TextoLento("2 - Visualizar tabela inteira");
            TextoLento("Digite o número desejado para continuar: ");
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            Console.Clear();

            return opcao;

        }
        public static void PesquisaPesquisa ()
        {
            Console.Clear();
            TextoLento("Menu - Pesquisa de carros");
            TextoLento("Digite o nome do carro para pesquisar: ");

             var nomedocarro = Console.ReadLine();

            if(MenuParaLocacao(nomedocarro))
            {
                TextoLento($"Você deseja locar o carro {nomedocarro}? Digite o numero desejado SIM(1) NÃO(2)");
                if(Console.ReadKey().KeyChar.ToString() == "1")
                {
                    LocarCarro(nomedocarro);

                }
                Console.Clear();
                TextoLento("CARRO LOCADO!!!");
                Console.ForegroundColor = ConsoleColor.White;
                TextoLento("Tabela de carros: ");

                for (int i = 0; i < baseDeDados.GetLength(0); i++)
                {
                    TextoLento($"Carro: {baseDeDados[i, 0]} Ano: {baseDeDados[i, 1]} Disponível: {baseDeDados[i, 2]}");

                }

            }
                

        }
        public static bool MenuParaLocacao(string nomeCarro)
        {
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if(nomeCarro == baseDeDados[i,0] && "Sim" == baseDeDados[i,2])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    TextoLento($"O {nomeCarro} ESTÁ DISPONÍVEL");

                    return baseDeDados[i, 2] == "Sim";

                }
                else if (nomeCarro == baseDeDados[i, 0] && "Não" == baseDeDados[i, 2])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    TextoLento($"O {nomeCarro} NÃO ESTÁ DISPONÍVEL");
      
                }
                
            }
            return false;
        }
        public static void LocarCarro (string nomeCarro)
        {
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if(nomeCarro == baseDeDados[i,0])
                {
                    baseDeDados[i, 2] = "Não";

                }
            }

        }
        public static void CarregaDados()
        {
            baseDeDados = new string[2, 3]
            {
                {"Uno", "2010", "Sim" },
                {"Gol", "2015", "Não" }

            };
        }
        protected static int origRow;// Ponto horizontal ( X )

        protected static int origCol;// Ponto vertical ( Y )
        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {

                Console.WriteLine(e.Message);
            }
        }
        static void TextoLento(string vTexto)
        {

            for (int i = 0; i < vTexto.Length; i++)
            {
                Console.Write(vTexto[i]);
                Thread.Sleep(20);
            }

            Console.WriteLine();

        }
    }
}
