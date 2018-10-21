using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAnimal
{
    class Lobo:Animal
    {
        public Lobo():base()
        {

        }
        public Lobo(String nome):base(nome)
        {

        }

        public Boolean Equals(Lobo lobo)
        {
            Boolean retorno = false;
            if (this.Nome.Equals(lobo.Nome))
            {
                retorno = true;
            }
            return retorno;
        }
        public override Image getFoto()
        {
            return Properties.Resources.lobo;   
        }
        public override String getHabitat()
        {
            return "Frio";
        }
        public override string getRegiao()
        {
            return "Sul";
        }

    }
}
