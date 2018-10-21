using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjExemploInterface
{
    public class Socio:Pessoa,Paciente
    {
        private String nroConvenio;

        public String NroConvenio
        {
            get { return nroConvenio; }
            set { nroConvenio = value; }
        }

        public Socio(String nome,int idade,String cpf,String nroConvenio):base(nome,idade,cpf)

        {
            this.nroConvenio = nroConvenio;
        }

        public Socio()
            : base()
        {
            this.nroConvenio = "";
        }

        public String getNome()
        {
            return this.Nome;
        }
        public void setNome(String nome)
        {
            this.Nome = nome;
        }
        public int getIdade()
        {
            return Idade;
        }
        public void setIdade(int Idade)
        {
            this.Idade = Idade;
        }
        public String getNroConvenio()
        {
            return this.nroConvenio;
        }
        public void setNroConvenio(String nroConvenio)
        {
            this.nroConvenio = nroConvenio;
        }

        public override  String ToString()
        {
            return "Nome: " + this.Nome + "\nIdade: " + this.Idade.ToString() + "\nNúmero Convênio: " + this.nroConvenio;
        }
    }
}
