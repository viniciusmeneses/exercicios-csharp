using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAnimal
{
    class Tigre : Animal
    {
        public Tigre():base("Tigre")
        {

        }

        public Tigre(String nome) : base(nome)
        {

        }

        public Boolean Equals(Tigre tigre)
        {
            Boolean retorno = false;
            if (this.Nome.Equals(tigre.Nome))
            {
                retorno = true;
            }
            return retorno;
        }
        public override Image getFoto()
        {
            return Properties.Resources.tigre;
        }
        public override String getHabitat()
        {
            return "Quente";
        }
        public override string getRegiao()
        {
            return "Savana";
        }
    }
}
