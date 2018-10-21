using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace prjJogoLuta
{
    public class Arqueiro : Personagem
    {
        public Arqueiro() : base()
        {
            this.Imagem = Properties.Resources.arqueiro;
        }

        public Arqueiro(int ataque, int defesa, int vida, int agilidade, int experiencia, int nivel, String somArma, String somPasso) : base(ataque, defesa, vida, agilidade, experiencia, nivel, somArma, somPasso)
        {
            this.Imagem = Properties.Resources.arqueiro;
        }

        public override void andar()
        {
            this.Vida -= 5;
            SoundPlayer somPassoP = new SoundPlayer(SomPasso);
            somPassoP.Play();
        }
        public override int atacar()
        {
            SoundPlayer somAtaque = new SoundPlayer(SomArma);
            somAtaque.Play();
            Random rnd = new Random();
            int forca = rnd.Next(0, this.Ataque);
            if (forca < this.Ataque / 3)
            {
                forca = 0;
            }
            return forca;
        }
        public override Boolean defender()
        {
            Boolean retorno = false;
            Random rnd = new Random();
            int defesa = rnd.Next(0, this.Defesa);
            if (defesa < this.Defesa / 4)
            {
                retorno = true;
            }
            return retorno;
        }
        public override void descansar()
        {
            if (this.Vida != 100)
            {
                this.Vida += 5;
            }
        }
        public override void estudar()
        {
            this.Ataque += 4;
            this.Defesa += 2;
            this.Agilidade += 5; //usar
            this.Experiencia += 100;
            this.verificarExp();
        }
    }
}
