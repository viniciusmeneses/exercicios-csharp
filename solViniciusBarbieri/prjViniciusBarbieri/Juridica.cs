using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjViniciusBarbieri
{
    class Juridica:Pessoa
    {
        private String cnpj;

        public Juridica():base()
        {
            this.Cnpj = "";
        }

        public Juridica(String nome, String cnpj):base(nome)
        {
            this.Cnpj = cnpj;
        }

        public string Cnpj
        {
            get
            {
                return cnpj;
            }

            set
            {
                cnpj = value;
            }
        }

        public String ToString()
        {
            return base.ToString() + " - CNPJ: " + this.cnpj.ToString();
        }
        public Boolean Equals(Juridica jur)
        {
            Boolean retorno = false;

            if(base.Equals(jur) && this.cnpj.Equals(jur.Cnpj))
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
