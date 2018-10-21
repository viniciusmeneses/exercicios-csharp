using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDupla
{
    public partial class frmConsultaCarro : Form
    {
        public frmConsultaCarro()
        {
            InitializeComponent();
        }

        private void frmConsultaCarro_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarConsulta_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOkConsulta_Click(object sender, EventArgs e)
        {
            Int16 convertido;

            if (Int16.TryParse(txtRegistroConsulta.Text, out convertido) == false)
            {
                MessageBox.Show("Preencha o campo Registro do Carro corretamente.");
                txtRegistroConsulta.Focus();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
