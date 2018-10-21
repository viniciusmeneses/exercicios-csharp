using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjJogoLuta
{
    public partial class frmLutar : Form
    {
        private Guerreiro gue;
        private Arqueiro arq;
        private Lutador lut;
        private Mago mag;
        private string per;

        String oponente = "";
        Random rnd = new Random();

        public Guerreiro Gue
        {
            get
            {
                return gue;
            }

            set
            {
                gue = value;
            }
        }

        public Arqueiro Arq
        {
            get
            {
                return arq;
            }

            set
            {
                arq = value;
            }
        }

        public Lutador Lut
        {
            get
            {
                return lut;
            }

            set
            {
                lut = value;
            }
        }

        public Mago Mag
        {
            get
            {
                return mag;
            }

            set
            {
                mag = value;
            }
        }

        public string Per
        {
            get
            {
                return per;
            }

            set
            {
                per = value;
            }
        }

        public frmLutar(Guerreiro gue, Arqueiro arq, Lutador lut, Mago mag, String per)
        {
            this.gue = gue;
            this.arq = arq;
            this.lut = lut;
            this.mag = mag;
            this.per = per;
            InitializeComponent();
            moveObjetoTela();
            procurarOponente();
        }



        private void frmLutar_Load(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void procurarOponente()
        {
            int numero = rnd.Next(1, 4);
            if (per == "Guerreiro")
            {
                if(numero == 1)
                {
                    moveObjetoTelaOponente(arq, "Arqueiro");
                }
                if(numero == 2)
                {
                    moveObjetoTelaOponente(lut, "Lutador");
                }
                if(numero == 3)
                {
                    moveObjetoTelaOponente(mag, "Mago");
                }
            }
            else if(per == "Lutador")
            {
                if (numero == 1)
                {
                    moveObjetoTelaOponente(gue, "Guerreiro");
                }
                if (numero == 2)
                {
                    moveObjetoTelaOponente(arq, "Arqueiro");
                }
                if (numero == 3)
                {
                    moveObjetoTelaOponente(mag, "Mago");
                }
            }
            else if (per == "Arqueiro")
            {
                if (numero == 1)
                {
                    moveObjetoTelaOponente(gue, "Guerreiro");
                }
                if (numero == 2)
                {
                    moveObjetoTelaOponente(lut, "Lutador");
                }
                if (numero == 3)
                {
                    moveObjetoTelaOponente(mag, "Mago");
                }
            }
            else
            {
                if (numero == 1)
                {
                    moveObjetoTelaOponente(arq, "Arqueiro");
                }
                if (numero == 2)
                {
                    moveObjetoTelaOponente(lut, "Lutador");
                }
                if (numero == 3)
                {
                    moveObjetoTelaOponente(gue, "Guerreiro");
                }
            }
        }

        private void moveObjetoTela()
        {
            if (per == "Guerreiro")
            {
                if (gue.Vida <= 0)
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Seu guerreiro morreu. :(", "Morreu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    pbImagem.Image = gue.Imagem;
                    txtAtq.Text = gue.Ataque.ToString();
                    txtDef.Text = gue.Defesa.ToString();
                    txtAgi.Text = gue.Agilidade.ToString();
                    txtExp.Text = gue.Experiencia.ToString() + "/" + (gue.Nivel * 1000).ToString();
                    txtVida.Text = gue.Vida.ToString() + "/200";
                    txtNivel.Text = gue.Nivel.ToString();
                }
            }
            else if (per == "Lutador")
            {
                if (lut.Vida <= 0)
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Seu lutador morreu. :(", "Morreu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    pbImagem.Image = lut.Imagem;
                    txtAtq.Text = lut.Ataque.ToString();
                    txtDef.Text = lut.Defesa.ToString();
                    txtAgi.Text = lut.Agilidade.ToString();
                    txtExp.Text = lut.Experiencia.ToString() + "/" + (lut.Nivel * 1000).ToString();
                    txtVida.Text = lut.Vida.ToString() + "/150";
                    txtNivel.Text = lut.Nivel.ToString();
                }
            }
            else if (per == "Arqueiro")
            {
                if (arq.Vida <= 0)
                {

                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Seu arqueiro morreu. :(", "Morreu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    pbImagem.Image = arq.Imagem;
                    txtAtq.Text = arq.Ataque.ToString();
                    txtDef.Text = arq.Defesa.ToString();
                    txtAgi.Text = arq.Agilidade.ToString();
                    txtExp.Text = arq.Experiencia.ToString() + "/" + (arq.Nivel * 1000).ToString();
                    txtVida.Text = arq.Vida.ToString() + "/100";
                    txtNivel.Text = arq.Nivel.ToString();
                }
            }
            else
            {
                if (mag.Vida <= 0)
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Seu mago morreu. :(", "Morreu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    pbImagem.Image = mag.Imagem;
                    txtAtq.Text = mag.Ataque.ToString();
                    txtDef.Text = mag.Defesa.ToString();
                    txtAgi.Text = mag.Agilidade.ToString();
                    txtExp.Text = mag.Experiencia.ToString() + "/" + (mag.Nivel * 1000).ToString();
                    txtVida.Text = mag.Vida.ToString() + "/75";
                    txtNivel.Text = mag.Nivel.ToString();
                }
            }
        }
        private void moveObjetoTelaOponente(Personagem per, String oponente)
        {
            this.oponente = oponente;

            if (per != null)
            {
                if (this.oponente == "Guerreiro")
                {
                    if (per.Vida <= 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Você matou o guerreiro inimigo. Parabéns!", "Ganhou!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txtVidaOponente.Text = per.Vida.ToString() + "/200";
                    }
                }
                else if (this.oponente == "Arqueiro")
                {
                    if (per.Vida <= 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Você matou o arqueiro inimigo. Parabéns!", "Ganhou!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txtVidaOponente.Text = per.Vida.ToString() + "/100";
                    }
                }
                else if (this.oponente == "Lutador")
                {
                    if (per.Vida <= 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Você matou o lutador inimigo. Parabéns!", "Ganhou!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txtVidaOponente.Text = per.Vida.ToString() + "/150";
                    }
                }
                else
                {
                    if (per.Vida <= 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Você matou o mago inimigo. Parabéns!", "Ganhou!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txtVidaOponente.Text = per.Vida.ToString() + "/75";
                    }
                }

                pbImagemOponente.Image = per.Imagem;
                txtAtqOponente.Text = per.Ataque.ToString();
                txtDefOponente.Text = per.Defesa.ToString();
                txtAgiOponente.Text = per.Agilidade.ToString();
                txtExpOponente.Text = per.Experiencia.ToString() + "/" + (per.Nivel * 1000).ToString();
                txtNivelOponente.Text = per.Nivel.ToString();
            }
            else
            {
                procurarOponente();
            }
        }

        private void btnEstudar_Click(object sender, EventArgs e)
        {
            Boolean defesa = false;
            if (this.per == "Guerreiro")
            {
                defesa = gue.defender();
                if (defesa)
                {
                    MessageBox.Show("Você defendeu o ataque do inimigo!", "Defender", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você NÃO defendeu o ataque do inimigo!", "Defender", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (this.per == "Arqueiro")
            {
                defesa = arq.defender();
                if (defesa)
                {
                    MessageBox.Show("Você defendeu o ataque do inimigo!", "Defender", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você NÃO defendeu o ataque do inimigo!", "Defender", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (this.per == "Lutador")
            {
                defesa = lut.defender();
                if (defesa)
                {
                    MessageBox.Show("Você defendeu o ataque do inimigo!", "Defender", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você NÃO defendeu o ataque do inimigo!", "Defender", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                defesa = mag.defender();
                if (defesa)
                {
                    MessageBox.Show("Você defendeu o ataque do inimigo!", "Defender", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você NÃO defendeu o ataque do inimigo!", "Defender", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            int forca = 0;
            if (defesa == false)
            {
                if (this.oponente == "Guerreiro")
                {
                    forca = gue.atacar();
                }
                else if (this.oponente == "Arqueiro")
                {
                    forca = arq.atacar();
                }
                else if (this.oponente == "Lutador")
                {
                    forca = lut.atacar();
                }
                else
                {
                    forca = mag.atacar();
                }
            }
            if (per == "Guerreiro")
            {
                gue.Vida -= forca;
            }
            else if (per == "Lutador")
            {
                lut.Vida -= forca;
            }
            else if (per == "Arqueiro")
            {
                arq.Vida -= forca;
            }
            else
            {
                mag.Vida -= forca;
            }
            moveObjetoTela();
        }

        private void btnLutar_Click(object sender, EventArgs e)
        {
            int forca = 0;
            if (this.per == "Guerreiro")
            {
                forca = gue.atacar();
                if(forca == 0)
                {
                    MessageBox.Show("Você errou o ataque!", "Atacar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você acertou o ataque!", "Atacar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (this.per == "Arqueiro")
            {
                forca = arq.atacar();
                if (forca == 0)
                {
                    MessageBox.Show("Você errou o ataque!", "Atacar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você acertou o ataque!", "Atacar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (this.per == "Lutador")
            {
                forca = lut.atacar();
                if (forca == 0)
                {
                    MessageBox.Show("Você errou o ataque!", "Atacar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você acertou o ataque!", "Atacar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                forca = mag.atacar();
                if (forca == 0)
                {
                    MessageBox.Show("Você errou o ataque!", "Atacar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você acertou o ataque!", "Atacar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (this.oponente == "Guerreiro")
            {
                gue.Vida -= forca;
                moveObjetoTelaOponente(gue, this.oponente);
            }
            else if (this.oponente == "Arqueiro")
            {
                arq.Vida -= forca;
                moveObjetoTelaOponente(arq, this.oponente);
            }
            else if (this.oponente == "Lutador")
            {
                lut.Vida -= forca;
                moveObjetoTelaOponente(lut, this.oponente);
            }
            else
            {
                mag.Vida -= forca;
                moveObjetoTelaOponente(mag, this.oponente);
            }

            moveObjetoTela();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            procurarOponente();
            if (this.per == "Guerreiro")
            {
                gue.andar();
                MessageBox.Show("Você andou pelo cenário e encontrou um novo oponente, mas perdeu 25 de vida por causa da armadura pesada.", "Andar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (this.per == "Arqueiro")
            {
                arq.andar();
                MessageBox.Show("Você voou pelo cenário e encontrou um novo oponente, mas perdeu 5 de vida por causa do vento forte.", "Andar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (this.per == "Lutador")
            {
                lut.andar();
                MessageBox.Show("Você correu pelo cenário e encontrou um novo oponente, mas perdeu 15 de vida por causa do cansaço.", "Andar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                mag.andar();
                MessageBox.Show("Você se teletransportou pelo cenário e encontrou um novo oponente, mas não perdeu vida.", "Andar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            moveObjetoTela();
        }
    }
}
