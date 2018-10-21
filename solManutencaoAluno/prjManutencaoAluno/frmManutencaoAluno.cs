using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjManutencaoAluno
{
    public partial class frmManutencaoAluno : Form
    {
        private Aluno alu;
        private AlunoBD aluBD;
        private String operacao;

        public frmManutencaoAluno()
        {
            InitializeComponent();
            alu = new Aluno();
            aluBD = new AlunoBD();
            HabilitaCampos(false);
            HabilitaBotoes(true);
        }

        private void frmManutencaoAluno_Load(object sender, EventArgs e)
        {

        }


       private Boolean consisteCampos()
        {
            Boolean retorno = false;
            Int32 convertidoInt32;
            DateTime convertidoDT;

            if (Int32.TryParse(txtRegistro.Text, 
                out convertidoInt32)==false)
            {
                MessageBox.Show("Preencha o campo Registro com números.");
                txtRegistro.Focus();
                
            }
            else
            {
                if (txtNome.Text.ToString().Trim().Length < 6)
                {
                    MessageBox.Show("Preencha o campo Nome.");
    
                    txtNome.Focus();

                }
                else
                {
                    if (mtbCPF.Text.ToString().Length < 14)
                    {
                        MessageBox.Show("Preencha o campo CPF.");
                        mtbCPF.Focus();
                    }
                    else
                    {
                        if (DateTime.TryParse(mtbDataNascimento.Text,out convertidoDT) == false)
                        {
                            MessageBox.Show("Preencha o campo Data de Nascimento.");
                            mtbDataNascimento.Focus();
                        }
                        else
                        {
                            if (mtbTelefone.Text.ToString().Length != 14)
                            {
                                MessageBox.Show("Preencha o campo Telefone.");
                                mtbTelefone.Focus();
                            }
                            else
                            {
                                if (txtEmail.Text.ToString().Length < 7 ||
                                    txtEmail.Text.ToString().Contains("@")==false ||
                                    txtEmail.Text.ToString().Contains(".") == false )
                                {
                                    MessageBox.Show("Preencha o campo email.");
                                    txtEmail.Focus();
                                }
                                else
                                {
                                    retorno = true;
                                }

                            }

                        }

                    }

                }

            }

            return retorno;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirma a "+operacao+" do Aluno ?",
                                                    "Confirmação da "+operacao+".",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                if (consisteCampos())
                {
                    MoveTelaObjeto();
                    if (operacao.Equals("Inclusão"))
                    {
                        aluBD.inclui(alu);
                        LimpaCampos();
                        txtRegistro.Focus();
                    }
                    else
                    {
                        if(operacao.Equals("Alteração")) {
                            aluBD.altera(alu);
                        }
                        HabilitaCampos(false);
                        HabilitaBotoes(true);
                    }
                }
            }
        }

        private void MoveTelaObjeto()
        {
            alu.Registro = Convert.ToInt32(txtRegistro.Text.ToString());
            alu.Nome = txtNome.Text.ToString();
            alu.Cpf = mtbCPF.Text.ToString();
            alu.DataNascimento = Convert.ToDateTime(mtbDataNascimento.Text.ToString());
            //IF de linha sintaxe <condição> ? <Ação se verdadeiro> : <Ação se falso>
            alu.Sexo = radMasculino.Checked == true ? "M" : "F";
            alu.Telefone = mtbTelefone.Text.ToString();
            alu.Email = txtEmail.Text.ToString();
            alu.Situacao = cmbSituacao.Text.ToString();
     
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            HabilitaCampos(true);
            LimpaCampos();
            HabilitaBotoes(false);
            txtRegistro.Focus();
            operacao = "Inclusão";
        }

        private void HabilitaCampos(Boolean op)
        {
            txtRegistro.Enabled = op;
            txtNome.Enabled = op;
            mtbCPF.Enabled = op;
            mtbDataNascimento.Enabled = op;
            radMasculino.Enabled = op;
            radFeminino.Enabled = op;
            mtbTelefone.Enabled = op;
            txtEmail.Enabled = op;
            cmbSituacao.Enabled = op;
        }

        private void HabilitaBotoes(Boolean op)
        {
            btnIncluir.Enabled = op;
            btnAlterar.Enabled = op;
            btnExcluir.Enabled = op;
            btnConsultar.Enabled = op;

            btnConfirmar.Enabled = !op;
            btnCancelar.Enabled = !op;
        }

        private void LimpaCampos()
        {
            txtRegistro.Clear();
            txtNome.Clear();
            mtbCPF.Clear();
            mtbDataNascimento.Clear();
            mtbTelefone.Clear();
            txtEmail.Clear();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            HabilitaCampos(false);
            HabilitaBotoes(true);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Int32 convertido;

            if (Int32.TryParse(txtRegistro.Text, out convertido) == false || convertido < 1)
                MessageBox.Show("Não há aluno a ser alterado.\n Consulte o Aluno a ser alterado.");
            else
            {
                HabilitaCampos(true);
                txtRegistro.Enabled = false;
                HabilitaBotoes(false);
                operacao = "Alteração";
            }
        }

        private void MoveObjetoTela()
        {
            txtRegistro.Text = alu.Registro.ToString();
            txtNome.Text = alu.Nome;
            mtbCPF.Text = alu.Cpf;
            mtbDataNascimento.Text = alu.DataNascimento.ToString();
            if (alu.Sexo.Equals("M"))
                radMasculino.Checked = true;
            else
                radFeminino.Checked = true;
            mtbTelefone.Text = alu.Telefone;
            txtEmail.Text = alu.Email;
            cmbSituacao.Text = alu.Situacao;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MoveObjetoTela();
        }

    }
}
