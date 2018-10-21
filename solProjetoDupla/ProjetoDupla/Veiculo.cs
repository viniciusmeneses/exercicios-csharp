using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDupla
{
    class Veiculo
    {
        private Int16 id;
        private String marca;
        private String nome;
        private String combustivel;
        private Int16 lugares;
        private Int16 velocidadeMax;

        public Veiculo()
        {
            id = 0;
            marca = "";
            nome = "";
            combustivel = "";
            lugares = 0;
            VelocidadeMax = 0;
        }

        public Veiculo(Int16 id, String marca, String nome, String combustivel, Int16 lugares, Int16 velocidadeMax)
        {
            this.id = id;
            this.marca = marca;
            this.nome = nome;
            this.combustivel = combustivel;
            this.lugares = lugares;
            this.VelocidadeMax = velocidadeMax;
        }

        public short Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
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

        public string Combustivel
        {
            get
            {
                return combustivel;
            }

            set
            {
                combustivel = value;
            }
        }

        public short Lugares
        {
            get
            {
                return lugares;
            }

            set
            {
                lugares = value;
            }
        }

        public short VelocidadeMax
        {
            get
            {
                return velocidadeMax;
            }

            set
            {
                velocidadeMax = value;
            }
        }

        public String ToString()
        {
            return "Registro: " + this.Id.ToString() + "\nMarca: " + this.Marca + "\nNome: " + this.Nome + "\nCombustível: " + this.Combustivel + "\nLugares: " + this.Lugares.ToString() + "\nVelocidade Máxima: " + this.VelocidadeMax.ToString() + "km/h";
        }
        public Boolean Equals (Veiculo vcl)
        {
            Boolean retorno = false;

            if (this.Id.Equals(vcl.Id) && this.Marca.Equals(vcl.Marca) && this.Nome.Equals(vcl.Nome) && this.Combustivel.Equals(vcl.Combustivel) && this.Lugares.Equals(vcl.Lugares) && this.VelocidadeMax.Equals(vcl.VelocidadeMax))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
