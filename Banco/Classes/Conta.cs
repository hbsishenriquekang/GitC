using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Classes
{
    class Conta
    {
        double saldo = 0;

        public double Saldo { get { return saldo; } }
        public Conta()
        {
            saldo = 1000;

        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
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
