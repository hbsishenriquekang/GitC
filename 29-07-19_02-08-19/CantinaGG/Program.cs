using CantinaGG.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaGG
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta accountUser = new Conta();

            Console.WriteLine("Deseja comprar um pastel? (1)SIM (2)NÃO");

            int.TryParse(Console.ReadLine(), out int desejaLanche);

            if (accountUser.Sacar(desejaLanche))
            {
                Console.WriteLine("Lanche comprado");

            }
            else
            {
                Console.WriteLine("Operação não realizada");

            }
            Console.WriteLine($"Saldo:{accountUser.Saldo.ToString("N2")}");

            Console.ReadKey();
        }
    }
}
