using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPoligono
{
    class Triangulo : Poligono
    {
        private double lado1;
        private double lado2;
        private double lado3;
        private double vBase;
        private double vAltura;

        public Triangulo()
        {
            this.Lado1 = 0;
            this.Lado2 = 0;
            this.Lado3 = 0;
            this.VBase = 0;
            this.VAltura = 0;
            this.NroLados = 3;
        }
        public Triangulo(double lado1, double lado2, double lado3, double vBase, double vAltura)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;
            this.VBase = vBase;
            this.VAltura = vAltura;
            this.NroLados = 3;
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

        public double Lado3
        {
            get
            {
                return lado3;
            }

            set
            {
                lado3 = value;
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

        public Boolean eTriangulo()
        {
            Boolean retorno = false;

            if (this.Lado1 < (this.Lado2 + this.Lado3) && this.Lado2 < (this.Lado1 + this.Lado3) && this.Lado3 < (this.Lado1 + this.Lado2))
            {
                retorno = true;
            }

            return retorno;
        }

        public String getNome()
        {
            //String retorno = "";
            StringBuilder builder = new StringBuilder();

            if (this.eTriangulo())
            {
                if (this.Lado1 == this.Lado2 && this.Lado1 == this.Lado3 && this.Lado2 == this.Lado3)
                {
                     builder.Append("Triângulo Equilátero");
                }
                else
                {
                    if (this.Lado1 == this.Lado2 || this.Lado1 == this.Lado3 || this.Lado2 == this.lado3)
                    {
                        builder.Append("Triângulo Isóceles");
                    }
                    else
                    {
                        builder.Append("Triângulo Escaleno");
                    }
                }
            }
            else
            {
                builder.Append("Os lados: ");
                builder.Append(this.Lado1.ToString());
                builder.Append(", ");
                builder.Append(this.Lado2.ToString());
                builder.Append(", ");
                builder.Append(this.Lado3.ToString());
                builder.Append(" não formam um triângulo.");
            }
            return builder.ToString();
            //return retorno;
        }

        public override double getArea()
        {
            double retorno = 0;

            if (this.eTriangulo())
            {
                retorno = (this.VBase * this.VAltura) / 2;
            }

            return retorno;
        }
        public override double getPerimetro()
        {
            double retorno = 0;

            if (this.eTriangulo())
            {
                retorno = this.Lado1 + this.Lado2 + this.Lado3;
            }

            return retorno;
        }
        public override Image getImage()
        {
            String tipo = this.getNome();
            Image retorno = null;
            if (tipo.Equals("Triângulo Equilátero"))
            {
                retorno = Properties.Resources.triangulo_equilatero;
            }
            else if (tipo.Equals("Triângulo Isóceles"))
            {
                retorno = Properties.Resources.triangulo_isoceles;
            }
            else if(tipo.Equals("Triângulo Escaleno"))
            {
                retorno = Properties.Resources.triangulo_escaleno;
            }
            return retorno;
        }
        public override String ToString()
        {
            return "O " + this.getNome().ToString() + " tem lados: " + this.Lado1.ToString() + ", " + this.Lado2.ToString() + " e " + this.Lado3.ToString() + ". Base: " + this.VBase.ToString() + " e Altura: " + this.VAltura.ToString();
        }
        public Boolean Equals(Triangulo tri)
        {
            Boolean retorno = false;

            if (this.Lado1 == tri.Lado1 && this.Lado2 == tri.Lado2 && this.Lado3 == tri.Lado3 && this.VBase == tri.VBase && this.VAltura == tri.VAltura && this.NroLados == tri.NroLados)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
