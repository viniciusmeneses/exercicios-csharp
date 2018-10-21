using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjHeranca
{
    public class Pessoa
    {
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private String telefone;

        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public Pessoa()
        {
            this.nome = "";
            this.telefone = "";
        }
        public Pessoa(String nome,String telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
         }

        public String toString()
        {
            return  "Nome: "+ this.nome + " Telefone: "+this.telefone;
        }

        public Boolean Equals(Pessoa pessoa)
        {
            Boolean retorno = false;

            if (this.nome.Equals(pessoa.Nome) && this.telefone.Equals(pessoa.Telefone))
                retorno = true;
            return retorno;
        }
    }
}
