using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDupla
{
    class Carro:Veiculo
    {
        private String modelo;
        private Boolean arCond;
        private Boolean som;
        private String direcao;

        public Carro():base()
        {
            this.modelo = "";
            this.arCond = false;
            this.som = false;
            this.direcao = "";
        }

        public Carro(Int16 id, String marca, String nome, String combustivel, Int16 lugares, Int16 velocidadeMax, String modelo, Boolean arCond, Boolean som, String direcao) :base(id, marca, nome, combustivel, lugares, velocidadeMax)
        {
            this.modelo = modelo;
            this.arCond = arCond;
            this.som = som;
            this.direcao = direcao;
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public bool ArCond
        {
            get
            {
                return arCond;
            }

            set
            {
                arCond = value;
            }
        }

        public bool Som
        {
            get
            {
                return som;
            }

            set
            {
                som = value;
            }
        }

        public string Direcao
        {
            get
            {
                return direcao;
            }

            set
            {
                direcao = value;
            }
        }

        public String ToString()
        {
            return "Modelo: " + this.Modelo + "\nAr Condicionado:" + this.ArCond.ToString() + "\nSom: " + this.Som.ToString() + "\nDireção: " + this.Direcao;
        }

        public Boolean Equals(Carro car)
        {
            Boolean retorno = false;

            if(this.Modelo.Equals(car.Modelo) && this.ArCond.Equals(car.ArCond) && this.Som.Equals(car.Som) && this.Direcao.Equals(car.Direcao))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
