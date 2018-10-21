using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPoligono
{
    abstract class Poligono
    {
        private int nroLados;

        public int NroLados
        {
            get
            {
                return nroLados;
            }

            set
            {
                nroLados = value;
            }
        }

        public String getNome()
        {
            String retorno = "";
            if (this.NroLados == 1)
            {
                retorno = "Círculo";
            }
            else if (this.NroLados == 3)
            {
                retorno = "Triângulo";
            }
            else if (this.NroLados == 4)
            {
                retorno = "Retângulo";
            }
            return retorno;
        }
        public abstract double getArea();
        public abstract double getPerimetro();
        public abstract Image getImage();
        public abstract override String ToString();
    }
}
