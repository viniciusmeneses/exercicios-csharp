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
    public partial class frmPaciente : Form
    {
        private Socio socio;
        private Animal animal;
        private Dependente dependente;
        
        public frmPaciente()
        {
            InitializeComponent();
            socio = new Socio("Jão",48,"346.768.888-88","1234");
            animal = new Animal("Laercio",3,"5467","Macaco","Gorila");
            dependente = new Dependente("Livia", 12, "565.789.654-32", "1234", socio);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exibePaciente(1,socio);
            exibePaciente(2,animal);
            exibePaciente(3, dependente);
        }

        private void exibePaciente(int nroPainel,Paciente pac)
        {
            if (nroPainel == 1)
                txtPaciente1.Text = pac.ToString();
            else
                if (nroPainel == 2)
                    txtPaciente2.Text = pac.ToString();
                else
                    txtPaciente3.Text = pac.ToString();

        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
