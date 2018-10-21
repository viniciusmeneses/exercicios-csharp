using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjExemploInterface
{
    public class Dependente:Pessoa,Paciente
    {
        private String nroConvenio;

        public String NroConvenio
        {
            get { return nroConvenio; }
            set { nroConvenio = value; }
        }

        private Socio socio;

        public Socio Socio
        {
            get { return socio; }
            set { socio = value; }
        }

        public Dependente()
            : base()
        {
            this.nroConvenio = "";
            this.socio = new Socio();
        }

        public Dependente(String nome,int idade,String cpf,String nroConvenio,Socio socio):base(nome,idade,cpf)

        {
            this.nroConvenio = nroConvenio;
            this.socio = socio;
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
        public override String ToString()
        {
            return "Nome: " + this.Nome + "\nIdade: " + this.Idade.ToString() + "\nNúmero Convênio: " + this.nroConvenio + "\nSócio: " + this.socio.ToString();
        }

    }
}

