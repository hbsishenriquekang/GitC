using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReceitaDeBolo
{
    class Program
    {
        static void Main(string[] args)
        {
            TelaInicial();

            Ingredientes();

            Preparo();
        }
        public static void TelaInicial()
        {
            Console.WriteLine("Seja bem vindo");
            Console.WriteLine("Vou ensinar hoje como fazer um bolo");
            Console.WriteLine("Preparado?");

            Console.WriteLine("Pressione Qualquer Tecla Para Continuar");
            
            Console.ReadKey();
            Console.Clear();
        }
        public static void Ingredientes()
        {
            Console.WriteLine("Primeiramente tenha os seguintes ingredintes em mãos");
            Console.WriteLine("2 xícaras (chá) de açúcar");
            Console.WriteLine("3 xícaras (chá) de farinha de trigo");
            Console.WriteLine("4 colheres (sopa) de margarina");
            Console.WriteLine("3 ovos");
            Console.WriteLine("1 e 1/2 xícara (chá) de leite");
            Console.WriteLine("1 colher (sopa) bem cheia de fermento em pó");

            Console.WriteLine("Pressione qualquer tecla para continuar para o modo de preparo");

            Console.ReadKey();
            Console.Clear();
        }
        public static void Preparo()
        {
            Console.WriteLine(" Bata as claras em neve e reserve.");
            Console.WriteLine("Misture as gemas, a margarina e o açúcar até obter uma massa homogênea.");
            Console.WriteLine("Acrescente o leite e a farinha de trigo aos poucos, sem parar de bater.  ");
            Console.WriteLine("Por último, adicione as claras em neve e o fermento.");
            Console.WriteLine("Despeje a massa em uma forma grande de furo central untada e enfarinhada.");
            Console.WriteLine("Asse em forno médio 180 °C, preaquecido, por aproximadamente 40 minutos ou ao furar o bolo com um garfo, este saia limpo.");

            Console.WriteLine("Pressione qualquer tecla para fechar a receita.");

            Console.ReadKey();
        }
        

    }
}
