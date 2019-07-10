using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    class Program
    {

        static string[,] baseDeLivros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            Inicio();   

            if (Menu() == 1)
            {
                Console.Clear();
                TextoLento("Menu - Alocação de livros");
                TextoLento("Digite o nome do livro a ser pesquisado");

                var nomedolivro = Console.ReadLine();

                if(PesquisaLivroParaAlocacao(nomedolivro))
                {
                    TextoLento("Você deseja alocar o livro? Para Sim(1) para Não(2)");
                    if(Console.ReadKey().KeyChar.ToString() == "1")
                    {
                        AlocarLivro(nomedolivro);
                    }
                    Console.Clear();
                    TextoLento("Livro Alocado!!!!!!");
                    TextoLento("Listagem de livros: ");

                    for (int i = 0; i < baseDeLivros.GetLength(0); i++)
                    {
                        TextoLento($"Nome: {baseDeLivros[i, 0]} Disponivel: {baseDeLivros[i, 1]}");
                    }
                }

                

            }

            Console.ReadKey();

        }
        /// <summary>
        /// Mostra a tela de Bem Vindo.
        /// </summary>
        public static void Inicio()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            

            WriteAt("Seja vem vindo ao sistema de alocação de livros", 30, 1);

            Console.ReadKey();

            Console.Clear();

        }
        /// <summary>
        /// Metodo que mostra o conteudo do Menu e as opcções de escolha.
        /// </summary>
        /// <returns>Retorna o valor do menu escolhido em um tipo inteiro.</returns>
        public static int Menu()
        {
            TextoLento("O que voce deseja realizar?");
            TextoLento("1 - Alocar um livro.");
            TextoLento("2 - Sair do sitema");
            TextoLento("Digite o numero desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(),out int opcao);

            Console.Clear();

            return opcao;

            
        }
        /// <summary>
        /// Metodo que carrega a base de dados
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeLivros = new string[2, 2]
            {
                {"O pequeno", "Sim" },
                {"O grande", "Não" }

            };

        }
        /// <summary>
        /// Metodo que retorna se um livro pode ser alocado
        /// </summary>
        /// <param name="nomeLivro"></param>Nome do livro a ser pesquisado
        /// <returns></returns>Retorna verdadeiro em caso o livro estiver livre pra alocação
        public static bool PesquisaLivroParaAlocacao(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                {
                    TextoLento($"O livro, {nomeLivro}" + $" pode ser alocado?: {baseDeLivros[i, 1]}");

                    return baseDeLivros[i, 1] == "Sim";
                }
            }
            return false;
        }
        /// <summary>
        /// Metodo que aloca o livro pesquisado.
        /// </summary>
        /// <param name="nomeLivro"></param>Nome do livro que vai ser alocado.
        public static void AlocarLivro(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if(nomeLivro == baseDeLivros[i,0])
                {
                    baseDeLivros[i, 1] = "Não";
                }

            }

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
