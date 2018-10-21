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
    public partial class frmManutencaoAluno : Form
    {
        //Cria um atributo no Form do tipo Aluno
        private Aluno aluno;

        //Cria um atributo do tipo AlunoDB
        private AlunoBD aluBD;

        //Cria uma variável String operacao
        private String operacao;


        //Construtor do Form
        public frmManutencaoAluno()
        {
            InitializeComponent();
            //Cria o objeto Aluno no atributo aluno no construtor do Form
            aluno = new Aluno();

            //Cria um objeto AlunoDB no atributo aluDB
            aluBD = new AlunoBD();

            //Executa os metodos pra habilitar os botoes da primeira linha e desabilitar os campos
            HabilitaCampos(false);
            HabilitaBotoes(true);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Habilita ou desabilita os botões
        //Quando a primeira linha de botões estiver habilitada, a segunda linha vai ficar desabilitada e vice-versa
        private void HabilitaBotoes(Boolean op)
        {
            btnInclusao.Enabled = op;
            btnAlteracao.Enabled = op;
            btnExclusao.Enabled = op;
            btnConsulta.Enabled = op;

            btnConfirmar.Enabled = !op;
            btnCancelar.Enabled = !op;
        }

        //Habilita ou desabilita todos os campos do form.
        private void HabilitaCampos(Boolean op)
        {
            txtRegistro.Enabled = op;
            txtNome.Enabled = op;
            mtbCPF.Enabled = op;
            mtbDataNascimento.Enabled = op;
            radSexoMasculino.Enabled = op;
            radSexoFeminino.Enabled = op;
            mtbTelefone.Enabled = op;
            txtEmail.Enabled = op;
            cmbSituacao.Enabled = op;

        }
        
        //Limpa todos os campos
        private void LimpaCampos()
        {
            txtRegistro.Clear();
            txtNome.Clear();
            mtbCPF.Clear();
            mtbDataNascimento.Clear();
            radSexoMasculino.Checked = true;
            mtbTelefone.Clear();
            txtEmail.Clear();
        }

        //Método para inserir os valores que estão nos atributos do objeto nos campos do form
        public void MoveObjetoTela()
        {
            txtRegistro.Text = aluno.Registro.ToString();
            txtNome.Text = aluno.Nome;
            mtbCPF.Text = aluno.Cpf;
            mtbDataNascimento.Text = aluno.DataNascimento.ToString();
            if(aluno.Sexo.Equals("M"))
            {
                radSexoMasculino.Checked = true;
            }
            else
            {
                radSexoFeminino.Checked = true;
            }
            mtbTelefone.Text = aluno.Telefone;
            txtEmail.Text = aluno.Email;
            cmbSituacao.Text = aluno.Situacao;
        }

        //Método para atribuir os valores inseridos nos atributos do objeto criado.
        //Método criado por causa que futuramente será usado varias vezes a atribuição e sempre que houver copia de codigo, ele deve se tornar um método.
        private void MoveTelaObjeto()
        {
            aluno.Registro = Convert.ToInt32(txtRegistro.Text.ToString());
            aluno.Nome = txtNome.Text;
            aluno.Cpf = mtbCPF.Text;

            //Converter texto da txtBox pra Datetime
            aluno.DataNascimento = Convert.ToDateTime(mtbDataNascimento.Text.ToString());

            //IF de linha sintaxe: <condição> ? <Ação se verdadeiro> : <Ação se falso>
            aluno.Sexo = radSexoMasculino.Checked ? "M" : "F";
            aluno.Telefone = mtbTelefone.Text;
            aluno.Email = txtEmail.Text;
            aluno.Situacao = cmbSituacao.Text;
        }

        //Consistencia - Metodo verifica se os campos foram digitados corretamente.
        private Boolean consisteCampos()
        {
            Boolean retorno = false;
            Int32 convertidoInt32;
            DateTime convertidoDT;

            if(Int32.TryParse(txtRegistro.Text, out convertidoInt32) == false)
            {
                MessageBox.Show("Preencha o campo Registro corretamente.");
                txtRegistro.Focus();
            }
            else
            {
                if (txtNome.Text.ToString().Trim().Length < 6)
                {
                    MessageBox.Show("Preencha o campo Nome corretamente.");
                    txtNome.Focus();
                }
                else
                {
                    if (mtbCPF.Text.ToString().Length < 14)
                    {
                        MessageBox.Show("Preencha o campo CPF corretamente.");
                        mtbCPF.Focus();
                    }
                    else
                    {
                        if (DateTime.TryParse(mtbDataNascimento.Text, out convertidoDT) == false)
                        {
                            MessageBox.Show("Preencha o campo Data de Nascimento corretamente.");
                            mtbDataNascimento.Focus();
                        }
                        else
                        {
                            if (mtbTelefone.Text.ToString().Length != 14)
                            {
                                MessageBox.Show("Preencha o campo Telefone corretamente.");
                                mtbTelefone.Focus();
                            }
                            else
                            {
                                if (txtEmail.Text.ToString().Length < 7 || txtEmail.Text.ToString().Contains("@") == false || txtEmail.Text.ToString().Contains(".") == false)
                                {
                                    MessageBox.Show("Preencha o campo Email corretamente.");
                                    txtEmail.Focus();
                                }
                                else
                                {
                                    //Se todas as consistencias estiverem certas, atribui true ao retorno.
                                    retorno = true;
                                }
                            }
                        }
                    }
                }
            }
            return retorno;
        }



        //Botão Confirmar
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Executa o MessageBox.Show com texto concatenado a operação, com botões e atribui o botao clicado no DialogResult resposta.
            DialogResult resposta = MessageBox.Show("Confirma a " + operacao + "?", "Confirmação da " + operacao, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                //Testa a consistencia
                if (consisteCampos())
                {
                    //Executa o método que atribui os valores nos atributos do objeto
                    MoveTelaObjeto();
                    //Se operação for inclusão, limpa os campos,coloca focus no registro pra incluir outro e roda o metodo inclui do AlunoDB passando o objeto aluno que contem as informacoes.
                    if (operacao.Equals("Inclusão"))
                    {
                        aluBD.inclui(aluno);
                        LimpaCampos();
                        txtRegistro.Focus();
                    }
                    //Se não, desabilita os campos, habilita os botões e roda o metodo alterar do AlunoDB passando o objeto aluno que contem as informacoes. Deixa as informações na tela pro usuario ter certeza que foi alterado.
                    else
                    {
                        if (operacao.Equals("Alteração"))
                        {
                            aluBD.altera(aluno);
                        }
                        HabilitaCampos(false);
                        HabilitaBotoes(true);
                    }
                }
            }
        }

        //Botão Exclusão
        private void btnExclusao_Click(object sender, EventArgs e)
        {
            Int32 convertido;
            if (Int32.TryParse(txtRegistro.Text, out convertido) == false || convertido < 1)
                MessageBox.Show("Não há aluno a ser excluído.\n Consulte o Aluno a ser excluído.");
            else
            {
                DialogResult resposta = MessageBox.Show("Confirma a Exclusão do Aluno ?",
                                        "Confirmação da Exclusão.",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    //Roda o metodo exclui passando o objeto aluno
                    aluBD.exclui(aluno);
                    LimpaCampos();
                }
            }
        }

        //Botão Consultar
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            //Cria uma instancia do form Consulta
            frmConsultaAluno frmConsulta = new frmConsultaAluno();
            //Cria uma variavel do tipo DialogResult pra receber o botão clicado no frmConsulta
            //Abre o frmConsulta com o ShowDialog()
            //ShowDialog() pode retornar o valor do botão clicado, .Show() só abre o form sem retorno
            DialogResult resposta = frmConsulta.ShowDialog();

            if(resposta == DialogResult.OK)
            {
                //Cria um novo aluno no mesmo objeto pra poder ter certeza que nao vai ter nenhum atributo preenchido
                aluno = new Aluno();

                //Se o campo CPF estiver preenchido
                if (frmConsulta.mtbCpfConsulta.Text.Length == 14)
                {
                    //Pega o valor da mtbCpf do formConsulta e coloca no atributo cpf do objeto aluno
                    aluno.Cpf = frmConsulta.mtbCpfConsulta.Text.ToString();
                }
                //Se não estiver/campo registro vai estar preenchido
                else
                {
                    //Pega o valor do txtRegistro do formConsulta e coloca no atributo registro do objeto aluno
                    aluno.Registro = Int32.Parse(frmConsulta.txtRegistroConsulta.Text);
                }

                //Se o retorno do metodo consulta for true / deu tudo certo no comando, executa o moveTelaObjeto pra mostrar na tela os atributos
                if (aluBD.consulta(aluno))
                    MoveObjetoTela();
                //Se nao:
                else
                    MessageBox.Show("Aluno não encontrado.","Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        //Botão Inclusão
        private void btnInclusao_Click(object sender, EventArgs e)
        {
            HabilitaCampos(true);
            HabilitaBotoes(false);
            LimpaCampos();
            txtRegistro.Focus();
            operacao = "Inclusão";
        }

        //Botão Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            HabilitaCampos(false);
            HabilitaBotoes(true);
        }

        //Botão Alteração
        private void btnAlteracao_Click(object sender, EventArgs e)
        {
            Int32 convertido;
            //Se não for possivel converter o texto do campo registro pra int32 (retorna false se nao conseguir converter)
            //OU se conseguir converter, mas o valor convertido for menor que 1 (caso o usuario coloque um registro negativo), então mostra mensagem de erro.
            //Se não, habilita os campos pra alteração e etc...
            if(Int32.TryParse(txtRegistro.Text, out convertido) == false || convertido < 1)
            {
                MessageBox.Show("Não há aluno a ser alterado, por favor consulte primeiro.", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                HabilitaCampos(true);
                txtRegistro.Enabled = false;
                txtNome.Focus();
                operacao = "Alteração";
                HabilitaBotoes(false);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
