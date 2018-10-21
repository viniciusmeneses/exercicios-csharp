using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDupla
{
    class CarroDB
    {
        Conexao con;

        public CarroDB()
        {
            con = new Conexao();

        }

        public Boolean inclui(Carro car)
        {
            return con.executaComando(String.Concat("INSERT INTO CARRO VALUES ('",
                car.Modelo.ToString(), "','", arCondConverter(car), "','"
                , somConverter(car), "','", car.Direcao, "',", car.Id.ToString(), ");"));
        }

        //metodo update
        public Boolean altera(Carro car)
        {
            return con.executaComando(String.Concat("UPDATE CARRO SET MODELO='", car.Modelo, "',ARCOND='",
                arCondConverter(car), "',SOM='", somConverter(car), "',DIRECAO='", car.Direcao, "' WHERE IDVEICULO=", car.Id.ToString(), ";"));
        }

        //Metodo delete
        public Boolean exclui(Carro car)
        {
            return con.executaComando(String.Concat("DELETE FROM CARRO WHERE IDVEICULO=", car.Id.ToString(), ";"));
        }

        //metodo select
        public Boolean consulta(Carro car)
        {
            //Usa DataTable porque a conexao retorna os dados em DataTable
            DataTable retorno;

            Boolean conclusao;
            retorno = con.executaComandoR(String.Concat("SELECT * FROM CARRO WHERE IDVEICULO=", car.Id.ToString(), ";"));
            if (retorno.Rows.Count > 0)
            {
                conclusao = true;
                Boolean arCondR = false;
                Boolean somR = false;

                //Converte retorno da tabela de string pra int16
                car.Modelo = retorno.Rows[0][0].ToString();
                if (retorno.Rows[0][1].ToString() == "Sim")
                {
                    arCondR = true;
                }
                if (retorno.Rows[0][2].ToString() == "Sim")
                {
                    somR = true;
                }
                car.ArCond = arCondR;
                car.Som = somR;
                car.Direcao = retorno.Rows[0][3].ToString();
                car.Id = Int16.Parse(retorno.Rows[0][4].ToString());
            }
            else
            {
                conclusao = false;
            }

            return conclusao;
        }

        private String arCondConverter(Carro car)
        {
            String retorno = "";
            if (car.ArCond)
            {
                retorno = "Sim";
            }
            else
            {
                retorno = "Não";
            }
            return retorno;
        }

        private String somConverter(Carro car)
        {
            String retorno = "";
            if (car.Som)
            {
                retorno = "Sim";
            }
            else
            {
                retorno = "Não";
            }
            return retorno;
        }
    }
}
