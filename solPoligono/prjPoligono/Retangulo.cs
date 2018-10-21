using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPoligono
{
    class Retangulo : Poligono
    {
        private double lado1;
        private double lado2;

        public Retangulo()
        {
            this.Lado1 = 0;
            this.Lado2 = 0;
            this.NroLados = 4;
        }
        public Retangulo(double lado1, double lado2)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.NroLados = 4;
        }

        public double Lado1
        {
            get
            {
                return lado1;
            }

            set
            {
                lado1 = value;
            }
        }

        public double Lado2
        {
            get
            {
                return lado2;
            }

            set
            {
                lado2 = value;
            }
        }

        public String getNome()
        {
            String retorno = "";

            if(this.Lado1 == this.Lado2)
            {
                retorno = "Quadrado";
            }
            else {
                retorno = base.getNome();
            }
            return retorno;
        }

        public override double getArea()
        {
            return this.Lado1 * this.Lado2;
        }
        public override double getPerimetro()
        {
            return (this.Lado1 * 2) + (this.Lado2 * 2);
        }
        public override Image getImage()
        {
            Image retorno = null;
            if (this.getNome().Equals("Quadrado"))
            {
                retorno = Properties.Resources.quadrado;
            }
            else
            {
                retorno = Properties.Resources.retangulo;
            }

            return retorno;
        }
        public override String ToString()
        {
            return  "O " + this.getNome().ToString() + " tem lados: " + this.Lado1.ToString() + " e " + this.Lado2.ToString() + ".";
        }
        public Boolean Equals(Retangulo retan)
        {
            Boolean retorno = false;

            if (this.Lado1 == retan.Lado1 && this.Lado2 == retan.Lado2 && this.NroLados == retan.NroLados)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
