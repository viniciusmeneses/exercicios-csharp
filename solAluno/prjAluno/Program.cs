using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAluno
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
            aluno.Nome = "Vinicius";
            aluno.Cpf = "123.456.789-77";
            aluno.DataNascimento = new DateTime(2000, 5, 14);
            aluno.Sexo = "M";
            aluno.Telefone = "(19)98192-0520";
            aluno.Email = "vini23hot@gmail.com";
            aluno.Situacao = "Matriculado";

            Aluno aluno1 = new Aluno(21,"Joao","451.431.775-77",new DateTime(2003,12,15),"F","(18)35421-4632","emailqualquer@gmail.com","Cursando");

            //MessageBox.Show(aluno.Equals(aluno1).ToString());

            Aluno clone = aluno;
            MessageBox.Show(aluno.Equals(clone).ToString());*/
        }
    }
}
