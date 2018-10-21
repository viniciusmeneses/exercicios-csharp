using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace prjAluno
{
    class Conexao
    {
        //Cria um atributo que vai ter a string usada pra conectar ao banco de dados
        private String connectionString;

        public Conexao()
        {
            //Coloca os dados do bd no atributo connectionString
            this.connectionString = "server=127.0.0.1;database=BDEscola;uid=alunos;pwd='etec'";
        }

        public String getConnectionString()
        {
            return this.connectionString;
        }

        //Método que executa o comando passado por parametro no banco de dados e retorna true ou false se der certo ou nao
        public Boolean executaComando(String comando)
        {
            //Se o comando for maior que 0
            if (comando.Length > 0)
            {
                //Tenta rodar o codigo:
                try
                {
                    //Instancia uma conexao com o bd passando a String dos dados do bd por parametro no construtor
                    MySqlConnection Conn = new MySqlConnection(this.getConnectionString());
                    //Inicia a conexao
                    Conn.Open();
                    //Instancia o objeto mysqlCommand passando por parametro pra o construtor o comando sql q vai ser executado e a conexão que vai ser usada (banco)
                    MySqlCommand Cmd = new MySqlCommand(comando.ToString(), Conn);
                    //Executa o comando usando NonQuery (sem retorno de dados) e recebe os valores das linhas afetadas 
                    int nroLinhasAfetadas = Cmd.ExecuteNonQuery();
                    //Fecha a conexao
                    Conn.Close();

                    //Se o numero de linhas afetadas for diferente de 0, retorna true, caso contrario retorna false
                    if (nroLinhasAfetadas != 0)
                        return true;
                    else
                        return false;
                }
                //Se der erro, executa:
                catch (Exception e)
                {
                    //Mostra a mensagem do erro
                    MessageBox.Show(e.Message.ToString());
                    return false;
                }
            }
            else
                return false;
        }

        //Método que executa comando passado por parametro no banco de dados e retorna os dados do comando (select) do tipo DataTable
        public DataTable executaComandoR(String comando)
        {
            //Instancia um objeto DataTable para receber o retorno do select
            DataTable dt = new DataTable();
            if (comando.Length > 0)
            {
                try
                {
                    MySqlConnection Conn = new MySqlConnection(this.getConnectionString());
                    Conn.Open();
                    MySqlCommand Cmd = new MySqlCommand(comando.ToString(), Conn);

                    //Executa o metodo ExecuteReader para executar o comando e receber na variavel mysqldatareader
                    MySqlDataReader rsComando = Cmd.ExecuteReader();

                    //Carrega o valor do retorno do rsComando no DataTable e retorna ela
                    dt.Load(rsComando);
                    return dt;

                    rsComando.Close();
                    Conn.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                    return null;
                }
            }
            else
                return null;
        }
    }
}
