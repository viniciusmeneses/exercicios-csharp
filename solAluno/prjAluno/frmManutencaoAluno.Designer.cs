namespace prjAluno
{
    partial class frmManutencaoAluno
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.radSexoMasculino = new System.Windows.Forms.RadioButton();
            this.radSexoFeminino = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.btnInclusao = new System.Windows.Forms.Button();
            this.btnAlteracao = new System.Windows.Forms.Button();
            this.btnExclusao = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.mtbDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(170, 77);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(49, 13);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Registro:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(181, 99);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(189, 122);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(112, 144);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblDataNascimento.TabIndex = 3;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(185, 167);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(167, 190);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(184, 212);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(167, 234);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 7;
            this.lblSituacao.Text = "Situação:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(225, 74);
            this.txtRegistro.MaxLength = 6;
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(88, 20);
            this.txtRegistro.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(225, 96);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(143, 20);
            this.txtNome.TabIndex = 2;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(225, 119);
            this.mtbCPF.Mask = "999,999,999-99";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(81, 20);
            this.mtbCPF.TabIndex = 3;
            // 
            // radSexoMasculino
            // 
            this.radSexoMasculino.AutoSize = true;
            this.radSexoMasculino.Checked = true;
            this.radSexoMasculino.Location = new System.Drawing.Point(225, 165);
            this.radSexoMasculino.Name = "radSexoMasculino";
            this.radSexoMasculino.Size = new System.Drawing.Size(73, 17);
            this.radSexoMasculino.TabIndex = 5;
            this.radSexoMasculino.TabStop = true;
            this.radSexoMasculino.Text = "Masculino";
            this.radSexoMasculino.UseVisualStyleBackColor = true;
            // 
            // radSexoFeminino
            // 
            this.radSexoFeminino.AutoSize = true;
            this.radSexoFeminino.Location = new System.Drawing.Point(304, 165);
            this.radSexoFeminino.Name = "radSexoFeminino";
            this.radSexoFeminino.Size = new System.Drawing.Size(67, 17);
            this.radSexoFeminino.TabIndex = 6;
            this.radSexoFeminino.Text = "Feminino";
            this.radSexoFeminino.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(225, 209);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(143, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Items.AddRange(new object[] {
            "Cursando",
            "Matriculado",
            "Trancado"});
            this.cmbSituacao.Location = new System.Drawing.Point(225, 231);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(88, 21);
            this.cmbSituacao.TabIndex = 9;
            // 
            // btnInclusao
            // 
            this.btnInclusao.Location = new System.Drawing.Point(12, 274);
            this.btnInclusao.Name = "btnInclusao";
            this.btnInclusao.Size = new System.Drawing.Size(112, 37);
            this.btnInclusao.TabIndex = 10;
            this.btnInclusao.Text = "Inclusão";
            this.btnInclusao.UseVisualStyleBackColor = true;
            this.btnInclusao.Click += new System.EventHandler(this.btnInclusao_Click);
            // 
            // btnAlteracao
            // 
            this.btnAlteracao.Location = new System.Drawing.Point(130, 274);
            this.btnAlteracao.Name = "btnAlteracao";
            this.btnAlteracao.Size = new System.Drawing.Size(112, 37);
            this.btnAlteracao.TabIndex = 12;
            this.btnAlteracao.Text = "Alteração";
            this.btnAlteracao.UseVisualStyleBackColor = true;
            this.btnAlteracao.Click += new System.EventHandler(this.btnAlteracao_Click);
            // 
            // btnExclusao
            // 
            this.btnExclusao.Location = new System.Drawing.Point(248, 274);
            this.btnExclusao.Name = "btnExclusao";
            this.btnExclusao.Size = new System.Drawing.Size(117, 38);
            this.btnExclusao.TabIndex = 13;
            this.btnExclusao.Text = "Exclusão";
            this.btnExclusao.UseVisualStyleBackColor = true;
            this.btnExclusao.Click += new System.EventHandler(this.btnExclusao_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(371, 273);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(117, 38);
            this.btnConsulta.TabIndex = 11;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // mtbDataNascimento
            // 
            this.mtbDataNascimento.Location = new System.Drawing.Point(225, 141);
            this.mtbDataNascimento.Mask = "99/99/9999";
            this.mtbDataNascimento.Name = "mtbDataNascimento";
            this.mtbDataNascimento.Size = new System.Drawing.Size(65, 20);
            this.mtbDataNascimento.TabIndex = 4;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(225, 187);
            this.mtbTelefone.Mask = "(99)99999-9999";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(88, 20);
            this.mtbTelefone.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitulo.Location = new System.Drawing.Point(124, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(239, 31);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "Manutenção Aluno";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(130, 338);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(112, 37);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(248, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 37);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(418, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 24;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmManutencaoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(505, 385);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.mtbDataNascimento);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnExclusao);
            this.Controls.Add(this.btnAlteracao);
            this.Controls.Add(this.btnInclusao);
            this.Controls.Add(this.cmbSituacao);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.radSexoFeminino);
            this.Controls.Add(this.radSexoMasculino);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblRegistro);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmManutencaoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção Aluno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.RadioButton radSexoMasculino;
        private System.Windows.Forms.RadioButton radSexoFeminino;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.Button btnInclusao;
        private System.Windows.Forms.Button btnAlteracao;
        private System.Windows.Forms.Button btnExclusao;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.MaskedTextBox mtbDataNascimento;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
    }
}

