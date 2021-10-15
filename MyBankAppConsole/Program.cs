using System;

namespace MyBankAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.setNome("Caio");
            cliente1.setCPF("000.000.000.00");
            cliente1.setProfissao("Service Desk");

          
            ContaCorrente contaCorrente = new ContaCorrente();

            contaCorrente.titular = cliente1;
            contaCorrente.agencia = 7375;
            contaCorrente.conta = 00001;
        }
    }
}
