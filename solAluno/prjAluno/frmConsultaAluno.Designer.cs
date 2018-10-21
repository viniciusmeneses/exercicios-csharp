namespace prjAluno
{
    partial class frmConsultaAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblRegistroConsulta = new System.Windows.Forms.Label();
            this.txtRegistroConsulta = new System.Windows.Forms.TextBox();
            this.btnOkConsulta = new System.Windows.Forms.Button();
            this.btnCancelarConsulta = new System.Windows.Forms.Button();
            this.lblCpfConsulta = new System.Windows.Forms.Label();
            this.lblOu = new System.Windows.Forms.Label();
            this.mtbCpfConsulta = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitulo.Location = new System.Drawing.Point(44, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(198, 31);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Consulta Aluno";
            // 
            // lblRegistroConsulta
            // 
            this.lblRegistroConsulta.AutoSize = true;
            this.lblRegistroConsulta.Location = new System.Drawing.Point(23, 90);
            this.lblRegistroConsulta.Name = "lblRegistroConsulta";
            this.lblRegistroConsulta.Size = new System.Drawing.Size(128, 13);
            this.lblRegistroConsulta.TabIndex = 25;
            this.lblRegistroConsulta.Text = "Digite o registro do Aluno:";
            this.lblRegistroConsulta.Click += new System.EventHandler(this.lblConsultaAluno_Click);
            // 
            // txtRegistroConsulta
            // 
            this.txtRegistroConsulta.Location = new System.Drawing.Point(157, 87);
            this.txtRegistroConsulta.MaxLength = 8;
            this.txtRegistroConsulta.Name = "txtRegistroConsulta";
            this.txtRegistroConsulta.Size = new System.Drawing.Size(98, 20);
            this.txtRegistroConsulta.TabIndex = 26;
            // 
            // btnOkConsulta
            // 
            this.btnOkConsulta.Location = new System.Drawing.Point(26, 199);
            this.btnOkConsulta.Name = "btnOkConsulta";
            this.btnOkConsulta.Size = new System.Drawing.Size(98, 36);
            this.btnOkConsulta.TabIndex = 27;
            this.btnOkConsulta.Text = "OK";
            this.btnOkConsulta.UseVisualStyleBackColor = true;
            this.btnOkConsulta.Click += new System.EventHandler(this.btnOkConsulta_Click);
            // 
            // btnCancelarConsulta
            // 
            this.btnCancelarConsulta.Location = new System.Drawing.Point(157, 199);
            this.btnCancelarConsulta.Name = "btnCancelarConsulta";
            this.btnCancelarConsulta.Size = new System.Drawing.Size(98, 36);
            this.btnCancelarConsulta.TabIndex = 28;
            this.btnCancelarConsulta.Text = "Cancelar";
            this.btnCancelarConsulta.UseVisualStyleBackColor = true;
            this.btnCancelarConsulta.Click += new System.EventHandler(this.btnCancelarConsulta_Click);
            // 
            // lblCpfConsulta
            // 
            this.lblCpfConsulta.AutoSize = true;
            this.lblCpfConsulta.Location = new System.Drawing.Point(37, 163);
            this.lblCpfConsulta.Name = "lblCpfConsulta";
            this.lblCpfConsulta.Size = new System.Drawing.Size(114, 13);
            this.lblCpfConsulta.TabIndex = 29;
            this.lblCpfConsulta.Text = "Digite o CPF do Aluno:";
            // 
            // lblOu
            // 
            this.lblOu.AutoSize = true;
            this.lblOu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblOu.Location = new System.Drawing.Point(129, 122);
            this.lblOu.Name = "lblOu";
            this.lblOu.Size = new System.Drawing.Size(37, 22);
            this.lblOu.TabIndex = 31;
            this.lblOu.Text = "OU";
            // 
            // mtbCpfConsulta
            // 
            this.mtbCpfConsulta.Location = new System.Drawing.Point(157, 160);
            this.mtbCpfConsulta.Mask = "999,999,999-99";
            this.mtbCpfConsulta.Name = "mtbCpfConsulta";
            this.mtbCpfConsulta.Size = new System.Drawing.Size(98, 20);
            this.mtbCpfConsulta.TabIndex = 32;
            // 
            // frmConsultaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(280, 254);
            this.ControlBox = false;
            this.Controls.Add(this.mtbCpfConsulta);
            this.Controls.Add(this.lblOu);
            this.Controls.Add(this.lblCpfConsulta);
            this.Controls.Add(this.btnCancelarConsulta);
            this.Controls.Add(this.btnOkConsulta);
            this.Controls.Add(this.txtRegistroConsulta);
            this.Controls.Add(this.lblRegistroConsulta);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConsultaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Aluno";
            this.Load += new System.EventHandler(this.frmConsultaAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblRegistroConsulta;
        private System.Windows.Forms.Button btnOkConsulta;
        private System.Windows.Forms.Button btnCancelarConsulta;
        private System.Windows.Forms.Label lblCpfConsulta;
        private System.Windows.Forms.Label lblOu;
        public System.Windows.Forms.TextBox txtRegistroConsulta;
        public System.Windows.Forms.MaskedTextBox mtbCpfConsulta;
    }
}