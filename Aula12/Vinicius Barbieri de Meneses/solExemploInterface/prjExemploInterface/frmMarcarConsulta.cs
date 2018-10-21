using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjExemploInterface
{
    public partial class frmMarcarConsulta : Form
    {
        Animal animal;
        Socio socio;
        Medico medico;
        Consulta consulta;

        int situacao = 0;

        public frmMarcarConsulta()
        {
            socio = new Socio("Vinicius", 17, "346.768.888-88", "3367");
            animal = new Animal("Futrica", 9, "2314", "Baleia", "Baleia Azul");
            medico = new Medico("Dr. Jãum", 30, "451.231.632-11", 5482942, "Clínico Geral");
            consulta = new Consulta();
            InitializeComponent();
        }

        private void frmMarcarConsulta_Load(object sender, EventArgs e)
        {
            dtpDataConsulta.MinDate = DateTime.Now.Date.AddDays(1);
            dtpDataConsulta.Value = DateTime.Now.Date.AddDays(1);
            lblMedico.Text = "Médico: " + medico.Nome.ToString() + " - " + medico.Especialidade.ToString() + " - " + medico.NroCRM.ToString() + " - " + medico.Cpf.ToString() + " - " + medico.Idade + " anos.";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtAvaliacao_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSintomas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            if (cmbPaciente.Text == "")
            {
                MessageBox.Show("Escolha um paciente.", "Marcar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbPaciente.Focus();
            }
            else
            {
                if (txtSintomas.Text.Trim().Length < 19)
                {
                    MessageBox.Show("Preencha o campo Sintomas corretamente com pelo menos 20 caracteres.", "Marcar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSintomas.Focus();
                }
                else
                {
                    if (txtAvaliacao.Text.Trim().Length < 9)
                    {
                        MessageBox.Show("Preencha o campo Avaliação corretamente com pelo menos 10 caracteres.", "Marcar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtAvaliacao.Focus();
                    }
                    else
                    {
                        if(cmbPaciente.Text == "Vinicius (Sócio) - 17 anos")
                        {
                            consulta = new Consulta(dtpDataConsulta.Value, txtSintomas.Text.Trim(), txtAvaliacao.Text.Trim(), medico, socio);
                        }
                        else
                        {
                            consulta = new Consulta(dtpDataConsulta.Value, txtSintomas.Text.Trim(), txtAvaliacao.Text.Trim(), medico, animal);
                        }

                        MessageBox.Show("Consulta marcada com sucesso!\n\n" + consulta.ToString(), "Consulta Marcada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
