using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDeLivros = new string[3, 5];
            int IdLivro = 0;
            var opcao = MenuInicial();

            while (true)
            {
                switch (opcao)
                {
                    case "1": { NovoLivro(ref baseDeLivros, ref IdLivro); } break;
                    case "2": { RemoverLivro(ref baseDeLivros, ref IdLivro); } break;
                    case "3": { ListarLivros(ref baseDeLivros); } break;
                    case "4": { ListarLivros(ref baseDeLivros, "true"); } break;
                    case "5": { return; }
                }
                opcao = MenuInicial();

            }


        }
        public static string MenuInicial()
        {
            Console.Clear();

            Console.WriteLine("Menu");
            Console.WriteLine("1 - Inserir novo livro");
            Console.WriteLine("2 - Remover livro");
            Console.WriteLine("3 - Listar livros");
            Console.WriteLine("4 - Listar livros desativados");
            Console.WriteLine("5 - Sair do sistema");

            Console.WriteLine("Digite o número da opção desejada: ");
            return Console.ReadLine();

        }
        public static void NovoLivro(ref string [,] baseDeLivros, ref int IdLivro)
        {
            Console.Clear();

            Console.WriteLine("Para cadastrar um novo livro, digite o Titulo");
            var livro = Console.ReadLine();

            Console.WriteLine("Digite o nome do autor do livro");
            var autor = Console.ReadLine();

            AumentarLista(ref baseDeLivros);

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {

                if( baseDeLivros[i,0] != null)
                {
                    continue;
                }
                baseDeLivros[i, 0] = (IdLivro++).ToString();
                baseDeLivros[i, 1] = livro;
                baseDeLivros[i, 2] = autor;
                baseDeLivros[i, 3] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                baseDeLivros[i, 4] = "true";

                break;
            }
            Console.WriteLine("Livro cadastrado com sucesso");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal");

            Console.ReadKey();

        }
        public static void ListarLivros(ref string[,] baseDeLivros, string RegistroDesativado = "false")
        {

            Console.Clear();

            if (RegistroDesativado == "true")
            {
                Console.WriteLine("Registro desativado no sistema");

            }

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (baseDeLivros[i, 4] != RegistroDesativado)
                {
                    Console.WriteLine("Lista de livros cadastrados");
                    Console.WriteLine(string.Format("ID:{0} - Titulo:{1} - Autor:{2} - Data de modificação:{3}",
                    baseDeLivros[i, 0], baseDeLivros[i, 1], baseDeLivros[i, 2], baseDeLivros[i, 3]));

                }

            }

            Console.WriteLine("Lista apresentada com sucesso");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal");

            Console.ReadKey();

        }
        public static void RemoverLivro(ref string[,] baseDeLivros, ref int IdLivro)
        {

            Console.Clear();

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if(baseDeLivros[i,4] != "false")
                {
                    Console.WriteLine(string.Format("ID:{0} - Titulo:{1} - Autor:{2} - Data de modificação:{3}",
                    baseDeLivros[i, 0], baseDeLivros[i, 1], baseDeLivros[i, 2], baseDeLivros[i, 3]));

                }

            }

            Console.WriteLine("Para remover um livro digite o ID do mesmo:");
            var remover = Console.ReadLine();

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (baseDeLivros[i,0] == remover && baseDeLivros[i,0] != null)
                {
                    baseDeLivros[i, 3] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    baseDeLivros[i, 4] = "false";

                }
            }
        }
        public static void AumentarLista(ref string[,] baseDeLivros)
        {
            var LimiteLista = true;
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (baseDeLivros[i, 0] == null)
                {
                    LimiteLista = false;

                }


            }
            if(LimiteLista)
            {
                var ListaCopia = baseDeLivros;
                baseDeLivros = new string[baseDeLivros.GetLength(0) + 3, 5];

                for (int i = 0; i < ListaCopia.GetLength(0); i++)
                {
                    baseDeLivros[i, 0] = ListaCopia[i, 0];
                    baseDeLivros[i, 1] = ListaCopia[i, 1];
                    baseDeLivros[i, 2] = ListaCopia[i, 2];
                    baseDeLivros[i, 3] = ListaCopia[i, 3];
                    baseDeLivros[i, 4] = ListaCopia[i, 4];

                }
                Console.WriteLine($"O tamanho da lista foi atualizado de {ListaCopia.GetLength(0)+1} para {baseDeLivros.GetLength(0)+1}");

            }
        }
    }
}
