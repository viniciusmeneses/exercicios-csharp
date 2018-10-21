using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFuncionarioBancoMySQL
{
    class Funcionario : Pessoa
    {
        private double salario;
        private String cargo;
        private DateTime dataAdmissao;
        private DateTime dataDemissao;

        public Funcionario() : base()
        {
            this.Salario = 0;
            this.Cargo = "";
            this.DataAdmissao = new DateTime();
            this.DataDemissao = new DateTime();
        }

        public double Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }

        public string Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
            }
        }

        public DateTime DataAdmissao
        {
            get
            {
                return dataAdmissao;
            }

            set
            {
                dataAdmissao = value;
            }
        }

        public DateTime DataDemissao
        {
            get
            {
                return dataDemissao;
            }

            set
            {
                dataDemissao = value;
            }
        }

        public override String ToString()
        {
            return base.ToString() + "\nSalario: " + this.Salario.ToString() + "\nCargo: " + this.Cargo.ToString() + "\nData Admissão: " + this.DataAdmissao.ToShortDateString() + "\nData Demissão: " + this.DataDemissao.ToShortDateString();
        }

        public Boolean Equals(Funcionario func)
        {
            Boolean retorno = false;

            if (this.Salario == func.Salario && this.Cargo.Equals(func.Cargo) && this.DataAdmissao.Equals(func.DataAdmissao) && this.DataDemissao.Equals(func.DataDemissao))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
