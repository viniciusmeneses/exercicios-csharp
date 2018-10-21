using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjExemploInterface
{
    class Medico:Pessoa
    {
        private int nroCRM;
        private String especialidade;

        public int NroCRM
        {
            get
            {
                return nroCRM;
            }

            set
            {
                nroCRM = value;
            }
        }

        public string Especialidade
        {
            get
            {
                return especialidade;
            }

            set
            {
                especialidade = value;
            }
        }

        public Medico():base()
        {
            this.nroCRM = 0;
            this.especialidade = "";
        }

        public Medico(String nome, int idade, String cpf, int nroCRM, String especialidade):base(nome, idade, cpf)
        {
            this.nroCRM = nroCRM;
            this.especialidade = especialidade;
        }

        public override String ToString()
        {
            return "Nome: " + this.Nome + "\nIdade: " + this.Idade.ToString() + "\nNúmero de CRM: " + this.nroCRM.ToString() + "\nEspecialidade: " + this.especialidade.ToString();
        }

        public Boolean Equals(Medico med)
        {
            Boolean retorno = false;
            if(this.nroCRM == med.NroCRM && this.especialidade.Equals(med.Especialidade))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
