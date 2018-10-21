using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace prjJogoLuta
{
    public class Mago : Personagem
    {
        public Mago() : base()
        {
            this.Imagem = Properties.Resources.mago;
        }

        public Mago(int ataque, int defesa, int vida, int agilidade, int experiencia, int nivel, String somArma, String somPasso) : base(ataque, defesa, vida, agilidade, experiencia, nivel, somArma, somPasso)
        {
            this.Imagem = Properties.Resources.mago;
        }

        public override void andar()
        {
            SoundPlayer somPassoP = new SoundPlayer(SomPasso);
            somPassoP.Play();
        }
        public override int atacar()
        {
            SoundPlayer somAtaque = new SoundPlayer(SomArma);
            somAtaque.Play();
            Random rnd = new Random();
            int forca = rnd.Next(0, this.Ataque);
            if (forca < this.Ataque / 4)
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
            if (defesa < this.Defesa / 5)
            {
                retorno = true;
            }
            return retorno;
        }
        public override void descansar()
        {
            if (this.Vida != 100)
            {
                this.Vida += 2;
            }
        }
        public override void estudar()
        {
            this.Ataque += 6;
            this.Defesa += 1;
            this.Agilidade += 2; //usar
            this.Experiencia += 100;
            this.verificarExp();
        }
    }
}
