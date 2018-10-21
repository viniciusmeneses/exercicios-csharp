using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace prjJogoLuta
{
    public class Lutador : Personagem
    {
        public Lutador() : base()
        {
            this.Imagem = Properties.Resources.lutador;
        }

        public Lutador(int ataque, int defesa, int vida, int agilidade, int experiencia, int nivel, String somArma, String somPasso) : base(ataque, defesa, vida, agilidade, experiencia, nivel, somArma, somPasso)
        {
            this.Imagem = Properties.Resources.lutador;
        }
        public override void andar()
        {
            this.Vida -= 15;
            SoundPlayer somPassoP = new SoundPlayer(SomPasso);
            somPassoP.Play();
        }
        public override int atacar()
        {
            SoundPlayer somAtaque = new SoundPlayer(SomArma);
            somAtaque.Play();
            Random rnd = new Random();
            int forca = rnd.Next(0, this.Ataque);
            if (forca < this.Ataque / 2)
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
            if (defesa < this.Defesa / 3)
            {
                retorno = true;
            }
            return retorno;
        }
        public override void descansar()
        {
            if (this.Vida != 100)
            {
                this.Vida += 10;
            }
        }
        public override void estudar()
        {
            this.Ataque += 3;
            this.Defesa += 3;
            this.Agilidade += 1; //usar
            this.Experiencia += 100;
            this.verificarExp();
        }
    }
}
