using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjExemploInterface
{
    public abstract class Pessoa
    {
        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private int idade;
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        private String cpf;
        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public Pessoa()
        {
            this.nome = "";
            this.idade = 0;
            this.cpf = "";
        }

        public Pessoa(String nome, int idade, String cpf)
        {
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
        }
    }
}
