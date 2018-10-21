namespace prjJogoLuta
{
    partial class frmLutar
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDefender = new System.Windows.Forms.Button();
            this.btnAtacar = new System.Windows.Forms.Button();
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
            this.lblVoce = new System.Windows.Forms.Label();
            this.lblOponente = new System.Windows.Forms.Label();
            this.txtAgiOponente = new System.Windows.Forms.TextBox();
            this.lblAgilidadeOponente = new System.Windows.Forms.Label();
            this.lblNivelOponente = new System.Windows.Forms.Label();
            this.lblExperienciaOponente = new System.Windows.Forms.Label();
            this.lblVidaOponente = new System.Windows.Forms.Label();
            this.lblDefesaOponente = new System.Windows.Forms.Label();
            this.lblAtaqueOponente = new System.Windows.Forms.Label();
            this.txtNivelOponente = new System.Windows.Forms.TextBox();
            this.txtExpOponente = new System.Windows.Forms.TextBox();
            this.txtVidaOponente = new System.Windows.Forms.TextBox();
            this.txtDefOponente = new System.Windows.Forms.TextBox();
            this.txtAtqOponente = new System.Windows.Forms.TextBox();
            this.pbImagemOponente = new System.Windows.Forms.PictureBox();
            this.lblImagemOponente = new System.Windows.Forms.Label();
            this.btnAndar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemOponente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(633, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(22, 23);
            this.btnExit.TabIndex = 62;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDefender
            // 
            this.btnDefender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDefender.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDefender.Location = new System.Drawing.Point(239, 450);
            this.btnDefender.Name = "btnDefender";
            this.btnDefender.Size = new System.Drawing.Size(178, 29);
            this.btnDefender.TabIndex = 79;
            this.btnDefender.Text = "Defender";
            this.btnDefender.UseVisualStyleBackColor = false;
            this.btnDefender.Click += new System.EventHandler(this.btnEstudar_Click);
            // 
            // btnAtacar
            // 
            this.btnAtacar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAtacar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtacar.Location = new System.Drawing.Point(17, 450);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(178, 29);
            this.btnAtacar.TabIndex = 78;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = false;
            this.btnAtacar.Click += new System.EventHandler(this.btnLutar_Click);
            // 
            // txtAgi
            // 
            this.txtAgi.Enabled = false;
            this.txtAgi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgi.Location = new System.Drawing.Point(121, 355);
            this.txtAgi.Name = "txtAgi";
            this.txtAgi.Size = new System.Drawing.Size(178, 26);
            this.txtAgi.TabIndex = 77;
            // 
            // lblAgilidade
            // 
            this.lblAgilidade.AutoSize = true;
            this.lblAgilidade.BackColor = System.Drawing.Color.Transparent;
            this.lblAgilidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgilidade.ForeColor = System.Drawing.Color.White;
            this.lblAgilidade.Location = new System.Drawing.Point(29, 358);
            this.lblAgilidade.Name = "lblAgilidade";
            this.lblAgilidade.Size = new System.Drawing.Size(86, 19);
            this.lblAgilidade.TabIndex = 76;
            this.lblAgilidade.Text = "Agilidade:";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.Color.White;
            this.lblNivel.Location = new System.Drawing.Point(62, 390);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(53, 19);
            this.lblNivel.TabIndex = 75;
            this.lblNivel.Text = "Nível:";
            // 
            // lblExperiencia
            // 
            this.lblExperiencia.AutoSize = true;
            this.lblExperiencia.BackColor = System.Drawing.Color.Transparent;
            this.lblExperiencia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperiencia.ForeColor = System.Drawing.Color.White;
            this.lblExperiencia.Location = new System.Drawing.Point(10, 326);
            this.lblExperiencia.Name = "lblExperiencia";
            this.lblExperiencia.Size = new System.Drawing.Size(105, 19);
            this.lblExperiencia.TabIndex = 74;
            this.lblExperiencia.Text = "Experiência:";
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.BackColor = System.Drawing.Color.Transparent;
            this.lblVida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVida.ForeColor = System.Drawing.Color.White;
            this.lblVida.Location = new System.Drawing.Point(66, 294);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(49, 19);
            this.lblVida.TabIndex = 73;
            this.lblVida.Text = "Vida:";
            // 
            // lblDefesa
            // 
            this.lblDefesa.AutoSize = true;
            this.lblDefesa.BackColor = System.Drawing.Color.Transparent;
            this.lblDefesa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefesa.ForeColor = System.Drawing.Color.White;
            this.lblDefesa.Location = new System.Drawing.Point(47, 262);
            this.lblDefesa.Name = "lblDefesa";
            this.lblDefesa.Size = new System.Drawing.Size(68, 19);
            this.lblDefesa.TabIndex = 72;
            this.lblDefesa.Text = "Defesa:";
            // 
            // lblAtaque
            // 
            this.lblAtaque.AutoSize = true;
            this.lblAtaque.BackColor = System.Drawing.Color.Transparent;
            this.lblAtaque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtaque.ForeColor = System.Drawing.Color.White;
            this.lblAtaque.Location = new System.Drawing.Point(46, 230);
            this.lblAtaque.Name = "lblAtaque";
            this.lblAtaque.Size = new System.Drawing.Size(69, 19);
            this.lblAtaque.TabIndex = 71;
            this.lblAtaque.Text = "Ataque:";
            // 
            // txtNivel
            // 
            this.txtNivel.Enabled = false;
            this.txtNivel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivel.Location = new System.Drawing.Point(121, 387);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(178, 26);
            this.txtNivel.TabIndex = 70;
            // 
            // txtExp
            // 
            this.txtExp.Enabled = false;
            this.txtExp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExp.Location = new System.Drawing.Point(121, 323);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(178, 26);
            this.txtExp.TabIndex = 69;
            // 
            // txtVida
            // 
            this.txtVida.Enabled = false;
            this.txtVida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVida.Location = new System.Drawing.Point(121, 291);
            this.txtVida.Name = "txtVida";
            this.txtVida.Size = new System.Drawing.Size(178, 26);
            this.txtVida.TabIndex = 68;
            // 
            // txtDef
            // 
            this.txtDef.Enabled = false;
            this.txtDef.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDef.Location = new System.Drawing.Point(121, 259);
            this.txtDef.Name = "txtDef";
            this.txtDef.Size = new System.Drawing.Size(178, 26);
            this.txtDef.TabIndex = 67;
            // 
            // txtAtq
            // 
            this.txtAtq.Enabled = false;
            this.txtAtq.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtq.Location = new System.Drawing.Point(121, 227);
            this.txtAtq.Name = "txtAtq";
            this.txtAtq.Size = new System.Drawing.Size(178, 26);
            this.txtAtq.TabIndex = 66;
            // 
            // pbImagem
            // 
            this.pbImagem.BackColor = System.Drawing.Color.Transparent;
            this.pbImagem.Location = new System.Drawing.Point(121, 69);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(178, 152);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 65;
            this.pbImagem.TabStop = false;
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.BackColor = System.Drawing.Color.Transparent;
            this.lblImagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagem.ForeColor = System.Drawing.Color.White;
            this.lblImagem.Location = new System.Drawing.Point(40, 69);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(75, 19);
            this.lblImagem.TabIndex = 64;
            this.lblImagem.Text = "Imagem:";
            // 
            // lblVoce
            // 
            this.lblVoce.AutoSize = true;
            this.lblVoce.BackColor = System.Drawing.Color.Transparent;
            this.lblVoce.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoce.ForeColor = System.Drawing.Color.Red;
            this.lblVoce.Location = new System.Drawing.Point(180, 23);
            this.lblVoce.Name = "lblVoce";
            this.lblVoce.Size = new System.Drawing.Size(58, 24);
            this.lblVoce.TabIndex = 81;
            this.lblVoce.Text = "Você";
            // 
            // lblOponente
            // 
            this.lblOponente.AutoSize = true;
            this.lblOponente.BackColor = System.Drawing.Color.Transparent;
            this.lblOponente.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOponente.ForeColor = System.Drawing.Color.Red;
            this.lblOponente.Location = new System.Drawing.Point(495, 23);
            this.lblOponente.Name = "lblOponente";
            this.lblOponente.Size = new System.Drawing.Size(109, 24);
            this.lblOponente.TabIndex = 99;
            this.lblOponente.Text = "Oponente";
            // 
            // txtAgiOponente
            // 
            this.txtAgiOponente.Enabled = false;
            this.txtAgiOponente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgiOponente.Location = new System.Drawing.Point(459, 355);
            this.txtAgiOponente.Name = "txtAgiOponente";
            this.txtAgiOponente.Size = new System.Drawing.Size(178, 26);
            this.txtAgiOponente.TabIndex = 95;
            // 
            // lblAgilidadeOponente
            // 
            this.lblAgilidadeOponente.AutoSize = true;
            this.lblAgilidadeOponente.BackColor = System.Drawing.Color.Transparent;
            this.lblAgilidadeOponente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgilidadeOponente.ForeColor = System.Drawing.Color.White;
            this.lblAgilidadeOponente.Location = new System.Drawing.Point(367, 358);
            this.lblAgilidadeOponente.Name = "lblAgilidadeOponente";
            this.lblAgilidadeOponente.Size = new System.Drawing.Size(86, 19);
            this.lblAgilidadeOponente.TabIndex = 94;
            this.lblAgilidadeOponente.Text = "Agilidade:";
            // 
            // lblNivelOponente
            // 
            this.lblNivelOponente.AutoSize = true;
            this.lblNivelOponente.BackColor = System.Drawing.Color.Transparent;
            this.lblNivelOponente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelOponente.ForeColor = System.Drawing.Color.White;
            this.lblNivelOponente.Location = new System.Drawing.Point(400, 390);
            this.lblNivelOponente.Name = "lblNivelOponente";
            this.lblNivelOponente.Size = new System.Drawing.Size(53, 19);
            this.lblNivelOponente.TabIndex = 93;
            this.lblNivelOponente.Text = "Nível:";
            // 
            // lblExperienciaOponente
            // 
            this.lblExperienciaOponente.AutoSize = true;
            this.lblExperienciaOponente.BackColor = System.Drawing.Color.Transparent;
            this.lblExperienciaOponente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperienciaOponente.ForeColor = System.Drawing.Color.White;
            this.lblExperienciaOponente.Location = new System.Drawing.Point(348, 326);
            this.lblExperienciaOponente.Name = "lblExperienciaOponente";
            this.lblExperienciaOponente.Size = new System.Drawing.Size(105, 19);
            this.lblExperienciaOponente.TabIndex = 92;
            this.lblExperienciaOponente.Text = "Experiência:";
            // 
            // lblVidaOponente
            // 
            this.lblVidaOponente.AutoSize = true;
            this.lblVidaOponente.BackColor = System.Drawing.Color.Transparent;
            this.lblVidaOponente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidaOponente.ForeColor = System.Drawing.Color.White;
            this.lblVidaOponente.Location = new System.Drawing.Point(404, 294);
            this.lblVidaOponente.Name = "lblVidaOponente";
            this.lblVidaOponente.Size = new System.Drawing.Size(49, 19);
            this.lblVidaOponente.TabIndex = 91;
            this.lblVidaOponente.Text = "Vida:";
            // 
            // lblDefesaOponente
            // 
            this.lblDefesaOponente.AutoSize = true;
            this.lblDefesaOponente.BackColor = System.Drawing.Color.Transparent;
            this.lblDefesaOponente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefesaOponente.ForeColor = System.Drawing.Color.White;
            this.lblDefesaOponente.Location = new System.Drawing.Point(385, 262);
            this.lblDefesaOponente.Name = "lblDefesaOponente";
            this.lblDefesaOponente.Size = new System.Drawing.Size(68, 19);
            this.lblDefesaOponente.TabIndex = 90;
            this.lblDefesaOponente.Text = "Defesa:";
            // 
            // lblAtaqueOponente
            // 
            this.lblAtaqueOponente.AutoSize = true;
            this.lblAtaqueOponente.BackColor = System.Drawing.Color.Transparent;
            this.lblAtaqueOponente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtaqueOponente.ForeColor = System.Drawing.Color.White;
            this.lblAtaqueOponente.Location = new System.Drawing.Point(384, 230);
            this.lblAtaqueOponente.Name = "lblAtaqueOponente";
            this.lblAtaqueOponente.Size = new System.Drawing.Size(69, 19);
            this.lblAtaqueOponente.TabIndex = 89;
            this.lblAtaqueOponente.Text = "Ataque:";
            // 
            // txtNivelOponente
            // 
            this.txtNivelOponente.Enabled = false;
            this.txtNivelOponente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivelOponente.Location = new System.Drawing.Point(459, 387);
            this.txtNivelOponente.Name = "txtNivelOponente";
            this.txtNivelOponente.Size = new System.Drawing.Size(178, 26);
            this.txtNivelOponente.TabIndex = 88;
            // 
            // txtExpOponente
            // 
            this.txtExpOponente.Enabled = false;
            this.txtExpOponente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpOponente.Location = new System.Drawing.Point(459, 323);
            this.txtExpOponente.Name = "txtExpOponente";
            this.txtExpOponente.Size = new System.Drawing.Size(178, 26);
            this.txtExpOponente.TabIndex = 87;
            // 
            // txtVidaOponente
            // 
            this.txtVidaOponente.Enabled = false;
            this.txtVidaOponente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVidaOponente.Location = new System.Drawing.Point(459, 291);
            this.txtVidaOponente.Name = "txtVidaOponente";
            this.txtVidaOponente.Size = new System.Drawing.Size(178, 26);
            this.txtVidaOponente.TabIndex = 86;
            // 
            // txtDefOponente
            // 
            this.txtDefOponente.Enabled = false;
            this.txtDefOponente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefOponente.Location = new System.Drawing.Point(459, 259);
            this.txtDefOponente.Name = "txtDefOponente";
            this.txtDefOponente.Size = new System.Drawing.Size(178, 26);
            this.txtDefOponente.TabIndex = 85;
            // 
            // txtAtqOponente
            // 
            this.txtAtqOponente.Enabled = false;
            this.txtAtqOponente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtqOponente.Location = new System.Drawing.Point(459, 227);
            this.txtAtqOponente.Name = "txtAtqOponente";
            this.txtAtqOponente.Size = new System.Drawing.Size(178, 26);
            this.txtAtqOponente.TabIndex = 84;
            // 
            // pbImagemOponente
            // 
            this.pbImagemOponente.BackColor = System.Drawing.Color.Transparent;
            this.pbImagemOponente.Location = new System.Drawing.Point(459, 69);
            this.pbImagemOponente.Name = "pbImagemOponente";
            this.pbImagemOponente.Size = new System.Drawing.Size(178, 152);
            this.pbImagemOponente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemOponente.TabIndex = 83;
            this.pbImagemOponente.TabStop = false;
            // 
            // lblImagemOponente
            // 
            this.lblImagemOponente.AutoSize = true;
            this.lblImagemOponente.BackColor = System.Drawing.Color.Transparent;
            this.lblImagemOponente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemOponente.ForeColor = System.Drawing.Color.White;
            this.lblImagemOponente.Location = new System.Drawing.Point(378, 69);
            this.lblImagemOponente.Name = "lblImagemOponente";
            this.lblImagemOponente.Size = new System.Drawing.Size(75, 19);
            this.lblImagemOponente.TabIndex = 82;
            this.lblImagemOponente.Text = "Imagem:";
            // 
            // btnAndar
            // 
            this.btnAndar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAndar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAndar.Location = new System.Drawing.Point(454, 450);
            this.btnAndar.Name = "btnAndar";
            this.btnAndar.Size = new System.Drawing.Size(178, 29);
            this.btnAndar.TabIndex = 100;
            this.btnAndar.Text = "Andar";
            this.btnAndar.UseVisualStyleBackColor = false;
            this.btnAndar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Location = new System.Drawing.Point(12, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 42);
            this.panel1.TabIndex = 101;
            // 
            // frmLutar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjJogoLuta.Properties.Resources.castlevania_lords_of_shadow_2_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 498);
            this.ControlBox = false;
            this.Controls.Add(this.btnAndar);
            this.Controls.Add(this.lblOponente);
            this.Controls.Add(this.txtAgiOponente);
            this.Controls.Add(this.lblAgilidadeOponente);
            this.Controls.Add(this.lblNivelOponente);
            this.Controls.Add(this.lblExperienciaOponente);
            this.Controls.Add(this.lblVidaOponente);
            this.Controls.Add(this.lblDefesaOponente);
            this.Controls.Add(this.lblAtaqueOponente);
            this.Controls.Add(this.txtNivelOponente);
            this.Controls.Add(this.txtExpOponente);
            this.Controls.Add(this.txtVidaOponente);
            this.Controls.Add(this.txtDefOponente);
            this.Controls.Add(this.txtAtqOponente);
            this.Controls.Add(this.pbImagemOponente);
            this.Controls.Add(this.lblImagemOponente);
            this.Controls.Add(this.lblVoce);
            this.Controls.Add(this.btnDefender);
            this.Controls.Add(this.btnAtacar);
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
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Name = "frmLutar";
            this.Text = "Lutando...";
            this.Load += new System.EventHandler(this.frmLutar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemOponente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDefender;
        internal System.Windows.Forms.Button btnAtacar;
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
        internal System.Windows.Forms.Label lblVoce;
        internal System.Windows.Forms.Label lblOponente;
        internal System.Windows.Forms.TextBox txtAgiOponente;
        internal System.Windows.Forms.Label lblAgilidadeOponente;
        internal System.Windows.Forms.Label lblNivelOponente;
        internal System.Windows.Forms.Label lblExperienciaOponente;
        internal System.Windows.Forms.Label lblVidaOponente;
        internal System.Windows.Forms.Label lblDefesaOponente;
        internal System.Windows.Forms.Label lblAtaqueOponente;
        internal System.Windows.Forms.TextBox txtNivelOponente;
        internal System.Windows.Forms.TextBox txtExpOponente;
        internal System.Windows.Forms.TextBox txtVidaOponente;
        internal System.Windows.Forms.TextBox txtDefOponente;
        internal System.Windows.Forms.TextBox txtAtqOponente;
        internal System.Windows.Forms.PictureBox pbImagemOponente;
        internal System.Windows.Forms.Label lblImagemOponente;
        private System.Windows.Forms.Button btnAndar;
        private System.Windows.Forms.Panel panel1;
    }
}