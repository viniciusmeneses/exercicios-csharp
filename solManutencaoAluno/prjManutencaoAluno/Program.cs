using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjManutencaoAluno
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmManutencaoAluno());

            /*Aluno aluno = new Aluno();

            aluno.Registro = 12;
            aluno.Nome = "Jão Pitomba";
            aluno.Cpf = "145.845.348-57";
            aluno.DataNascimento = new DateTime(2000, 5, 14);
            aluno.Sexo = "M";
            aluno.Telefone = "(19)99541-1234";
            aluno.Email = "jao.pitomba@etec.sp.gov.br";
            aluno.Situacao = "Matriculado";

            Aluno aluno1 = new Aluno(21, "Jandira Carolina", "245.231.459-32",
                new DateTime(2003, 12, 21), "F", "(19) 3246-4477",
                "jan.car@gmail.com", "Matriculado");

            Aluno clone = aluno;

            MessageBox.Show(aluno.Equals(clone).ToString());*/

        }
    }
}
