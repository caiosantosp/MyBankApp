using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankAppConsole
{
    class Cliente
    {
        public string nome;
        public string cpf;
        public string prof;

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getCPF()
        {
            return this.cpf;
        }

        public void setCPF(string CPF)
        {
            this.cpf = CPF;
        }

        public string getProfissao()
        {
            return this.prof;
        }

        public void setProfissao(string profissao)
        {
            this.prof = profissao;
        }


    }
}
