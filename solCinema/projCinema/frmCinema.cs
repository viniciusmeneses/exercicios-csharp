using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projCinema
{
    public partial class frmCinema : Form
    {
        Filme filme = new Filme();
        FilmeBD filmeBD = new FilmeBD();
        String operacao = "";
        public frmCinema()
        {
            InitializeComponent();
            AtualizaGridView();
        }

        private void frmCinema_Load(object sender, EventArgs e)
        {


        }
        /*public void moveTelaObjeto()
        {
            filme.Codigo = Convert.ToInt32(txtCodigo.Text.ToString());
            filme.Nome = txtDescricao.Text.ToString();
        }*/

        private void AtualizaGridView()
        {
            dgvFilme.DataSource = filmeBD.seleciona();
            dgvFilme.Refresh();
        }

        private void dgvFilme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvFilme_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dgvFilme_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvFilme_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            /*Int16 saida;
            if (e.RowIndex != -1)
            {
                MessageBox.Show(dgvFilme.Rows[e.RowIndex].Cells[0].Value.ToString());
                if(Int16.TryParse(dgvFilme.Rows[e.RowIndex].Cells[0].Value.ToString(), out saida))
                {
                    filme.Codigo = saida;
                    filme.Nome = dgvFilme.Rows[e.RowIndex].Cells[1].Value.ToString();
                    operacao = "Alteração";
                }
                else
                {
                    operacao = "Inclusão";
                }
            }*/
        }

        private void dgvFilme_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFilme_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void dgvFilme_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFilme_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
                filme.Codigo = Convert.ToInt16(e.Row.Cells[0].EditedFormattedValue.ToString());
                filme.Nome = e.Row.Cells[1].EditedFormattedValue.ToString();
                filmeBD.inclui(filme);
        }



        /*private void dgvTipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            short saida;
            if (e.RowIndex != -1)
            {
                if (int.TryParse(dgvFilme.Rows[e.RowIndex].Cells[0].Value.ToString(), out saida))
                {
                    filme.Codigo = saida;
                    filme.Nome = dgvFilme.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
            }
        }*/
    }
}
