using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPoligono
{
    class Paralelogramo : Poligono
    {
        private double lado1;
        private double lado2;
        private double vBase;
        private double vAltura;

        public Paralelogramo()
        {
            this.Lado1 = 0;
            this.Lado2 = 0;
            this.VBase = 0;
            this.VAltura = 0;
            this.NroLados = 4;
        }
        public Paralelogramo(double lado1, double lado2, double vBase, double vAltura)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.VBase = vBase;
            this.VAltura = vAltura;
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

        public double VBase
        {
            get
            {
                return vBase;
            }

            set
            {
                vBase = value;
            }
        }

        public double VAltura
        {
            get
            {
                return vAltura;
            }

            set
            {
                vAltura = value;
            }
        }

        public String getNome()
        {
            return "Paralelogramo";
        }

        public override double getArea()
        {
            return this.VBase * this.VAltura;
        }
        public override double getPerimetro()
        {
            return 2 * (this.Lado1 + this.Lado2);
        }
        public override Image getImage()
        {
            return Properties.Resources.paralelogramo;
        }
        public override String ToString()
        {
            return "O Paralelogramo tem lados: " + this.Lado1.ToString() + " e " + this.Lado2.ToString() + ". Base: " + this.VBase.ToString() + " e Altura: " + this.VAltura.ToString();
        }
        public Boolean Equals(Paralelogramo par)
        {
            Boolean retorno = false;

            if (this.Lado1 == par.Lado1 && this.Lado2 == par.Lado2 && this.VBase == par.VBase && this.VAltura == par.VAltura && this.NroLados == par.NroLados)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
