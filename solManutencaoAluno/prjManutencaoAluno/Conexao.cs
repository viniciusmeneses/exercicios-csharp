using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace prjManutencaoAluno
{
    public class Conexao
    {
        private String connectionString;

        public Conexao()
        {
            this.connectionString = "server=127.0.0.1;database=bdEscola;uid=alunos;pwd='etec'";
        }

        public String getConnectionString()
        {
            return this.connectionString;
        }

        public Boolean executaComando(String comando)
        {
            if (comando.Length > 0)
            {
                try
                {
                    MySqlConnection Conn = new MySqlConnection(this.getConnectionString());
                    Conn.Open();
                    MySqlCommand Cmd = new MySqlCommand(comando.ToString(), Conn);
                    int nroLinhasAfetadas = Cmd.ExecuteNonQuery();
                    Conn.Close();
                    if (nroLinhasAfetadas != 0)
                       return true;
                    else
                       return false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                    return false;
                }
            }
            else
                return false;
        }
        public DataTable executaComandoR(String comando)
        {
            DataTable dt = new DataTable();
            if (comando.Length > 0)
            {
                try
                {
                    MySqlConnection Conn = new MySqlConnection(this.getConnectionString());
                    Conn.Open();
                    MySqlCommand Cmd = new MySqlCommand(comando.ToString(), Conn);
                    MySqlDataReader rsComando = Cmd.ExecuteReader();
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