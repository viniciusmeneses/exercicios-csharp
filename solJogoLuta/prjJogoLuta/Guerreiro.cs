using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjJogoLuta
{
    public class Guerreiro : Personagem
    {
        public Guerreiro() : base()
        {
            this.Imagem = Properties.Resources.guerreiro;
        }

        public Guerreiro(int ataque, int defesa, int vida, int agilidade, int experiencia, int nivel, String somArma, String somPasso) : base(ataque, defesa, vida, agilidade, experiencia, nivel, somArma, somPasso)
        {
            this.Imagem = Properties.Resources.guerreiro;
        }

        public override void andar()
        {
            this.Vida -= 25;
            SoundPlayer somPassoP = new SoundPlayer(SomPasso);
            somPassoP.Play();
        }
        public override int atacar()
        {
            SoundPlayer somAtaque = new SoundPlayer(SomArma);
            somAtaque.Play();
            Random rnd = new Random();
            int forca = rnd.Next(0, this.Ataque);
            if (forca < this.Ataque / 1.50)
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
            if (defesa < this.Defesa / 2)
            {
                retorno = true;
            }
            return retorno;
        }
        public override void descansar()
        {
            if(this.Vida != 200)
            {
                this.Vida += 20;
            }
        }
        public override void estudar()
        {
            this.Ataque += 2;
            this.Defesa += 5;
            this.Agilidade += 1;
            this.Experiencia += 100;
            this.verificarExp();
        }
    }
}
