using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projCinema
{
    class FilmeBD
    {
        private Conexao con = new Conexao();

        public Boolean inclui(Filme film)
        {
            return con.executaComando("INSERT INTO FILME VALUES(" + film.Codigo.ToString() + ",'" + film.Nome.ToString() + "');");
        }
        public Boolean altera(Filme film)
        {
            return con.executaComando("UPDATE FILME SET NOME='"
                + film.Nome.ToString() + "' WHERE CODIGO=" + film.Codigo.ToString() + ";");
        }

        public Boolean exclui(Filme film)
        {
            return con.executaComando("DELETE FROM FILME WHERE CODIGO=" + film.Codigo.ToString() + ";");
        }

        public Boolean seleciona(Filme film)
        {
            Boolean retorno = false;
            DataTable dat = new DataTable();
            dat = con.executaComandoR("SELECT * FROM TIPO WHERE CODIGO=" + film.Codigo.ToString() + ";");
            if (dat.Rows.Count > 0)
            {
                film.Nome = dat.Rows[0][1].ToString();
                retorno = true;
            }
            return retorno;
        }

        public DataTable seleciona()
        {
            return con.executaComandoR("SELECT * FROM FILME;");
        }
    }
}
