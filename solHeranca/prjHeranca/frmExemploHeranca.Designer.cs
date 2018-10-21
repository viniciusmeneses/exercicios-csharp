namespace prjHeranca
{
    partial class frmMostraJuridica
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.txtFaturamentoMensal = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtLimiteCredido = new System.Windows.Forms.TextBox();
            this.txtAtributos = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblFaturamentoMensal = new System.Windows.Forms.Label();
            this.lblLimiteCredito = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(107, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(107, 95);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 1;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Enabled = false;
            this.txtCNPJ.Location = new System.Drawing.Point(107, 137);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(125, 20);
            this.txtCNPJ.TabIndex = 2;
            // 
            // txtFaturamentoMensal
            // 
            this.txtFaturamentoMensal.Enabled = false;
            this.txtFaturamentoMensal.Location = new System.Drawing.Point(152, 175);
            this.txtFaturamentoMensal.Name = "txtFaturamentoMensal";
            this.txtFaturamentoMensal.Size = new System.Drawing.Size(100, 20);
            this.txtFaturamentoMensal.TabIndex = 3;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(107, 313);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtLimiteCredido
            // 
            this.txtLimiteCredido.Enabled = false;
            this.txtLimiteCredido.Location = new System.Drawing.Point(152, 213);
            this.txtLimiteCredido.Name = "txtLimiteCredido";
            this.txtLimiteCredido.Size = new System.Drawing.Size(100, 20);
            this.txtLimiteCredido.TabIndex = 5;
            // 
            // txtAtributos
            // 
            this.txtAtributos.Enabled = false;
            this.txtAtributos.Location = new System.Drawing.Point(23, 247);
            this.txtAtributos.Multiline = true;
            this.txtAtributos.Name = "txtAtributos";
            this.txtAtributos.Size = new System.Drawing.Size(237, 60);
            this.txtAtributos.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(39, 54);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(39, 98);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(39, 144);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(37, 13);
            this.lblCNPJ.TabIndex = 9;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // lblFaturamentoMensal
            // 
            this.lblFaturamentoMensal.AutoSize = true;
            this.lblFaturamentoMensal.Location = new System.Drawing.Point(40, 182);
            this.lblFaturamentoMensal.Name = "lblFaturamentoMensal";
            this.lblFaturamentoMensal.Size = new System.Drawing.Size(106, 13);
            this.lblFaturamentoMensal.TabIndex = 10;
            this.lblFaturamentoMensal.Text = "Faturamento Mensal:";
            // 
            // lblLimiteCredito
            // 
            this.lblLimiteCredito.AutoSize = true;
            this.lblLimiteCredito.Location = new System.Drawing.Point(40, 220);
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(73, 13);
            this.lblLimiteCredito.TabIndex = 11;
            this.lblLimiteCredito.Text = "Limite Credito:";
            // 
            // frmMostraJuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 348);
            this.Controls.Add(this.lblLimiteCredito);
            this.Controls.Add(this.lblFaturamentoMensal);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtAtributos);
            this.Controls.Add(this.txtLimiteCredido);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtFaturamentoMensal);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostraJuridica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostra Exemplo Cadastrado.";
            this.Load += new System.EventHandler(this.frmMostraJuridica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.TextBox txtFaturamentoMensal;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtLimiteCredido;
        private System.Windows.Forms.TextBox txtAtributos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblFaturamentoMensal;
        private System.Windows.Forms.Label lblLimiteCredito;
    }
}

