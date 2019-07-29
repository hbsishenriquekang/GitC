using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaGG.Classes
{
    class Conta
    {
        double saldo = 0;
        int pastel = 10;

        public double Saldo { get { return saldo; } }
        public Conta()
        {
            saldo = 20;

        }

        public bool Sacar(int desejo)
        {
            
            if (desejo == 1 && pastel <= saldo)
            {
                saldo -= pastel;
                return true;

            }
            else
            {
                return false;
            }
        }
        public double MostrarSaldo()
        {
            return saldo;

        }

    }
}
