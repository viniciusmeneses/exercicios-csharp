using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDupla
{
    class VeiculoDB
    {
        Conexao con;

        public VeiculoDB()
        {
            con = new Conexao();
        }

        public Boolean inclui(Veiculo vei)
        {
            return con.executaComando(String.Concat("INSERT INTO VEICULO VALUES (",
                vei.Id.ToString(), ",'", vei.Marca, "','"
                , vei.Nome, "','", vei.Combustivel, "',", vei.Lugares.ToString(), ",", vei.VelocidadeMax.ToString(), ");"));
        }

        //metodo update
        public Boolean altera(Veiculo vei)
        {
            return con.executaComando(String.Concat("UPDATE VEICULO SET MARCA='", vei.Marca, "',NOME='",
                vei.Nome, "',COMBUSTIVEL='", vei.Combustivel, "',LUGARES=", vei.Lugares.ToString(), ",VELOCIDADEMAX=", vei.VelocidadeMax.ToString(), " WHERE ID=", vei.Id.ToString(), ";"));
        }

        //Metodo delete
        public Boolean exclui(Veiculo vei)
        {
            return con.executaComando(String.Concat("DELETE FROM VEICULO WHERE ID=", vei.Id.ToString(), ";"));
        }

        //metodo select
        public Boolean consulta(Veiculo vei)
        {
            //Usa DataTable porque a conexao retorna os dados em DataTable
            DataTable retorno;

            Boolean conclusao;
            retorno = con.executaComandoR(String.Concat("SELECT * FROM VEICULO WHERE ID=", vei.Id.ToString(), ";"));
            if (retorno.Rows.Count > 0)
            {
                conclusao = true;

                //Converte retorno da tabela de string pra int16
                vei.Id = Int16.Parse(retorno.Rows[0][0].ToString());
                vei.Marca = retorno.Rows[0][1].ToString();
                vei.Nome = retorno.Rows[0][2].ToString();
                vei.Combustivel = retorno.Rows[0][3].ToString();
                vei.Lugares = Int16.Parse(retorno.Rows[0][4].ToString());
                vei.VelocidadeMax = Int16.Parse(retorno.Rows[0][5].ToString());
            }
            else
            {
                conclusao = false;
            }

            return conclusao;
        }
    }
}
