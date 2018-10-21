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
    public partial class frmManutencaoFuncionario : Form
    {
        private Funcionario func;
        private FuncionarioBD funcBD;

        String operacao;


        public frmManutencaoFuncionario()
        {
            InitializeComponent();

            dtpDataAdmissao.MaxDate = DateTime.Now.AddDays(1);
            dtpDataAdmissao.Value = DateTime.Now;

            dtpDataDemissao.MinDate = DateTime.Now.AddDays(-1);
            dtpDataDemissao.Value = DateTime.Now;

            func = new Funcionario();
            funcBD = new FuncionarioBD();

            habilitaBotoes(true);
            habilitaCampos(false);
            habilitaDemissao(false);
            chkHabilitaDemissao.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtpDataDemissao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHabilitaDemissao.Checked)
            {
                dtpDataDemissao.Enabled = true;
            }
            else
            {
                dtpDataDemissao.Enabled = false;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            func = new Funcionario();
            habilitaCampos(true);
            habilitaBotoes(false);
            limpaCampos();
            mtbCPF.Focus();
            operacao = "Inclusão";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (mtbCPF.Text.Length < 14)
            {
                MessageBox.Show("É necessário consultar um funcionário primeiro antes de realizar a alteração.", "Erro na Alteração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                habilitaCampos(true);
                mtbCPF.Enabled = false;
                habilitaBotoes(false);
                mtbCPF.Focus();
                operacao = "Alteração";
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaFuncionario consulta = new frmConsultaFuncionario();

            DialogResult resposta = consulta.ShowDialog();
            if(resposta == DialogResult.OK)
            {
                func.Cpf = consulta.mtbCPFFuncionario.Text;
                if(funcBD.consulta(func))
                {
                    objetoForm();
                    habilitaCampos(false);
                    habilitaDemissao(false);
                    chkHabilitaDemissao.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Funcionário não encontrado.", "Consulta de Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (mtbCPF.Text.Trim().Length < 14)
            {
                MessageBox.Show("É necessário consultar um funcionário primeiro antes de realizar a exclusão.", "Erro na Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult resposta = MessageBox.Show("Confirma a exclusão do funcionário " + txtNome.Text.Trim() + "?", "Confirmação da Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(resposta == DialogResult.Yes)
                {
                    this.formObjeto();
                    if(funcBD.exclui(func))
                    {
                        MessageBox.Show("O funcionário foi excluído com sucesso.", "Exclusão Efetuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpaCampos();
                        func = new Funcionario();

                    }
                    else
                    {
                        MessageBox.Show("O funcionário não foi excluído.", "Exclusão não Efetuada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("O funcionário não foi excluído.", "Exclusão não Efetuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirma a " + operacao + " do funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resposta == DialogResult.Yes)
            {
                if(consisteCampos())
                {
                    formObjeto();
                    if (operacao.Equals("Inclusão"))
                    {
                        if(funcBD.inclui(func))
                        {
                            limpaCampos();
                            mtbCPF.Focus();
                        }
                        else
                        {
                            mtbCPF.Focus();
                        }
                    }
                    else if (operacao.Equals("Alteração"))
                    {
                        formObjeto();
                        if(funcBD.altera(func))
                        {
                            MessageBox.Show("O funcionário foi alterado.", "Alteração Efetuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            habilitaCampos(false);
                            habilitaBotoes(true);   
                        }
                        else
                        {
                            MessageBox.Show("O funcionário não foi alterado.", "Alteração não Efetuada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    if (operacao.Equals("Inclusão"))
                    {
                        mtbCPF.Focus();
                    }
                    else if (operacao.Equals("Alteração"))
                    {
                        habilitaCampos(false);
                        habilitaBotoes(true);
                    }
                }
            }
            else
            {
                mtbCPF.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(false);
            habilitaBotoes(true);
        }

        private void limpaCampos()
        {
            func = new Funcionario();

            mtbCPF.Clear();
            txtNome.Clear();
            txtCargo.Clear();
            txtSalario.Clear();
            dtpDataAdmissao.Value = DateTime.Now;
            dtpDataDemissao.Value = DateTime.Now;
            habilitaDemissao(false);
        }

        private void habilitaCampos(Boolean op)
        {
            mtbCPF.Enabled = op;
            txtNome.Enabled = op;
            txtCargo.Enabled = op;
            txtSalario.Enabled = op;
            dtpDataAdmissao.Enabled = op;
            if (func.DataDemissao.Equals(new DateTime()))
            {
                dtpDataDemissao.Value = DateTime.Now;
            }
            else
            {
                dtpDataDemissao.Value = func.DataDemissao;
            }
            habilitaDemissao(op);
            chkHabilitaDemissao.Enabled = op;
        }

        private void habilitaDemissao(Boolean op)
        {
            dtpDataDemissao.Enabled = op;
            if (func.DataDemissao.Equals(new DateTime()))
            {
                chkHabilitaDemissao.Checked = false;
            }
            else
            {
                chkHabilitaDemissao.Checked = true;
            }
        }

        private void habilitaBotoes(Boolean op)
        {
            btnIncluir.Enabled = op;
            btnAlterar.Enabled = op;
            btnExcluir.Enabled = op;
            btnConsultar.Enabled = op;

            btnConfirmar.Enabled = !op;
            btnCancelar.Enabled = !op;
        }
        private void objetoForm()
        {
            mtbCPF.Text = func.Cpf;
            txtNome.Text = func.Nome;
            txtSalario.Text = func.Salario.ToString();
            txtCargo.Text = func.Cargo;
            dtpDataAdmissao.Value = func.DataAdmissao;

            if (func.DataDemissao.Equals(new DateTime()))
            {
                chkHabilitaDemissao.Checked = false;
                func.DataDemissao = new DateTime();
            }
            else
            {
                chkHabilitaDemissao.Checked = true;
                dtpDataDemissao.Value = func.DataDemissao;
            }
            chkHabilitaDemissao.Enabled = false;
        }
        private void formObjeto()
        {
            func.Cpf = mtbCPF.Text;
            func.Nome = txtNome.Text.Trim();
            func.Salario = Convert.ToDouble(txtSalario.Text.Trim());
            func.Cargo = txtCargo.Text.Trim();
            func.DataAdmissao = dtpDataAdmissao.Value;

            if(chkHabilitaDemissao.Checked == false)
            {
                func.DataDemissao = new DateTime();
            }
            else
            {
                func.DataDemissao = dtpDataDemissao.Value;
            }
        }
        private Boolean consisteCampos()
        {
            Boolean retorno = false;
            if (mtbCPF.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF corretamente.", "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbCPF.Focus();
            }
            else
            {
                if (txtNome.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Preencha o campo Nome corretamente.", "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome.Focus();
                }
                else
                {
                    double convertido;

                    if (Double.TryParse(txtSalario.Text.Trim(), out convertido) == false)
                    {
                        MessageBox.Show("Preencha o campo Salário corretamente.", "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtSalario.Focus();
                    }
                    else
                    {
                        if (txtCargo.Text.Trim().Length < 4)
                        {
                            MessageBox.Show("Preencha o campo Cargo corretamente.", "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtCargo.Focus();
                        }
                        else
                        {
                            retorno = true;
                        }
                    }
                }
            }

            return retorno;
        }

        private void frmManutencaoFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
