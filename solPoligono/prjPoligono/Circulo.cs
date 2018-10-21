using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPoligono
{
    class Circulo : Poligono
    {
        private double raio;

        public Circulo()
        {
            this.Raio = 0;
            this.NroLados = 1;
        }
        public Circulo(double raio)
        {
            this.Raio = raio;
            this.NroLados = 1;
        }

        public double Raio
        {
            get
            {
                return raio;
            }

            set
            {
                raio = value;
            }
        }

        public double getDiametro()
        {
            return this.Raio * 2;
        }
        public override double getArea()
        {
            return Math.PI * this.Raio * this.Raio;
        }
        public override double getPerimetro()
        {
            return 2 * Math.PI * this.Raio;
        }
        public override Image getImage()
        {
            return Properties.Resources.circulo;
        }
        public override String ToString()
        {
            return "O Círculo tem Raio: " + this.Raio.ToString() + " e Diâmetro: " + this.getDiametro().ToString() + ".";
        }
        public Boolean Equals(Circulo circ)
        {
            Boolean retorno = false;

            if (this.Raio == circ.Raio && this.NroLados == circ.NroLados)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
