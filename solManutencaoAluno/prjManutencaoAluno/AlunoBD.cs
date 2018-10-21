using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjManutencaoAluno
{
    public class AlunoBD
    {
        Conexao con;

        public AlunoBD()
        {
            con = new Conexao();
        }

        public Boolean inclui(Aluno alu)
        {
            // Converte Nullable DateTime em DateTime
            DateTime DtNasc = (DateTime) alu.DataNascimento;
            return con.executaComando(String.Concat("INSERT INTO ALUNO VALUES (",
                alu.Registro.ToString() , ",'" , alu.Nome , "','"
                , alu.Cpf , "','" , DtNasc.Year.ToString(),"-",DtNasc.Month.ToString(),"-",DtNasc.Day.ToString(), "','"
                , alu.Sexo , "','" , alu.Telefone , "','" , alu.Email , "','" , alu.Situacao , "');"));
        }

        public Boolean altera(Aluno alu)
        {
            DateTime DtNasc = (DateTime) alu.DataNascimento;
            return con.executaComando(String.Concat("UPDATE ALUNO SET NOME='", alu.Nome, "',CPF='", 
                alu.Cpf, "',DATANASCIMENTO='", DtNasc.Year.ToString(), "-", DtNasc.Month.ToString(), 
                "-", DtNasc.Day.ToString(), "',SEXO='", alu.Sexo, "',TELEFONE='", alu.Telefone, "',EMAIL='", 
                alu.Email, "',SITUACAO='", alu.Situacao, "' WHERE REGISTRO=", alu.Registro, ";"));
        }

    }
}
