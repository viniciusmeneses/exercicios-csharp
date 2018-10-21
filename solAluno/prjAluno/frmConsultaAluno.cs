using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAluno
{
    public partial class frmConsultaAluno : Form
    {
        public frmConsultaAluno()
        {
            InitializeComponent();
        }

        private void lblConsultaAluno_Click(object sender, EventArgs e)
        {

        }

        private void btnOkConsulta_Click(object sender, EventArgs e)
        {
            Int32 convertidoInt32;

            if (txtRegistroConsulta.Text.ToString().Trim().Length == 0 && mtbCpfConsulta.Text.ToString().Trim().Length != 14)
            {
                MessageBox.Show("Preencha o campo Registro OU o campo CPF", "Erro no Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegistroConsulta.Focus();
            }
            else
            {
                if (txtRegistroConsulta.Text.ToString().Trim().Length > 0 && mtbCpfConsulta.Text.ToString().Trim().Length == 14)
                {
                    MessageBox.Show("Preencha o campo Registro OU o campo CPF", "Erro no Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegistroConsulta.Focus();
                }
                else
                {
                    if (txtRegistroConsulta.Text.ToString().Trim().Length > 0 && Int32.TryParse(txtRegistroConsulta.Text, out convertidoInt32) == false)
                    {
                        MessageBox.Show("Preencha o campo Registro com números.", "Erro no Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtRegistroConsulta.Focus();
                    }
                    else
                    {
                        //Mensagem para o formulario chamador que foi apertado o botao OK
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void btnCancelarConsulta_Click(object sender, EventArgs e)
        {
            //Mensagem para o formulario chamador que foi apertado o botao CANCELAR
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmConsultaAluno_Load(object sender, EventArgs e)
        {

        }
    }
}
