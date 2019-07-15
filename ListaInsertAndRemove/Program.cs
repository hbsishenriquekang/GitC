using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaInsertAndRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Carregando o sistema");

            string[,] baseDeDados = new string[2, 3];

            int IndiceBaseDeDados = 0;

            var escolhaInicial = MenuInicial();

            while(true)
            {
                switch (escolhaInicial)
                {
                    case "1": { InserirValoresNaLista(ref baseDeDados, ref IndiceBaseDeDados); } break;
                    case "2": { RemoverInformacoes(ref baseDeDados);  } break;
                    case "3": { MostrarInformacoes(baseDeDados); } break;
                    case "4": { return; }

                }

                escolhaInicial = MenuInicial();
            }
        }
        public static string MenuInicial()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Inserir novo registro");
            Console.WriteLine("2 - Remover registro");
            Console.WriteLine("3 - Lista informações");
            Console.WriteLine("4 - Sair do sistema");

            Console.WriteLine("Digite o número da opção desejada: ");
            return Console.ReadLine();

        }
        public static void InserirValoresNaLista(ref string[,] baseDeDados, ref int indiceBase)
        {
            Console.WriteLine("--------inserindo valores na lista--------");

            Console.WriteLine("Informe um nome");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe a idade");
            var idade = Console.ReadLine();

            AumentaTamanhoLista(ref baseDeDados);

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if(baseDeDados[i,0] != null)
                {
                    continue;

                }
                baseDeDados[i, 0] = (indiceBase++).ToString();
                baseDeDados[i, 0] = nome;
                baseDeDados[i, 2] = idade;

            }
            Console.WriteLine("Registro criado com sucesso, aperte qualquer tecla para voltar para o menu");
            Console.ReadKey();

        }
        public static void MostrarInformacoes(string[,] baseDeDados)
        {
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                Console.WriteLine(string.Format("Id:{0} Nome:{1} - Idade:{2}", baseDeDados[i,0], baseDeDados[i,1], baseDeDados[i,2]));
            }

            Console.WriteLine("Resultados apresentados com sucesso");
            Console.WriteLine("Para voltar ao menu inicial, digite qualquer tecla");
            Console.ReadKey();
        }
        public static void RemoverInformacoes(ref string[,] baseDeDados)
        {
            Console.WriteLine("Area de remoção de registro do sistema");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                Console.WriteLine(string.Format("Id:{0} - Nome:{1} - Idade:{2}", baseDeDados[i, 0], baseDeDados[i, 1], baseDeDados[i, 2]));

            }
            Console.WriteLine("Informe o id do registro a ser removido:");

            var id = Console.ReadLine();

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i,0] != null && baseDeDados[i,0] == id)
                {
                    baseDeDados[i, 0] = null;
                    baseDeDados[i, 1] = null;
                    baseDeDados[i, 2] = null;

                }

            }

        }
        public static void AumentaTamanhoLista(ref string[,] baseDeDados)
        {
            var limiteDaLista = true;

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] == null)
                {
                    limiteDaLista = false;

                }

            }
            if (limiteDaLista)
            {
                var listaCopia = baseDeDados;
                baseDeDados = new string[baseDeDados.GetLength(0) + 5, 2];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    baseDeDados[i, 0] = listaCopia[i, 0];
                    baseDeDados[i, 1] = listaCopia[i, 1];
                    baseDeDados[i, 2] = listaCopia[i, 2];
                }
                Console.WriteLine($"Tamanho da lista atualizado de {listaCopia.GetLength(0)} para {baseDeDados.GetLength(0)} ");
            }

        }
    }
    
}
