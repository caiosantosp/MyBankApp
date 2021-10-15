using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankAppConsole
{
    class ContaCorrente
    {
        // O titular será um cliente.
        public Cliente titular;
        public int agencia;
        public int conta;

        private double saldo = 100.00;
    }
}
