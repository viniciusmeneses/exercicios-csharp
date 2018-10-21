using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjViniciusBarbieri
{
    class Pessoa
    {
        private String nome;

        public Pessoa()
        {
            this.nome = "";
        }

        public Pessoa(String nome)
        {
            this.nome = nome;
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



        public String ToString()
        {
            return "Nome: " + this.nome.ToString();
        }

        public Boolean Equals(Pessoa pes)
        {
            Boolean retorno = false;

            if(nome.Equals(pes.Nome))
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
