using Banco.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta accountUser = new Conta();

            Console.WriteLine("Informe o valor para o saque");

            double.TryParse(Console.ReadLine(), out double valorSacar);

            if(valorSacar > 0 && accountUser.Sacar(valorSacar))
            {
                Console.WriteLine("Saque realizado com sucesso!");

            }
            else
            {
                Console.WriteLine("Operação não realizada");

            }

            Console.WriteLine($"Saldo atual disponivel:{accountUser.MostrarSaldo()}");

            Console.ReadKey();

        }
    }
}
