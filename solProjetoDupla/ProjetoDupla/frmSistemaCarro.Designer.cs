namespace ProjetoDupla
{
    partial class frmSistemaCarro
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.lblLugares = new System.Windows.Forms.Label();
            this.lblVelocidadeMax = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblArCond = new System.Windows.Forms.Label();
            this.lblSom = new System.Windows.Forms.Label();
            this.lblDirecao = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbCombustivel = new System.Windows.Forms.ComboBox();
            this.txtLugares = new System.Windows.Forms.TextBox();
            this.txtVelocidadeMax = new System.Windows.Forms.TextBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.radArCondSim = new System.Windows.Forms.RadioButton();
            this.radArCondNao = new System.Windows.Forms.RadioButton();
            this.cmbDirecao = new System.Windows.Forms.ComboBox();
            this.pnlArCond = new System.Windows.Forms.Panel();
            this.pnlSom = new System.Windows.Forms.Panel();
            this.radSomSim = new System.Windows.Forms.RadioButton();
            this.radSomNao = new System.Windows.Forms.RadioButton();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.pnlArCond.SuspendLayout();
            this.pnlSom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblTitulo.Location = new System.Drawing.Point(53, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(326, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de Veículos";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblSubtitulo.Location = new System.Drawing.Point(117, 72);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(192, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Gerenciamento de Carros";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(25, 113);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(49, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Registro:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(144, 113);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(281, 113);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.Location = new System.Drawing.Point(25, 161);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(69, 13);
            this.lblCombustivel.TabIndex = 5;
            this.lblCombustivel.Text = "Combustível:";
            // 
            // lblLugares
            // 
            this.lblLugares.AutoSize = true;
            this.lblLugares.Location = new System.Drawing.Point(144, 161);
            this.lblLugares.Name = "lblLugares";
            this.lblLugares.Size = new System.Drawing.Size(48, 13);
            this.lblLugares.TabIndex = 6;
            this.lblLugares.Text = "Lugares:";
            // 
            // lblVelocidadeMax
            // 
            this.lblVelocidadeMax.AutoSize = true;
            this.lblVelocidadeMax.Location = new System.Drawing.Point(207, 161);
            this.lblVelocidadeMax.Name = "lblVelocidadeMax";
            this.lblVelocidadeMax.Size = new System.Drawing.Size(102, 13);
            this.lblVelocidadeMax.TabIndex = 7;
            this.lblVelocidadeMax.Text = "Velocidade Máxima:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(324, 161);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 8;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblArCond
            // 
            this.lblArCond.AutoSize = true;
            this.lblArCond.Location = new System.Drawing.Point(144, 211);
            this.lblArCond.Name = "lblArCond";
            this.lblArCond.Size = new System.Drawing.Size(88, 13);
            this.lblArCond.TabIndex = 9;
            this.lblArCond.Text = "Ar Condicionado:";
            // 
            // lblSom
            // 
            this.lblSom.AutoSize = true;
            this.lblSom.Location = new System.Drawing.Point(281, 211);
            this.lblSom.Name = "lblSom";
            this.lblSom.Size = new System.Drawing.Size(31, 13);
            this.lblSom.TabIndex = 10;
            this.lblSom.Text = "Som:";
            // 
            // lblDirecao
            // 
            this.lblDirecao.AutoSize = true;
            this.lblDirecao.Location = new System.Drawing.Point(25, 211);
            this.lblDirecao.Name = "lblDirecao";
            this.lblDirecao.Size = new System.Drawing.Size(47, 13);
            this.lblDirecao.TabIndex = 11;
            this.lblDirecao.Text = "Direção:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(28, 129);
            this.txtRegistro.MaxLength = 4;
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(100, 20);
            this.txtRegistro.TabIndex = 12;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Chevrolet",
            "Fiat",
            "Volkswagen",
            "Ford",
            "Hyundai",
            "Toyota",
            "Renault",
            "Honda",
            "Jeep",
            "Nissan"});
            this.cmbMarca.Location = new System.Drawing.Point(147, 129);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(284, 130);
            this.txtNome.MaxLength = 25;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 20);
            this.txtNome.TabIndex = 14;
            // 
            // cmbCombustivel
            // 
            this.cmbCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCombustivel.FormattingEnabled = true;
            this.cmbCombustivel.Items.AddRange(new object[] {
            "Gasolina",
            "Álcool",
            "Diesel",
            "Gás"});
            this.cmbCombustivel.Location = new System.Drawing.Point(28, 177);
            this.cmbCombustivel.Name = "cmbCombustivel";
            this.cmbCombustivel.Size = new System.Drawing.Size(100, 21);
            this.cmbCombustivel.TabIndex = 15;
            // 
            // txtLugares
            // 
            this.txtLugares.Location = new System.Drawing.Point(147, 178);
            this.txtLugares.MaxLength = 1;
            this.txtLugares.Name = "txtLugares";
            this.txtLugares.Size = new System.Drawing.Size(45, 20);
            this.txtLugares.TabIndex = 16;
            // 
            // txtVelocidadeMax
            // 
            this.txtVelocidadeMax.Location = new System.Drawing.Point(210, 178);
            this.txtVelocidadeMax.MaxLength = 3;
            this.txtVelocidadeMax.Name = "txtVelocidadeMax";
            this.txtVelocidadeMax.Size = new System.Drawing.Size(99, 20);
            this.txtVelocidadeMax.TabIndex = 17;
            // 
            // cmbModelo
            // 
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Items.AddRange(new object[] {
            "Hatch",
            "Sedan",
            "SUV"});
            this.cmbModelo.Location = new System.Drawing.Point(327, 177);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(78, 21);
            this.cmbModelo.TabIndex = 18;
            // 
            // radArCondSim
            // 
            this.radArCondSim.AutoSize = true;
            this.radArCondSim.Location = new System.Drawing.Point(4, 2);
            this.radArCondSim.Name = "radArCondSim";
            this.radArCondSim.Size = new System.Drawing.Size(42, 17);
            this.radArCondSim.TabIndex = 19;
            this.radArCondSim.TabStop = true;
            this.radArCondSim.Text = "Sim";
            this.radArCondSim.UseVisualStyleBackColor = true;
            // 
            // radArCondNao
            // 
            this.radArCondNao.AutoSize = true;
            this.radArCondNao.Location = new System.Drawing.Point(72, 2);
            this.radArCondNao.Name = "radArCondNao";
            this.radArCondNao.Size = new System.Drawing.Size(45, 17);
            this.radArCondNao.TabIndex = 20;
            this.radArCondNao.TabStop = true;
            this.radArCondNao.Text = "Nâo";
            this.radArCondNao.UseVisualStyleBackColor = true;
            // 
            // cmbDirecao
            // 
            this.cmbDirecao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDirecao.FormattingEnabled = true;
            this.cmbDirecao.Items.AddRange(new object[] {
            "Manual",
            "Hidráulica",
            "Elétrica"});
            this.cmbDirecao.Location = new System.Drawing.Point(28, 227);
            this.cmbDirecao.Name = "cmbDirecao";
            this.cmbDirecao.Size = new System.Drawing.Size(100, 21);
            this.cmbDirecao.TabIndex = 23;
            // 
            // pnlArCond
            // 
            this.pnlArCond.BackColor = System.Drawing.Color.Coral;
            this.pnlArCond.Controls.Add(this.radArCondSim);
            this.pnlArCond.Controls.Add(this.radArCondNao);
            this.pnlArCond.Location = new System.Drawing.Point(147, 227);
            this.pnlArCond.Name = "pnlArCond";
            this.pnlArCond.Size = new System.Drawing.Size(121, 21);
            this.pnlArCond.TabIndex = 24;
            // 
            // pnlSom
            // 
            this.pnlSom.BackColor = System.Drawing.Color.Coral;
            this.pnlSom.Controls.Add(this.radSomSim);
            this.pnlSom.Controls.Add(this.radSomNao);
            this.pnlSom.Location = new System.Drawing.Point(284, 227);
            this.pnlSom.Name = "pnlSom";
            this.pnlSom.Size = new System.Drawing.Size(121, 21);
            this.pnlSom.TabIndex = 25;
            // 
            // radSomSim
            // 
            this.radSomSim.AutoSize = true;
            this.radSomSim.Location = new System.Drawing.Point(4, 2);
            this.radSomSim.Name = "radSomSim";
            this.radSomSim.Size = new System.Drawing.Size(42, 17);
            this.radSomSim.TabIndex = 19;
            this.radSomSim.TabStop = true;
            this.radSomSim.Text = "Sim";
            this.radSomSim.UseVisualStyleBackColor = true;
            // 
            // radSomNao
            // 
            this.radSomNao.AutoSize = true;
            this.radSomNao.Location = new System.Drawing.Point(72, 2);
            this.radSomNao.Name = "radSomNao";
            this.radSomNao.Size = new System.Drawing.Size(45, 17);
            this.radSomNao.TabIndex = 20;
            this.radSomNao.TabStop = true;
            this.radSomNao.Text = "Nâo";
            this.radSomNao.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(389, -1);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(47, 23);
            this.btnSair.TabIndex = 26;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(28, 287);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(88, 43);
            this.btnIncluir.TabIndex = 27;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(125, 353);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(88, 32);
            this.btnConfirmar.TabIndex = 31;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(221, 353);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 32);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(221, 287);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 43);
            this.btnExcluir.TabIndex = 33;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(317, 287);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(88, 43);
            this.btnConsultar.TabIndex = 34;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(125, 287);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(88, 43);
            this.btnAlterar.TabIndex = 35;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmSistemaCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(435, 399);
            this.ControlBox = false;
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pnlSom);
            this.Controls.Add(this.pnlArCond);
            this.Controls.Add(this.cmbDirecao);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.txtVelocidadeMax);
            this.Controls.Add(this.txtLugares);
            this.Controls.Add(this.cmbCombustivel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.lblDirecao);
            this.Controls.Add(this.lblSom);
            this.Controls.Add(this.lblArCond);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblVelocidadeMax);
            this.Controls.Add(this.lblLugares);
            this.Controls.Add(this.lblCombustivel);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSistemaCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Veículos - Carro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlArCond.ResumeLayout(false);
            this.pnlArCond.PerformLayout();
            this.pnlSom.ResumeLayout(false);
            this.pnlSom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.Label lblLugares;
        private System.Windows.Forms.Label lblVelocidadeMax;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblArCond;
        private System.Windows.Forms.Label lblSom;
        private System.Windows.Forms.Label lblDirecao;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbCombustivel;
        private System.Windows.Forms.TextBox txtLugares;
        private System.Windows.Forms.TextBox txtVelocidadeMax;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.RadioButton radArCondSim;
        private System.Windows.Forms.RadioButton radArCondNao;
        private System.Windows.Forms.ComboBox cmbDirecao;
        private System.Windows.Forms.Panel pnlArCond;
        private System.Windows.Forms.Panel pnlSom;
        private System.Windows.Forms.RadioButton radSomSim;
        private System.Windows.Forms.RadioButton radSomNao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlterar;
    }
}

