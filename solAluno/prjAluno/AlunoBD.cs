using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Usar essa biblioteca pra poder usar o tipo DataTable
using System.Data;

namespace prjAluno
{
    class AlunoBD
    {
        //Cria um atributo do tipo Conexao
        Conexao con;

        public AlunoBD()
        {
            //Instancia um objeto do tipo Conexao pra conectar ao BD
            con = new Conexao();
        }

        //Metodo insert
        public Boolean inclui(Aluno alu)
        {
            // Converte Nullable DateTime em DateTime
            DateTime DtNasc = (DateTime)alu.DataNascimento;

            //Executa o insert colocando os atributos do objeto aluno na String pra formar um comando SQL completo
            //Usa o String.Concat() para concatenar a string
            //Executa o metodo executaComando passando o insert formado por parametro e retorna true ou false se teve linhas afetadas 
            return con.executaComando(String.Concat("INSERT INTO ALUNO VALUES (",
                alu.Registro.ToString(), ",'", alu.Nome, "','"
                , alu.Cpf, "','", DtNasc.Year.ToString(), "-", DtNasc.Month.ToString(), "-", DtNasc.Day.ToString(), "','"
                , alu.Sexo, "','", alu.Telefone, "','", alu.Email, "','", alu.Situacao, "');"));
        }

        //metodo update
        public Boolean altera(Aluno alu)
        {
            // Converte Nullable DateTime em DateTime
            DateTime DtNasc = (DateTime)alu.DataNascimento;
            return con.executaComando(String.Concat("UPDATE ALUNO SET NOME='", alu.Nome, "',CPF='",
                alu.Cpf, "',DATANASCIMENTO='", DtNasc.Year.ToString(), "-", DtNasc.Month.ToString(),
                "-", DtNasc.Day.ToString(), "',SEXO='", alu.Sexo, "',TELEFONE='", alu.Telefone, "',EMAIL='",
                alu.Email, "',SITUACAO='", alu.Situacao, "' WHERE REGISTRO=", alu.Registro, ";"));
        }

        //Metodo delete
        public Boolean exclui(Aluno alu)
        {
            return con.executaComando(String.Concat("DELETE FROM ALUNO WHERE REGISTRO=", alu.Registro.ToString(), ";"));
        }

        //metodo select
        public Boolean consulta(Aluno alu)
        {
            //Usa DataTable porque a conexao retorna os dados em DataTable
            DataTable retorno;

            Boolean conclusao;
            //Se o registro estiver com conteudo, faz o select pelo registro
            if(alu.Registro > 0)
                retorno = con.executaComandoR(String.Concat("SELECT * FROM ALUNO WHERE REGISTRO=", alu.Registro.ToString(), ";"));
            //Se não, faz o select pelo cpf
            else
                retorno = con.executaComandoR(String.Concat("SELECT * FROM ALUNO WHERE CPF='", alu.Cpf.ToString(), "';"));

            //Se o as linhas do retorno do select for maior que 0 / achou um aluno
            if(retorno.Rows.Count > 0)
            {
                //Retorna true se achou algum aluno
                conclusao = true;

                //Pega os dados da tabela (DataTable) pela linha e coluna e coloca no atributo do aluno
                //[0][3] - linha 0, coluna 3 - segunda posição é a coluna

                //Converte retorno da tabela de string pra int32
                alu.Registro = Int32.Parse(retorno.Rows[0][0].ToString());
                alu.Nome = retorno.Rows[0][1].ToString();
                alu.Cpf = retorno.Rows[0][2].ToString();
                //Converte o retorno da tabela em datetime
                alu.DataNascimento = DateTime.Parse(retorno.Rows[0][3].ToString());
                alu.Sexo = retorno.Rows[0][4].ToString();
                alu.Telefone = retorno.Rows[0][5].ToString();
                alu.Email = retorno.Rows[0][6].ToString();
                alu.Situacao = retorno.Rows[0][7].ToString();
            }
            else
            {
                conclusao = false;
            }

            return conclusao;
        }
    }
}
