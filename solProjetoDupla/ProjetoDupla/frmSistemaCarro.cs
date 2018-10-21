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
    public partial class frmSistemaCarro : Form
    {
        private Carro carro;

        private CarroDB carroDB;
        private VeiculoDB veiculoDB;

        private String operacao;

        public frmSistemaCarro()
        {
            InitializeComponent();

            carro = new Carro();

            carroDB = new CarroDB();
            veiculoDB = new VeiculoDB();

            habilitaCampos(false);
            habilitaBotoes(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void habilitaBotoes(Boolean op)
        {
            btnIncluir.Enabled = op;
            btnAlterar.Enabled = op;
            btnConsultar.Enabled = op;
            btnExcluir.Enabled = op;

            btnConfirmar.Enabled = !op;
            btnCancelar.Enabled = !op;
        }

        public void habilitaCampos(Boolean op)
        {
            txtRegistro.Enabled = op;
            cmbMarca.Enabled = op;
            txtNome.Enabled = op;
            cmbCombustivel.Enabled = op;
            txtLugares.Enabled = op;
            txtVelocidadeMax.Enabled = op;
            cmbModelo.Enabled = op;
            cmbDirecao.Enabled = op;
            radArCondSim.Enabled = op;
            radArCondNao.Enabled = op;
            radSomSim.Enabled = op;
            radSomNao.Enabled = op;
        }

        public void limpaCampos()
        {
            txtRegistro.Clear();
            cmbMarca.Text = "";
            txtNome.Clear();
            cmbCombustivel.Text = "";
            txtLugares.Clear();
            txtVelocidadeMax.Clear();
            cmbModelo.Text = "";
            cmbDirecao.Text = "";
            radArCondSim.Checked = false;
            radArCondNao.Checked = false;
            radSomSim.Checked = false;
            radSomNao.Checked = false;
        }

        public void moveTelaObjeto()
        {
            carro.Id = Convert.ToInt16(txtRegistro.Text);
            carro.Marca = cmbMarca.Text;
            carro.Nome = txtNome.Text;
            carro.Combustivel = cmbCombustivel.Text;
            carro.Lugares = Convert.ToInt16(txtLugares.Text);
            carro.VelocidadeMax = Convert.ToInt16(txtVelocidadeMax.Text);
            carro.Modelo = cmbModelo.Text;
            carro.ArCond = radArCondSim.Checked ? true : false;
            carro.Som = radSomSim.Checked ? true : false;
            carro.Direcao = cmbDirecao.Text;
        }

        public void moveObjetoTela()
        {
            txtRegistro.Text = carro.Id.ToString();
            cmbMarca.Text = carro.Marca;
            txtNome.Text = carro.Nome;
            cmbCombustivel.Text = carro.Combustivel;
            txtLugares.Text = carro.Lugares.ToString();
            txtVelocidadeMax.Text = carro.VelocidadeMax.ToString();
            cmbModelo.Text = carro.Modelo;
            if (carro.ArCond.Equals(true))
            {
                radArCondSim.Checked = true;
            }
            else
            {
                radArCondNao.Checked = true;
            }

            if (carro.Som.Equals(true))
            {
                radSomSim.Checked = true;
            }
            else
            {
                radSomNao.Checked = true;
            }
            cmbDirecao.Text = carro.Direcao;
        }

        private Boolean consisteCampos()
        {
            Boolean retorno = false;

            Int16 convertidoInt16;
            Int16 convertidoInt16Lugares;
            Double convertidoDouble;
            
            if(Int16.TryParse(txtRegistro.Text, out convertidoInt16) == false)
            {
                MessageBox.Show("Preencha o campo Registro corretamente.");
                txtRegistro.Focus();
            }
            else
            {
                if(cmbMarca.Text == "")
                {
                    MessageBox.Show("Escolha uma marca.");
                    cmbMarca.Focus();
                }
                else
                {
                    if (txtNome.Text.ToString().Length < 2)
                    {
                        MessageBox.Show("Preencha o campo Nome corretamente.");
                        txtRegistro.Focus();
                    }
                    else
                    {
                        if (cmbCombustivel.Text == "")
                        {
                            MessageBox.Show("Escolha um tipo de combustivel.");
                            cmbCombustivel.Focus();
                        }
                        else
                        {
                            if (Int16.TryParse(txtLugares.Text, out convertidoInt16Lugares) == false)
                            {
                                MessageBox.Show("Preencha o campo Lugares corretamente.");
                                txtRegistro.Focus();
                            }
                            else
                            {
                                if (Double.TryParse(txtVelocidadeMax.Text, out convertidoDouble) == false)
                                {
                                    MessageBox.Show("Preencha o campo Velocidade Máxima corretamente.");
                                    txtRegistro.Focus();
                                }
                                else
                                {
                                    if (cmbModelo.Text == "")
                                    {
                                        MessageBox.Show("Escolha um Modelo de carro.");
                                        cmbModelo.Focus();
                                    }
                                    else
                                    {
                                        if (cmbDirecao.Text == "")
                                        {
                                            MessageBox.Show("Escolha um tipo de direção.");
                                            cmbDirecao.Focus();
                                        }
                                        else
                                        {
                                            if (radArCondSim.Checked == false && radArCondNao.Checked == false)
                                            {
                                                MessageBox.Show("Selecione se o carro possui ar-condicionado ou não.");
                                            }
                                            else
                                            {
                                                if (radSomSim.Checked == false && radSomNao.Checked == false)
                                                {
                                                    MessageBox.Show("Selecione se o carro possui som ou não.");
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
                        }
                    }
                }
            }

            return retorno;
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            habilitaBotoes(false);
            limpaCampos();
            txtRegistro.Focus();
            operacao = "Inclusão";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(false);
            habilitaBotoes(true);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Int16 convertidoInt16;

            if (Int16.TryParse(txtRegistro.Text, out convertidoInt16) == false)
            {
                MessageBox.Show("Não existe aluno a ser alterado, por favor consulte primeiro.", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                habilitaCampos(true);
                habilitaBotoes(false);
                operacao = "Alteração";
                txtRegistro.Enabled = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Int16 convertido;
            if (Int16.TryParse(txtRegistro.Text, out convertido) == false || convertido < 1)
                MessageBox.Show("Não existe um carro a ser excluído.\nConsulte um carro primeiro.");
            else
            {
                DialogResult resposta = MessageBox.Show("Confirma a Exclusão do Carro ?",
                                        "Confirmação da Exclusão.",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    carroDB.exclui(carro);
                    veiculoDB.exclui(carro);
                    limpaCampos();
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaCarro frmConsulta = new frmConsultaCarro();

            DialogResult resposta = frmConsulta.ShowDialog();

            if (resposta == DialogResult.OK)
            {
                carro = new Carro();

                carro.Id = Int16.Parse(frmConsulta.txtRegistroConsulta.Text);

                if (veiculoDB.consulta(carro) && carroDB.consulta(carro))
                    moveObjetoTela();
                else
                    MessageBox.Show("Carro não encontrado.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            //Executa o MessageBox.Show com texto concatenado a operação, com botões e atribui o botao clicado no DialogResult resposta.
            DialogResult resposta = MessageBox.Show("Confirma a " + operacao + "?", "Confirmação da " + operacao, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                //Testa a consistencia
                if (consisteCampos())
                {
                    //Executa o método que atribui os valores nos atributos do objeto
                    moveTelaObjeto();
                    //Se operação for inclusão, limpa os campos,coloca focus no registro pra incluir outro e roda o metodo inclui do AlunoDB passando o objeto aluno que contem as informacoes.
                    if (operacao.Equals("Inclusão"))
                    {
                        veiculoDB.inclui(carro);
                        carroDB.inclui(carro);
                        limpaCampos();
                        txtRegistro.Focus();
                    }
                    //Se não, desabilita os campos, habilita os botões e roda o metodo alterar do AlunoDB passando o objeto aluno que contem as informacoes. Deixa as informações na tela pro usuario ter certeza que foi alterado.
                    else
                    {
                        if (operacao.Equals("Alteração"))
                        {
                            veiculoDB.altera(carro);
                            carroDB.altera(carro);
                        }
                        habilitaCampos(false);
                        habilitaBotoes(true);
                    }
                }
            }
        }
    }
}
