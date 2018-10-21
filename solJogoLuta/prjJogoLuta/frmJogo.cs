using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjJogoLuta
{
    public partial class frmJogo : Form
    {
        Guerreiro guerreiro = new Guerreiro(1, 1, 200, 1, 1, 1, @"E:\Informática\3 Módulo\DS-2\solJogoLuta\prjJogoLuta\Resources\GuerreiroAtaque.wav", @"E:\Informática\3 Módulo\DS-2\solJogoLuta\prjJogoLuta\Resources\PassosGuerreiro.wav");
        Arqueiro arqueiro = new Arqueiro(1, 1, 100, 1, 1, 1, @"E:\Informática\3 Módulo\DS-2\solJogoLuta\prjJogoLuta\Resources\ArqueiroAtaque.wav", @"E:\Informática\3 Módulo\DS-2\solJogoLuta\prjJogoLuta\Resources\PassosArqueiro.wav");
        Lutador lutador = new Lutador(1, 1, 150, 1, 1, 1, @"E:\Informática\3 Módulo\DS-2\solJogoLuta\prjJogoLuta\Resources\LutadorAtaque.wav", @"E:\Informática\3 Módulo\DS-2\solJogoLuta\prjJogoLuta\Resources\PassosLutador.wav");
        Mago mago = new Mago(1, 1, 75, 1, 1, 1, @"E:\Informática\3 Módulo\DS-2\solJogoLuta\prjJogoLuta\Resources\MagoAtaque.wav", @"E:\Informática\3 Módulo\DS-2\solJogoLuta\prjJogoLuta\Resources\PassosMago.wav");

        public frmJogo()
        {
            InitializeComponent();
            habilitaBotoes(false);
            lblPerVivosResult.Text = Personagem.PersonagensVivos.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbPersonagens.Text == "Guerreiro")
            {
                guerreiro.estudar();
                moveObjetoTela(guerreiro);
            }
            else if (cmbPersonagens.Text == "Arqueiro")
            {
                arqueiro.estudar();
                moveObjetoTela(arqueiro);
            }
            else if (cmbPersonagens.Text == "Lutador")
            {
                lutador.estudar();
                moveObjetoTela(lutador);
            }
            else
            {
                mago.estudar();
                moveObjetoTela(mago);
            }
            timer.Interval = 3000;
            timer.Tick += timer_Tick;
            timer.Start();
            btnEstudar.Enabled = false;
        }

        private void cbmPersonagens_SelectedValueChanged(object sender, EventArgs e)
        {
            habilitaBotoes(true);
            if (cmbPersonagens.Text == "Guerreiro")
            {
                moveObjetoTela(guerreiro);
            }
            else if(cmbPersonagens.Text == "Arqueiro")
            {
                moveObjetoTela(arqueiro);
            }
            else if (cmbPersonagens.Text == "Lutador")
            {
                moveObjetoTela(lutador);
            }
            else
            {
                moveObjetoTela(mago);
            }
        }
        private void moveObjetoTela(Personagem per)
        {
            pbImagem.Image = per.Imagem;
            txtAtq.Text = per.Ataque.ToString();
            txtDef.Text = per.Defesa.ToString();
            txtAgi.Text = per.Agilidade.ToString();
            txtExp.Text = per.Experiencia.ToString() + "/" + (per.Nivel*1000).ToString();
            if (cmbPersonagens.Text == "Guerreiro")
            {
                txtVida.Text = per.Vida.ToString() + "/200";
            }
            else if (cmbPersonagens.Text == "Arqueiro")
            {
                txtVida.Text = per.Vida.ToString() + "/100";
            }
            else if (cmbPersonagens.Text == "Lutador")
            {
                txtVida.Text = per.Vida.ToString() + "/150";
            }
            else
            {
                txtVida.Text = per.Vida.ToString() + "/75";
            }
            txtNivel.Text = per.Nivel.ToString();

            verificarVidaNivel();

        }

        private void verificarVidaNivel()
        {
            if (cmbPersonagens.Text == "Guerreiro")
            {
                if (guerreiro.Vida == 200)
                {
                    btnDescansar.Enabled = false;
                }
                else
                {
                    btnDescansar.Enabled = true;
                }
                if(guerreiro.Nivel == 10)
                {
                    btnEstudar.Enabled = false;
                }
                else
                {
                    btnEstudar.Enabled = true;
                }
            }
            else if (cmbPersonagens.Text == "Arqueiro")
            {
                if (arqueiro.Vida == 100)
                {
                    btnDescansar.Enabled = false;
                }
                else
                {
                    btnDescansar.Enabled = true;
                }
                if (arqueiro.Nivel == 10)
                {
                    btnEstudar.Enabled = false;
                }
                else
                {
                    btnEstudar.Enabled = true;
                }
            }
            else if (cmbPersonagens.Text == "Lutador")
            {
                if (lutador.Vida == 150)
                {
                    btnDescansar.Enabled = false;
                }
                else
                {
                    btnDescansar.Enabled = true;
                }
                if (lutador.Nivel == 10)
                {
                    btnEstudar.Enabled = false;
                }
                else
                {
                    btnEstudar.Enabled = true;
                }
            }
            else
            {
                if (mago.Vida == 75)
                {
                    btnDescansar.Enabled = false;
                }
                else
                {
                    btnDescansar.Enabled = true;
                }
                if (mago.Nivel == 10)
                {
                    btnEstudar.Enabled = false;
                }
                else
                {
                    btnEstudar.Enabled = true;
                }
            }
        }

        private void lblExperiencia_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            verificarVidaNivel();
            timer.Stop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cmbPersonagens.Text == "Guerreiro")
            {
                guerreiro.descansar();
                moveObjetoTela(guerreiro);
            }
            else if (cmbPersonagens.Text == "Arqueiro")
            {
                arqueiro.descansar();
                moveObjetoTela(arqueiro);
            }
            else if (cmbPersonagens.Text == "Lutador")
            {
                lutador.descansar();
                moveObjetoTela(lutador);
            }
            else
            {
                mago.descansar();
                moveObjetoTela(mago);
            }
            timer.Interval = 2000;
            timer.Tick += timer_Tick;
            timer.Start();
            btnDescansar.Enabled = false;
        }
        public void habilitaBotoes(Boolean p)
        {
            this.btnLutar.Enabled = p;
            this.btnDescansar.Enabled = p;
            this.btnEstudar.Enabled = p;
        }

        private void btnAndar_Click(object sender, EventArgs e)
        {
            frmLutar frmLutar = new frmLutar(guerreiro, arqueiro, lutador, mago, cmbPersonagens.Text);

            DialogResult result = frmLutar.ShowDialog();

            if(result == DialogResult.OK)
            {
                guerreiro = frmLutar.Gue;
                arqueiro = frmLutar.Arq;
                mago = frmLutar.Mag;
                lutador = frmLutar.Lut;
                if (guerreiro != null)
                {
                    if (guerreiro.Vida <= 0)
                    {
                        guerreiro = null;
                        cmbPersonagens.Items.RemoveAt(0);
                        Personagem.PersonagensVivos--;
                    }
                }
                if (arqueiro != null)
                {
                    if (arqueiro.Vida <= 0)
                    {
                        arqueiro = null;
                        cmbPersonagens.Items.RemoveAt(1);
                        Personagem.PersonagensVivos--;
                    }
                }
                if (lutador != null)
                {
                    if (lutador.Vida <= 0)
                    {
                        lutador = null;
                        cmbPersonagens.Items.RemoveAt(2);
                        Personagem.PersonagensVivos--;
                    }
                }
                if (mago != null)
                {
                    if (mago.Vida <= 0)
                    {
                        mago = null;
                        cmbPersonagens.Items.RemoveAt(3);
                        Personagem.PersonagensVivos--;
                    }
                }
                //GC.Collect();
                lblPerVivosResult.Text = Personagem.PersonagensVivos.ToString();

                if(cmbPersonagens.Items.Count <= 1)
                {
                    MessageBox.Show("Fim de jogo!", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                if (cmbPersonagens.Text == "Guerreiro")
                {
                    moveObjetoTela(guerreiro);
                }
                else if (cmbPersonagens.Text == "Arqueiro")
                {
                    moveObjetoTela(arqueiro);
                }
                else if (cmbPersonagens.Text == "Lutador")
                {
                    moveObjetoTela(lutador);
                }
                else
                {
                    moveObjetoTela(mago);
                }
            }

        }

        private void lblNivel_Click(object sender, EventArgs e)
        {

        }

        private void lblAtaque_Click(object sender, EventArgs e)
        {

        }

        private void frmJogo_Load(object sender, EventArgs e)
        {

        }
    }
}
