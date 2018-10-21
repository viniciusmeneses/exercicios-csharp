using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFuncionarioBancoMySQL
{
    class FuncionarioBD
    {
        private Conexao con = new Conexao();

        public Boolean inclui(Funcionario func)
        {
            Boolean retorno = false;

            if (func.DataDemissao.Equals(new DateTime()))
            {
                retorno = con.executaComando("INSERT INTO FUNCIONARIO VALUES('" + func.Cpf.ToString() + "','" + func.Nome.ToString() + "', '" + func.Cargo.ToString() + "', " + func.Salario.ToString() + ", '" + func.DataAdmissao.ToString("yyyy-MM-dd") + "', null);");
            }
            else
            {
                retorno = con.executaComando("INSERT INTO FUNCIONARIO VALUES('" + func.Cpf.ToString() + "','" + func.Nome.ToString() + "', '" + func.Cargo.ToString() + "', " + func.Salario.ToString() + ", '" + func.DataAdmissao.ToString("yyyy-MM-dd") + "', '" + func.DataDemissao.ToString("yyyy-MM-dd") + "');");
            }

            return retorno;
        }
        public Boolean altera(Funcionario func)
        {
            Boolean retorno = false;

            if (func.DataDemissao.Equals(new DateTime()))
            {
                retorno = con.executaComando("UPDATE FUNCIONARIO SET NOME='" + func.Nome.ToString() + "', CARGO='" + func.Cargo.ToString() + "', SALARIO=" + func.Salario.ToString() + ", DATAADMISSAO='" + func.DataAdmissao.ToString("yyyy-MM-dd") + "', DATADEMISSAO=null WHERE CPF='" + func.Cpf.ToString() + "';");
            }
            else
            {
                retorno = con.executaComando("UPDATE FUNCIONARIO SET NOME='" + func.Nome.ToString() + "', CARGO='" + func.Cargo.ToString() + "', SALARIO=" + func.Salario.ToString() + ", DATAADMISSAO='" + func.DataAdmissao.ToString("yyyy-MM-dd") + "', DATADEMISSAO='" + func.DataDemissao.ToString("yyyy-MM-dd") + "' WHERE CPF='" + func.Cpf.ToString() + "';");
            }

            return retorno;
        }
        public Boolean exclui(Funcionario func)
        {
            return con.executaComando("DELETE FROM FUNCIONARIO WHERE CPF='" + func.Cpf.ToString() + "';");
        }
        public Boolean consulta(Funcionario func)
        {
            Boolean retorno = false;
            DataTable dat = new DataTable();
            dat = con.executaComandoR("SELECT * FROM FUNCIONARIO WHERE CPF='" + func.Cpf.ToString() + "';");
            if (dat.Rows.Count > 0)
            {
                retorno = true;

                func.Cpf = dat.Rows[0][0].ToString();
                func.Nome = dat.Rows[0][1].ToString();
                func.Cargo = dat.Rows[0][2].ToString();
                func.Salario = Convert.ToDouble(dat.Rows[0][3].ToString());
                func.DataAdmissao = DateTime.Parse(dat.Rows[0][4].ToString());
                if(dat.Rows[0][5].ToString() == "")
                {
                    func.DataDemissao = new DateTime();
                }
                else
                {
                    func.DataDemissao = DateTime.Parse(dat.Rows[0][5].ToString());
                }
            }
            return retorno;
        }
    }
}
