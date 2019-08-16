using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MostrarJoinhaClass;

namespace UsandoBibliotecaJoinha
{
    class Program
    {
        static void Main(string[] args)
        {
            new AquiMostraJoinha().MetodoInicial();

            new AquiMostraJoinha().MetodoDoisPontoZero(true);

            new AquiMostraJoinha().MetodoDoisPontoZero(false);

            Console.WriteLine(new AquiMostraJoinha().TesteUmOperadorLegal());

            var Teste = new AquiMostraJoinha().TesteUmOperadorLegal();

            var Tamanho = Teste.Length;

            for (int i = 0; i < Tamanho; i++)
            {
                Console.WriteLine(Teste[i]);
            }

            Console.ReadKey();

        }
    }
}
