using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjHeranca
{
    //Herança - Extends no c# usa dois pontos
    public class Juridica:Pessoa
    {
        private String cnpj;

        public String Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        private double faturamentoMensal;

        public double FaturamentoMensal
        {
            get { return faturamentoMensal; }
            set { faturamentoMensal = value; }
        }

        //Construtor sem parametros
        //:base() é o mesmo de super() do Java, chama o construtor sem parametros da superclasse
        public Juridica():base()    
        {
            this.cnpj = "";
            this.faturamentoMensal = 0;
        }

        //Construtor com parametros
        //:base(nome,telefone) chama o construtor com parametros da superclasse e passa os parametros pra ela usando o base.
        public Juridica(String nome,String telefone,String cnpj,double faturamentoMensal):base(nome,telefone) 
        {
            this.cnpj = cnpj;
            this.faturamentoMensal = faturamentoMensal;
            
        }

        public double getLimiteCredito()
        {
            return this.faturamentoMensal * 0.3;
        }

        public String toString()
        {
            //base.toString() chama o toString() da superclasse usando o base
            //Sempre que quiser referenciar a algo da superclase, utiliza o base
            return base.toString() + " CNPJ: " + this.cnpj + " Faturamento Mensal: " + this.faturamentoMensal.ToString() + " Limite de Credito: " + this.getLimiteCredito().ToString();
        }

        public Boolean Equals(Juridica juridica)
        {
            Boolean retorno = false;
            if (base.Equals(juridica) && this.cnpj.Equals(juridica.cnpj) && this.faturamentoMensal == juridica.FaturamentoMensal)
                retorno = true;
            return retorno;
        }
    }
}
