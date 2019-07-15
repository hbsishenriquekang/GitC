using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdicionarValoresEmUmaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeNome = new string[10, 2];
            int IdParaLista = 0;

            InserirRegistro(ref listaDeNome, ref IdParaLista);

            Console.ReadKey();

            InserirRegistro(ref listaDeNome, ref IdParaLista);

            Console.ReadKey();
        }
        public static void InserirRegistro(ref string [,] listaDeNome, ref int IdParaLista)
        {
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {

                if(listaDeNome[i,0] != null)
                {
                    continue;
                }

                Console.WriteLine("Informa um nome para adicionar um registo:");
                var nome = Console.ReadLine();

                listaDeNome[i, 0] = (IdParaLista++).ToString();
                listaDeNome[i, 1] = nome;

                Console.WriteLine("Deseja inserir um novo registro? Sim(1) Não(0)");
                var continuar = Console.ReadKey().KeyChar.ToString();
                if (continuar == "0")
                {
                    break;


                }
            }

            Console.WriteLine("Registro adicionado com sucesso, segue lista de informações adicionadas");

            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                Console.WriteLine(string.Format("Registo ID{0} - Nome:{1}", listaDeNome[i, 0], listaDeNome[i, 1]));

            }
        }
        public static void AumentaTamanhoLista(ref string[,] listaDeNome)
        {
            var limiteDaLista = true;

            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                if(listaDeNome[i,0] == null)
                {
                    limiteDaLista = false;

                }
                
            }
            if (limiteDaLista)
            {
                var listaCopia = listaDeNome;
                listaDeNome = new string[listaDeNome.GetLength(0) + 5, 2];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    listaDeNome[i, 0] = listaCopia[i, 0];
                    listaDeNome[i, 1] = listaCopia[i, 1];

                }
                Console.WriteLine($"Tamanho da lista atualizado de {listaCopia.GetLength(0)} para {listaDeNome.GetLength(0)} ");
            }

        }
    }
}
