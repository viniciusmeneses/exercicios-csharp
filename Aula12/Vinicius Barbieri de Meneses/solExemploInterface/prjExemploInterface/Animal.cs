using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjExemploInterface
{
    public class Animal:Paciente
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

        private String nroConvenio;
        public String NroConvenio
        {
            get { return nroConvenio; }
            set { nroConvenio = value; }
        }

        private String tipo;
        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private String raca;
        public String Raca
        {
            get { return raca; }
            set { raca = value; }
        }

        public Animal()
        {
            this.nome = "";
            this.idade = 0;
            this.nroConvenio = "";
            this.tipo = "";
            this.raca = "";
        }

        public Animal(String nome, int idade, String nroConvenio,String tipo, String raca)
        {
            this.nome = nome;
            this.idade = idade;
            this.nroConvenio = nroConvenio;
            this.tipo = tipo;
            this.raca = raca;
        }
        public String getNome()
        {
            return this.nome;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public int getIdade()
        {
            return idade;
        }
        public void setIdade(int Idade)
        {
            this.idade = idade;
        }
        public String getNroConvenio()
        {
            return this.nroConvenio;
        }
        public void setNroConvenio(String nroConvenio)
        {
            this.nroConvenio = nroConvenio;
        }
        public override String ToString()
        {
            return "Nome: " + this.nome + " \nIdade: " + this.Idade.ToString() + "\nNúmero Convênio: " + this.nroConvenio + "\nTipo: " + this.tipo + "\nRaça: " + this.raca;
        }
    }
}
