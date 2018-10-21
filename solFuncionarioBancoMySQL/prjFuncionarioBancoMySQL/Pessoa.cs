using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFuncionarioBancoMySQL
{
    class Pessoa
    {
        private String cpf;
        private String nome;

        public Pessoa()
        {
            this.Cpf = "";
            this.Nome = "";
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public override String ToString()
        {
            return "CPF: " + this.Cpf.ToString() + "\nNome: " + this.Nome.ToString();
        }

        public Boolean Equals(Pessoa pes)
        {
            Boolean retorno = false;

            if(this.Cpf.Equals(pes.Cpf) && this.Nome.Equals(pes.Nome))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
