using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace prjJogoLuta
{
    public abstract class Personagem
    {
        private static int personagensVivos;
        private int ataque;
        private int defesa;
        private int vida;
        private int agilidade;
        private int experiencia;
        private int nivel;
        private Image imagem;
        private String somArma;
        private String somPasso;

        public int Ataque
        {
            get
            {
                return ataque;
            }

            set
            {
                ataque = value;
            }
        }

        public int Defesa
        {
            get
            {
                return defesa;
            }

            set
            {
                defesa = value;
            }
        }

        public int Vida
        {
            get
            {
                return vida;
            }

            set
            {
                vida = value;
            }
        }

        public int Agilidade
        {
            get
            {
                return agilidade;
            }

            set
            {
                agilidade = value;
            }
        }

        public int Experiencia
        {
            get
            {
                return experiencia;
            }

            set
            {
                experiencia = value;
            }
        }

        public int Nivel
        {
            get
            {
                return nivel;
            }

            set
            {
                nivel = value;
            }
        }

        public Image Imagem
        {
            get
            {
                return imagem;
            }

            set
            {
                imagem = value;
            }
        }

        public string SomArma
        {
            get
            {
                return somArma;
            }

            set
            {
                somArma = value;
            }
        }

        public string SomPasso
        {
            get
            {
                return somPasso;
            }

            set
            {
                somPasso = value;
            }
        }

        public static int PersonagensVivos
        {
            get
            {
                return Personagem.personagensVivos;
            }
            set
            {
                personagensVivos = value;
            }
        }

        public Personagem()
        {
            this.ataque = 0;
            this.defesa = 0;
            this.vida = 0;
            this.agilidade = 0;
            this.experiencia = 0;
            this.nivel = 0;
            this.imagem = null;
            this.somArma = "";
            this.somPasso = "";
            personagensVivos++;
        }

        public Personagem(int ataque, int defesa, int vida, int agilidade, int experiencia, int nivel, string somArma, string somPasso)
        {
            this.ataque = ataque;
            this.defesa = defesa;
            this.vida = vida;
            this.agilidade = agilidade;
            this.experiencia = experiencia;
            this.nivel = nivel;
            this.somArma = somArma;
            this.somPasso = somPasso;
            personagensVivos++;
        }

        ~Personagem()
        {
            personagensVivos--;
        }

        public abstract int atacar();
        public abstract Boolean defender();
        public abstract void descansar();
        public abstract void andar();
        public abstract void estudar();

        public override String ToString()
        {
            return "Ataque: " + this.ataque.ToString() + "\nDefesa: " + this.defesa.ToString() + "\nVida: " + this.vida.ToString() + "\nAgilidade: " + this.agilidade.ToString() + "\nExperiência: " + this.experiencia.ToString() + "\nNivel: " + this.nivel.ToString() + "\nSom dos Passos: " + this.somPasso + "\nSom da Arma: " + this.somArma;
        }

        public Boolean Equals(Personagem per)
        {
            Boolean retorno = false;
            if (this.Ataque == per.Ataque && this.Defesa == per.Defesa && this.Vida == per.Vida && this.Agilidade == per.Agilidade && this.Experiencia == per.Experiencia && this.Nivel == per.Nivel && this.Imagem.Equals(per.Imagem) && this.SomPasso.Equals(per.SomPasso) && this.SomArma.Equals(per.SomArma))
            {
                retorno = true;
            }
            return retorno;
        }

        public Int64 verificarExp()
        {
            Int64 limite = this.Nivel * 1000;
            if (limite == this.Experiencia)
            {
                this.Nivel++;
                this.Experiencia = 0;
            }

            return limite;
        }

    }
}
