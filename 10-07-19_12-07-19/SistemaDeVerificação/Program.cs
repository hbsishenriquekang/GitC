using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVerificação
{
    class Program
    {
        static void Main(string[] args)
        {
            TelaInicial();

            Verificar();

        }
        public static void TelaInicial()
        {
            Console.WriteLine("Seja bem vindo ao sistema de verificação de idade");
            Console.WriteLine("Pressione qualquer tecla para continuar");

            Console.ReadKey();
            Console.Clear();
        }
        public static void Verificar()
        {
            Console.WriteLine("Digite o nome da pessoa e em seguida a sua idade confirmando com a tecla enter");

            var nome = Console.ReadLine();
            int idade = int.Parse(Console.ReadLine());

            if(idade < 18)
            {
                Console.WriteLine($"A pessoa {nome} não pode beber");

            }
            if(idade >= 18)
            {
                Console.WriteLine($"A pessoa {nome} pode beber até o cu fazer bico");

            }
            Console.ReadKey();
        }
    }
}
