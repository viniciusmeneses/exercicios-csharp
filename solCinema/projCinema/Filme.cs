using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projCinema
{
    class Filme
    {
        private Int16 codigo;
        private String nome;

        public Filme()
        {
            this.Codigo = 0;
            this.Nome = "";
        }

        public Filme(Int16 codigo, String nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
        }

        public short Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

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

        public String ToString()
        {
            return "Código: " + this.Codigo.ToString() + "\nNome: " + this.Nome.ToString();
        }

        public Boolean Equals(Filme film)
        {
            Boolean retorno = false;
            if (this.Nome.Equals(film.Nome) && this.Codigo.Equals(film.Codigo))
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
