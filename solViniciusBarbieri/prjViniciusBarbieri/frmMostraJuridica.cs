using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjViniciusBarbieri
{
    public partial class frmMostraJuridica : Form
    {
        private Juridica jur = new Juridica("Vinicius", "5852719572");
        public frmMostraJuridica()
        {
            InitializeComponent();

        }

        private void frmMostra_Load(object sender, EventArgs e)
        {

        }

        private void btnMostra_Click(object sender, EventArgs e)
        {
            txtMostra.Text = jur.ToString();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtMostra.Clear();
        }

        private void txtMostra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
