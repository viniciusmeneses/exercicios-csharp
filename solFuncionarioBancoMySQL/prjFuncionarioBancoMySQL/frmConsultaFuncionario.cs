using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjFuncionarioBancoMySQL
{
    public partial class frmConsultaFuncionario : Form
    {
        public frmConsultaFuncionario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (mtbCPFFuncionario.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF corretamente.", "Erro no Campo CPF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbCPFFuncionario.Focus();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
