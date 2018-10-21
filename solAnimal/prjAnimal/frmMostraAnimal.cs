using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAnimal
{
    public partial class frmMostraAnimal : Form
    {
        Lobo lobo;
        Tigre tigre;
        Galinha galinha;

        public frmMostraAnimal()
        {
            InitializeComponent();
            lobo = new Lobo("Lobo");
            tigre = new Tigre("Tigre");
            galinha = new Galinha("Galinha");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(cmbEscolhaAnimal.Text != "")
            {
                Animal escolhido = tigre;
                if (cmbEscolhaAnimal.Text == "Tigre")
                {
                    escolhido = tigre;
                }
                if (cmbEscolhaAnimal.Text == "Galinha")
                {
                    escolhido = galinha;
                }
                if (cmbEscolhaAnimal.Text == "Lobo")
                {
                    escolhido = lobo;
                }

                txtNome.Text = escolhido.Nome;
                txtRegiao.Text = escolhido.getRegiao();
                txtHabitat.Text = escolhido.getHabitat();
                imgFoto.Image = escolhido.getFoto();

            }
            else
            {
                MessageBox.Show("Selecione um animal!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imgFoto_Click(object sender, EventArgs e)
        {

        }

        private void frmMostraAnimal_Load(object sender, EventArgs e)
        {

        }
    }
}
