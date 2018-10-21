using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjManutencaoAluno
{
    public class Aluno
    {
        private int registro;
        public int Registro
        {
            get
            {
                return registro;
            }

            set
            {
                registro = value;
            }
        }

        private String nome;
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

        private String cpf;
        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }
        //Criei DateTime como Nullable
        private DateTime? dataNascimento;
        public DateTime? DataNascimento
        {
            get
            {
                return dataNascimento;
            }

            set
            {
                dataNascimento = value;
            }
        }

        private String sexo;
        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        private String telefone;
        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        private String email;
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        private String situacao;
        public string Situacao
        {
            get
            {
                return situacao;
            }

            set
            {
                situacao = value;
            }
        }

        public Aluno()
        {
            registro = 0;
            nome = "";
            cpf = "";
            dataNascimento = null;
            sexo = "";
            telefone = "";
            email = "";
            situacao = "";
        }

        public Aluno(int registro,String nome,String cpf,DateTime dataNascimento,
            String sexo,String telefone,String email,String situacao)
        {
            this.registro = registro;
            this.nome =  nome;
            this.cpf = cpf;
            this.dataNascimento =dataNascimento;
            this.sexo = sexo;
            this.telefone = telefone;
            this.email = email;
            this.situacao = situacao;
        }

        public String ToString()
        {
            return "Registro: " + registro.ToString() + " - Nome: " + nome.ToString() +
                " - CPF: " + cpf.ToString() + " - Data Nascimento: " +
                dataNascimento.ToString() + " - Sexo: " + sexo.ToString() +
                " - Telefone: " + telefone.ToString() + " - Email: " + email.ToString() +
                " - Situacao: " + situacao.ToString();
        }

        public Boolean Equals(Aluno alu)
        {
            Boolean retorno = false;
            if (this.registro == alu.Registro &&
                this.nome.Equals(alu.Nome) &&
                this.cpf.Equals(alu.cpf) &&
                this.DataNascimento.Equals(alu.DataNascimento) &&
                this.sexo.Equals(alu.Sexo) &&
                this.telefone.Equals(alu.Telefone) &&
                this.email.Equals(alu.Email) &&
                this.situacao.Equals(alu.Situacao))
                retorno = true;

            return retorno;
        }

    }
}
