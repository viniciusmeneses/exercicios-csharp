using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAnimal
{
    class Galinha : Animal
    {
        public Galinha():base("Galinha")
        {

        }

        public Galinha(String nome):base(nome)
        {

        }

        public Boolean Equals(Galinha galinha)
        {
            Boolean retorno = false;
            if (this.Nome.Equals(galinha.Nome))
            {
                retorno = true;
            }
            return retorno;
        }
        //Retorna a imagem
        public override Image getFoto()
        {
            //Pra importar a imagem, vai no picturebox, importar e seleciona elas.

            //Pega a imagem importada do objeto Properties
            //Propriedade Resoures
            //E o nome da imagem importada vai aparecer
            return Properties.Resources.galinha;
        }
        public override String getHabitat()
        {
            return "Calor";
        }
        public override string getRegiao()
        {
            return "Urbano";
        }
    }
}
