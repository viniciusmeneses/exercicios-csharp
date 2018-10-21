using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjHeranca
{
    public partial class frmMostraJuridica : Form
    {
        public Juridica jur = new Juridica("Loja da Lulu", "(19) 4567-9871", "46.654.789/0001-52", 240000);

        public frmMostraJuridica()
        {
            InitializeComponent();
             
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.moveObjetoTela();
        }

        private void moveObjetoTela()
        {
            txtNome.Text = jur.Nome;
            txtTelefone.Text = jur.Telefone;
            txtCNPJ.Text = jur.Cnpj;
            txtFaturamentoMensal.Text = jur.FaturamentoMensal.ToString();
            txtLimiteCredido.Text = jur.getLimiteCredito().ToString();
            txtAtributos.Text = jur.toString();
        }

        private void frmMostraJuridica_Load(object sender, EventArgs e)
        {

        }
    }
}
