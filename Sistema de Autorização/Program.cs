using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Autorização
{
    class Program
    {
        static string[,] baseDeDados;
        static void Main(string[] args)
        {
            CarregaDados();

            TelaInicial();

            ListarDados();

        }
        public static void TelaInicial()
        {
            Console.WriteLine("Bem vindo a lista de alunos");
            Console.WriteLine("Digite qualquer tecla para continuar");

            Console.ReadKey();

            Console.Clear();
        }
        public static void CarregaDados()
        {
            baseDeDados = new string[20, 3]
            {
                {"Aluno 1", "17", "Masculino" },
                {"Aluno 2", "17", "Feminino" },
                {"Aluno 3", "18", "Masculino" },
                {"Aluno 4", "18", "Ferminino" },
                {"Aluno 5", "19", "Masculino" },
                {"Aluno 6", "19", "Feminino" },
                {"Aluno 7", "17", "Masculino" },
                {"Aluno 8", "17", "Feminino" },
                {"Aluno 9", "18", "Masculino" },
                {"Aluno 10", "18", "Ferminino" },
                {"Aluno 11", "19", "Masculino" },
                {"Aluno 12", "19", "Feminino" },
                {"Aluno 13", "17", "Masculino" },
                {"Aluno 14", "17", "Feminino" },
                {"Aluno 15", "18", "Masculino" },
                {"Aluno 16", "18", "Ferminino" },
                {"Aluno 17", "19", "Masculino" },
                {"Aluno 18", "19", "Feminino" },
                {"Aluno 19", "17", "Masculino" },
                {"Aluno 20", "17", "Feminino" },

            };

        }
        public static void ListarDados()
        {

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                Console.WriteLine($"Aluno: {baseDeDados[i, 0]} Idade: {baseDeDados[i, 1]} Sexo: {baseDeDados[i, 2]} ");

            }

            Console.ReadKey();
        }
    }
}
