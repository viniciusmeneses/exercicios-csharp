using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPoligono
{
    public partial class frmMostra : Form
    {
        private Circulo circulo;

        private Retangulo quadrado;
        private Retangulo retangulo;

        private Triangulo trianguloIso;
        private Triangulo trianguloEsc;
        private Triangulo trianguloEqui;

        private Paralelogramo paralelogramo;

        public frmMostra()
        {
            InitializeComponent();
            limpaInfos();

            circulo = new Circulo(5);

            quadrado = new Retangulo(3, 3);
            retangulo = new Retangulo(7, 2);

            trianguloIso = new Triangulo(10, 4, 10, 4, 8);
            trianguloEsc = new Triangulo(8, 5, 7, 5, 7);
            trianguloEqui = new Triangulo(3, 3, 3, 3, 3);

            paralelogramo = new Paralelogramo(5, 6, 5, 8);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaInfos();
        }

        private void cmbFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selecionado = cmbFigura.Text;

            if(selecionado == "Círculo")
            {
                this.moveObjetoTela(circulo);
                this.mostraLabels();
            }
            else if(selecionado == "Quadrado")
            {
                this.moveObjetoTela(quadrado);
                this.mostraLabels();
            }
            else if(selecionado == "Retângulo")
            {
                this.moveObjetoTela(retangulo);
                this.mostraLabels();
            }
            else if(selecionado == "Triângulo Isóceles")
            {
                this.moveObjetoTela(trianguloIso);
                this.mostraLabels();
            }
            else if(selecionado == "Triângulo Escaleno")
            {
                this.moveObjetoTela(trianguloEsc);
                this.mostraLabels();
            }
            else if(selecionado == "Triângulo Equilátero")
            {
                this.moveObjetoTela(trianguloEqui);
                this.mostraLabels();
            }
            else if(selecionado == "Paralelogramo")
            {
                this.moveObjetoTela(paralelogramo);
                this.mostraLabels();
            }
        }

        private void moveObjetoTela(Poligono pol)
        {
            lblExibeArea.Text = pol.getArea().ToString();
            lblExibePerimetro.Text = pol.getPerimetro().ToString();
            lblToString.Text = pol.ToString();
            picImagem.Image = pol.getImage();
        }

        private void mostraLabels()
        {
            this.lblArea.Visible = true;
            this.lblPerimetro.Visible = true;
        }
        private void limpaInfos()
        {
            this.lblExibeArea.Text = "";
            this.lblExibePerimetro.Text = "";
            this.picImagem.Image = null;
            this.lblToString.Text = "";
            this.lblArea.Visible = false;
            this.lblPerimetro.Visible = false;
            this.cmbFigura.SelectedIndex = -1;
        }
    }
}
