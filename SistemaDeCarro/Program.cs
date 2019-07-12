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

            var opcaoMenu = Menu();
            while (opcaoMenu != 4)
            {

                if(opcaoMenu == 1)
                {
                    AtualizarCarro();

                }
                if(opcaoMenu == 2)
                {
                    DesalocarCarro();

                }
                if(opcaoMenu == 3)
                {
                    ListarCarros();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
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
            TextoLento("1 - Locar um carro");
            TextoLento("2 - Desalocar um carro");
            TextoLento("3 - Listar Carro");
            TextoLento("4 - Sair");
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
        public static void AtualizarCarro()
        {
            Operacao("Locar Carro");

            var nomedocarro = Console.ReadLine();
            var resultadoPesquisa = PesquisaCarro(ref nomedocarro);

            if(resultadoPesquisa != null && resultadoPesquisa == true)
            {
                TextoLento($"Você deseja locar o carro {nomedocarro}? Digite o numero desejado SIM(1) NÃO(2)");
                
                AtualizarCarro(nomedocarro, Console.ReadKey().KeyChar.ToString() == "1");
 
                Console.Clear();
                TextoLento("CARRO LOCADO!!!");
                TextoLento("Tabela de carros: ");
                ListarCarros();
                Console.ReadKey();
                
            }
        }
        public static void DesalocarCarro()
        {
            Operacao("Desalocar Carro");

            ListarCarros();

            var nomedocarro = Console.ReadLine();
            var resultadoPesquisa = PesquisaCarro(ref nomedocarro);

            if (resultadoPesquisa != null && resultadoPesquisa == false)
            {
                TextoLento($"Você deseja desalocar o carro {nomedocarro}? Digite o numero desejado SIM(1) NÃO(2)");

                AtualizarCarro(nomedocarro, Console.ReadKey().KeyChar.ToString() == "0");
 
                Console.Clear();
                TextoLento("CARRO DESALOCADO!!!");

                TextoLento("Tabela de carros: ");
                ListarCarros();
                Console.ReadKey();
            }
            if(resultadoPesquisa == null)
            {
                TextoLento("Nenhum carro encontrado");


            }

        }
        public static bool? PesquisaCarro(ref string nomeCarro)
        {
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if(CompararNomes(nomeCarro, baseDeDados[i,0]))
                {
                    TextoLento($"O carro, {nomeCarro}" + $" pode ser alocado?: {baseDeDados[i, 2]}");

                    return baseDeDados[i, 2] == "Sim";
                }  
            }

            TextoLento("Nenhum carro encontrado com esse nome");
            TextoLento("Deseja pesquisar novamente? Digite o numero: Sim(1) Não(2)");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            if(opcao == 1)
            {
                TextoLento("Digite o nome do carro a ser pesquisado");
                nomeCarro = Console.ReadLine();

                return PesquisaCarro(ref nomeCarro);


            }
            return false;
        }
        public static void AtualizarCarro (string nomeCarro, bool disponibilidade)
        {
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if(CompararNomes(nomeCarro, baseDeDados[i,0]))
                {
                    baseDeDados[i, 2] = disponibilidade? "Não" : "Sim";

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

        public static void Operacao(string operacao)
        {
            Console.Clear();
            TextoLento($"Menu - {operacao}");
            TextoLento("Digite o nome do carro para pesquisar: ");

        }
        public static void ListarCarros()
        {
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                TextoLento($"Carro: {baseDeDados[i, 0]} Ano: {baseDeDados[i, 1]} Disponível: {baseDeDados[i, 2]}");

            }

        }
        public static bool CompararNomes(string primeiro, string segundo)
        {
            if(primeiro.ToLower().Replace(" ","") == segundo.ToLower().Replace(" ", ""))
            {
                return true;

            }
            return false;
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
