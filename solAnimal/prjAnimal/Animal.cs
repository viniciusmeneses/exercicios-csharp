using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Classe que contém o tipo Image para ser usado na PictureBox
using System.Drawing;

namespace prjAnimal
{
    abstract class Animal
    {
        private String nome;

        public Animal()
        {
            this.nome = "";
        }

        public Animal(String nome)
        {
            this.nome = nome;
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

        public abstract Image getFoto();
        public abstract String getHabitat();
        public abstract String getRegiao();
        public override String ToString()
        {
            return "Nome: " + this.nome;
        }
        public Boolean Equals(Animal anim)
        {
            Boolean retorno = false;
            if (this.Nome.Equals(anim.Nome))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
