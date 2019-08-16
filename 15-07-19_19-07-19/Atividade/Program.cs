using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeNome = new string[3, 2];
            int id = 0;

            InserirNaLista(ref listaDeNome, ref id);

            Console.ReadKey();

            InserirNaLista(ref listaDeNome, ref id);

            Console.ReadKey();

            AumentarLista(ref listaDeNome);

        }
        public static void InserirNaLista(ref string [,] listaDeNome, ref int id)
        {
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                if (listaDeNome[i,0] != null)
                {
                    continue;

                }
                Console.WriteLine("Informe o nome do usuário:");
                var usuario = Console.ReadLine();

                listaDeNome[i, 0] = (id++).ToString();
                listaDeNome[i, 1] = usuario;

                Console.WriteLine("Deseja inserir um novo usuário? Sim(1) Não(2)");

                var continuar = Console.ReadKey().KeyChar.ToString();
                if(continuar != "1")
                {
                    Console.WriteLine("Saindo do programa");
                    Thread.Sleep(300);
                    break;
                }

            }
            Console.WriteLine("Registro(s) adicionados com sucesso, segue a lista dos usuários");


            ListarUsuários(ref listaDeNome, ref id);
        }
        public static void ListarUsuários(ref string [,] listaDeNome, ref int id)
        {
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                Console.WriteLine(string.Format("Id:{0} - Usuário:{1}", listaDeNome[i, 0], listaDeNome[i, 1]));

            }
        }
        public static void AumentarLista(ref string [,] listaDeNome)
        {
            var limite = true;

            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                if(listaDeNome[i,0] == null)
                {
                    limite = false;

                }
            }
            if (limite)
            {
                var listaCopia = listaDeNome;
                listaDeNome = new string[listaDeNome.GetLength(0) + 3, 2];

                for (int i = 0; i < listaDeNome.GetLength(0); i++)
                {
                    listaDeNome[i, 0] = listaCopia[i, 0];
                    listaDeNome[i, 1] = listaCopia[i, 1];
                }
                Console.WriteLine($"Tamanho da lista atualizado de {listaCopia.GetLength(0)} para {listaDeNome.GetLength(0)} ");

            }
        }
    }
}
