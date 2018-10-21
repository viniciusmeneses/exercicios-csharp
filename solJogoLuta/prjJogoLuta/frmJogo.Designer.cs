namespace prjJogoLuta
{
    partial class frmJogo
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLutar = new System.Windows.Forms.Button();
            this.txtAgi = new System.Windows.Forms.TextBox();
            this.lblAgilidade = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblExperiencia = new System.Windows.Forms.Label();
            this.lblVida = new System.Windows.Forms.Label();
            this.lblDefesa = new System.Windows.Forms.Label();
            this.lblAtaque = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.txtVida = new System.Windows.Forms.TextBox();
            this.txtDef = new System.Windows.Forms.TextBox();
            this.txtAtq = new System.Windows.Forms.TextBox();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.lblImagem = new System.Windows.Forms.Label();
            this.lblPersonagens = new System.Windows.Forms.Label();
            this.lblJogo = new System.Windows.Forms.Label();
            this.cmbPersonagens = new System.Windows.Forms.ComboBox();
            this.btnEstudar = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnDescansar = new System.Windows.Forms.Button();
            this.lblPerVivos = new System.Windows.Forms.Label();
            this.lblPerVivosResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(301, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(22, 23);
            this.btnExit.TabIndex = 61;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLutar
            // 
            this.btnLutar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLutar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLutar.Location = new System.Drawing.Point(127, 239);
            this.btnLutar.Name = "btnLutar";
            this.btnLutar.Size = new System.Drawing.Size(178, 26);
            this.btnLutar.TabIndex = 60;
            this.btnLutar.Text = "Lutar";
            this.btnLutar.UseVisualStyleBackColor = false;
            this.btnLutar.Click += new System.EventHandler(this.btnAndar_Click);
            // 
            // txtAgi
            // 
            this.txtAgi.Enabled = false;
            this.txtAgi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgi.Location = new System.Drawing.Point(127, 470);
            this.txtAgi.Name = "txtAgi";
            this.txtAgi.Size = new System.Drawing.Size(178, 26);
            this.txtAgi.TabIndex = 58;
            // 
            // lblAgilidade
            // 
            this.lblAgilidade.AutoSize = true;
            this.lblAgilidade.BackColor = System.Drawing.Color.Transparent;
            this.lblAgilidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgilidade.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAgilidade.Location = new System.Drawing.Point(35, 473);
            this.lblAgilidade.Name = "lblAgilidade";
            this.lblAgilidade.Size = new System.Drawing.Size(86, 19);
            this.lblAgilidade.TabIndex = 57;
            this.lblAgilidade.Text = "Agilidade:";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNivel.Location = new System.Drawing.Point(68, 505);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(53, 19);
            this.lblNivel.TabIndex = 56;
            this.lblNivel.Text = "Nível:";
            this.lblNivel.Click += new System.EventHandler(this.lblNivel_Click);
            // 
            // lblExperiencia
            // 
            this.lblExperiencia.AutoSize = true;
            this.lblExperiencia.BackColor = System.Drawing.Color.Transparent;
            this.lblExperiencia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperiencia.ForeColor = System.Drawing.Color.Firebrick;
            this.lblExperiencia.Location = new System.Drawing.Point(16, 441);
            this.lblExperiencia.Name = "lblExperiencia";
            this.lblExperiencia.Size = new System.Drawing.Size(105, 19);
            this.lblExperiencia.TabIndex = 55;
            this.lblExperiencia.Text = "Experiência:";
            this.lblExperiencia.Click += new System.EventHandler(this.lblExperiencia_Click);
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.BackColor = System.Drawing.Color.Transparent;
            this.lblVida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVida.ForeColor = System.Drawing.Color.Firebrick;
            this.lblVida.Location = new System.Drawing.Point(72, 409);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(49, 19);
            this.lblVida.TabIndex = 54;
            this.lblVida.Text = "Vida:";
            // 
            // lblDefesa
            // 
            this.lblDefesa.AutoSize = true;
            this.lblDefesa.BackColor = System.Drawing.Color.Transparent;
            this.lblDefesa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefesa.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDefesa.Location = new System.Drawing.Point(53, 377);
            this.lblDefesa.Name = "lblDefesa";
            this.lblDefesa.Size = new System.Drawing.Size(68, 19);
            this.lblDefesa.TabIndex = 53;
            this.lblDefesa.Text = "Defesa:";
            // 
            // lblAtaque
            // 
            this.lblAtaque.AutoSize = true;
            this.lblAtaque.BackColor = System.Drawing.Color.Transparent;
            this.lblAtaque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtaque.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAtaque.Location = new System.Drawing.Point(52, 345);
            this.lblAtaque.Name = "lblAtaque";
            this.lblAtaque.Size = new System.Drawing.Size(69, 19);
            this.lblAtaque.TabIndex = 52;
            this.lblAtaque.Text = "Ataque:";
            this.lblAtaque.Click += new System.EventHandler(this.lblAtaque_Click);
            // 
            // txtNivel
            // 
            this.txtNivel.Enabled = false;
            this.txtNivel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivel.Location = new System.Drawing.Point(127, 502);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(178, 26);
            this.txtNivel.TabIndex = 51;
            // 
            // txtExp
            // 
            this.txtExp.Enabled = false;
            this.txtExp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExp.Location = new System.Drawing.Point(127, 438);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(178, 26);
            this.txtExp.TabIndex = 50;
            // 
            // txtVida
            // 
            this.txtVida.Enabled = false;
            this.txtVida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVida.Location = new System.Drawing.Point(127, 406);
            this.txtVida.Name = "txtVida";
            this.txtVida.Size = new System.Drawing.Size(178, 26);
            this.txtVida.TabIndex = 49;
            // 
            // txtDef
            // 
            this.txtDef.Enabled = false;
            this.txtDef.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDef.Location = new System.Drawing.Point(127, 374);
            this.txtDef.Name = "txtDef";
            this.txtDef.Size = new System.Drawing.Size(178, 26);
            this.txtDef.TabIndex = 48;
            // 
            // txtAtq
            // 
            this.txtAtq.Enabled = false;
            this.txtAtq.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtq.Location = new System.Drawing.Point(127, 342);
            this.txtAtq.Name = "txtAtq";
            this.txtAtq.Size = new System.Drawing.Size(178, 26);
            this.txtAtq.TabIndex = 47;
            // 
            // pbImagem
            // 
            this.pbImagem.BackColor = System.Drawing.Color.Transparent;
            this.pbImagem.Location = new System.Drawing.Point(127, 81);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(178, 152);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 46;
            this.pbImagem.TabStop = false;
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.BackColor = System.Drawing.Color.Transparent;
            this.lblImagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagem.ForeColor = System.Drawing.Color.Firebrick;
            this.lblImagem.Location = new System.Drawing.Point(46, 81);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(75, 19);
            this.lblImagem.TabIndex = 45;
            this.lblImagem.Text = "Imagem:";
            // 
            // lblPersonagens
            // 
            this.lblPersonagens.AutoSize = true;
            this.lblPersonagens.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonagens.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonagens.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPersonagens.Location = new System.Drawing.Point(4, 46);
            this.lblPersonagens.Name = "lblPersonagens";
            this.lblPersonagens.Size = new System.Drawing.Size(117, 19);
            this.lblPersonagens.TabIndex = 44;
            this.lblPersonagens.Text = "Personagens:";
            // 
            // lblJogo
            // 
            this.lblJogo.AutoSize = true;
            this.lblJogo.BackColor = System.Drawing.Color.Transparent;
            this.lblJogo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblJogo.Location = new System.Drawing.Point(89, 9);
            this.lblJogo.Name = "lblJogo";
            this.lblJogo.Size = new System.Drawing.Size(143, 24);
            this.lblJogo.TabIndex = 43;
            this.lblJogo.Text = "Jogo de Luta";
            // 
            // cmbPersonagens
            // 
            this.cmbPersonagens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonagens.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPersonagens.FormattingEnabled = true;
            this.cmbPersonagens.Items.AddRange(new object[] {
            "Guerreiro",
            "Arqueiro",
            "Lutador",
            "Mago"});
            this.cmbPersonagens.Location = new System.Drawing.Point(127, 43);
            this.cmbPersonagens.Name = "cmbPersonagens";
            this.cmbPersonagens.Size = new System.Drawing.Size(178, 26);
            this.cmbPersonagens.TabIndex = 42;
            this.cmbPersonagens.SelectedValueChanged += new System.EventHandler(this.cbmPersonagens_SelectedValueChanged);
            // 
            // btnEstudar
            // 
            this.btnEstudar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEstudar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEstudar.Location = new System.Drawing.Point(127, 271);
            this.btnEstudar.Name = "btnEstudar";
            this.btnEstudar.Size = new System.Drawing.Size(178, 29);
            this.btnEstudar.TabIndex = 62;
            this.btnEstudar.Text = "Estudar";
            this.btnEstudar.UseVisualStyleBackColor = false;
            this.btnEstudar.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnDescansar
            // 
            this.btnDescansar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDescansar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDescansar.Location = new System.Drawing.Point(127, 306);
            this.btnDescansar.Name = "btnDescansar";
            this.btnDescansar.Size = new System.Drawing.Size(178, 30);
            this.btnDescansar.TabIndex = 63;
            this.btnDescansar.Text = "Descansar";
            this.btnDescansar.UseVisualStyleBackColor = false;
            this.btnDescansar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblPerVivos
            // 
            this.lblPerVivos.AutoSize = true;
            this.lblPerVivos.BackColor = System.Drawing.Color.Transparent;
            this.lblPerVivos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblPerVivos.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPerVivos.Location = new System.Drawing.Point(197, 528);
            this.lblPerVivos.Name = "lblPerVivos";
            this.lblPerVivos.Size = new System.Drawing.Size(120, 15);
            this.lblPerVivos.TabIndex = 64;
            this.lblPerVivos.Text = "Personagens Vivos:";
            // 
            // lblPerVivosResult
            // 
            this.lblPerVivosResult.AutoSize = true;
            this.lblPerVivosResult.BackColor = System.Drawing.Color.Transparent;
            this.lblPerVivosResult.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblPerVivosResult.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPerVivosResult.Location = new System.Drawing.Point(313, 528);
            this.lblPerVivosResult.Name = "lblPerVivosResult";
            this.lblPerVivosResult.Size = new System.Drawing.Size(14, 15);
            this.lblPerVivosResult.TabIndex = 65;
            this.lblPerVivosResult.Text = "0";
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::prjJogoLuta.Properties.Resources._640_Street_Fighter_V_l;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(326, 543);
            this.ControlBox = false;
            this.Controls.Add(this.lblPerVivosResult);
            this.Controls.Add(this.lblPerVivos);
            this.Controls.Add(this.btnDescansar);
            this.Controls.Add(this.btnEstudar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLutar);
            this.Controls.Add(this.txtAgi);
            this.Controls.Add(this.lblAgilidade);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblExperiencia);
            this.Controls.Add(this.lblVida);
            this.Controls.Add(this.lblDefesa);
            this.Controls.Add(this.lblAtaque);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.txtExp);
            this.Controls.Add(this.txtVida);
            this.Controls.Add(this.txtDef);
            this.Controls.Add(this.txtAtq);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.lblImagem);
            this.Controls.Add(this.lblPersonagens);
            this.Controls.Add(this.lblJogo);
            this.Controls.Add(this.cmbPersonagens);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo de Luta";
            this.Load += new System.EventHandler(this.frmJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnLutar;
        internal System.Windows.Forms.TextBox txtAgi;
        internal System.Windows.Forms.Label lblAgilidade;
        internal System.Windows.Forms.Label lblNivel;
        internal System.Windows.Forms.Label lblExperiencia;
        internal System.Windows.Forms.Label lblVida;
        internal System.Windows.Forms.Label lblDefesa;
        internal System.Windows.Forms.Label lblAtaque;
        internal System.Windows.Forms.TextBox txtNivel;
        internal System.Windows.Forms.TextBox txtExp;
        internal System.Windows.Forms.TextBox txtVida;
        internal System.Windows.Forms.TextBox txtDef;
        internal System.Windows.Forms.TextBox txtAtq;
        internal System.Windows.Forms.PictureBox pbImagem;
        internal System.Windows.Forms.Label lblImagem;
        internal System.Windows.Forms.Label lblPersonagens;
        internal System.Windows.Forms.Label lblJogo;
        internal System.Windows.Forms.ComboBox cmbPersonagens;
        private System.Windows.Forms.Button btnEstudar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnDescansar;
        internal System.Windows.Forms.Label lblPerVivos;
        internal System.Windows.Forms.Label lblPerVivosResult;
    }
}