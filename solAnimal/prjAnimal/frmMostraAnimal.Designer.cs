namespace prjAnimal
{
    partial class frmMostraAnimal
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
            this.lblEscolhaAnimal = new System.Windows.Forms.Label();
            this.cmbEscolhaAnimal = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtHabitat = new System.Windows.Forms.TextBox();
            this.lblHabitat = new System.Windows.Forms.Label();
            this.txtRegiao = new System.Windows.Forms.TextBox();
            this.lblRegiao = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            this.imgFoto = new System.Windows.Forms.PictureBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEscolhaAnimal
            // 
            this.lblEscolhaAnimal.AutoSize = true;
            this.lblEscolhaAnimal.Location = new System.Drawing.Point(13, 13);
            this.lblEscolhaAnimal.Name = "lblEscolhaAnimal";
            this.lblEscolhaAnimal.Size = new System.Drawing.Size(98, 13);
            this.lblEscolhaAnimal.TabIndex = 0;
            this.lblEscolhaAnimal.Text = "Escolha um animal:";
            // 
            // cmbEscolhaAnimal
            // 
            this.cmbEscolhaAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEscolhaAnimal.FormattingEnabled = true;
            this.cmbEscolhaAnimal.Items.AddRange(new object[] {
            "Lobo",
            "Tigre",
            "Galinha"});
            this.cmbEscolhaAnimal.Location = new System.Drawing.Point(117, 10);
            this.cmbEscolhaAnimal.Name = "cmbEscolhaAnimal";
            this.cmbEscolhaAnimal.Size = new System.Drawing.Size(121, 21);
            this.cmbEscolhaAnimal.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 101);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(117, 98);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtHabitat
            // 
            this.txtHabitat.Location = new System.Drawing.Point(117, 124);
            this.txtHabitat.Name = "txtHabitat";
            this.txtHabitat.Size = new System.Drawing.Size(121, 20);
            this.txtHabitat.TabIndex = 5;
            // 
            // lblHabitat
            // 
            this.lblHabitat.AutoSize = true;
            this.lblHabitat.Location = new System.Drawing.Point(13, 127);
            this.lblHabitat.Name = "lblHabitat";
            this.lblHabitat.Size = new System.Drawing.Size(44, 13);
            this.lblHabitat.TabIndex = 4;
            this.lblHabitat.Text = "Habitat:";
            // 
            // txtRegiao
            // 
            this.txtRegiao.Location = new System.Drawing.Point(117, 150);
            this.txtRegiao.Name = "txtRegiao";
            this.txtRegiao.Size = new System.Drawing.Size(121, 20);
            this.txtRegiao.TabIndex = 7;
            // 
            // lblRegiao
            // 
            this.lblRegiao.AutoSize = true;
            this.lblRegiao.Location = new System.Drawing.Point(13, 153);
            this.lblRegiao.Name = "lblRegiao";
            this.lblRegiao.Size = new System.Drawing.Size(44, 13);
            this.lblRegiao.TabIndex = 6;
            this.lblRegiao.Text = "Região:";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(13, 178);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(31, 13);
            this.lblFoto.TabIndex = 8;
            this.lblFoto.Text = "Foto:";
            this.lblFoto.Click += new System.EventHandler(this.label5_Click);
            // 
            // imgFoto
            // 
            this.imgFoto.Location = new System.Drawing.Point(117, 178);
            this.imgFoto.Name = "imgFoto";
            this.imgFoto.Size = new System.Drawing.Size(121, 84);
            this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFoto.TabIndex = 9;
            this.imgFoto.TabStop = false;
            this.imgFoto.Click += new System.EventHandler(this.imgFoto_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(59, 37);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(140, 26);
            this.btnMostrar.TabIndex = 10;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // frmMostraAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(256, 269);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.imgFoto);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.txtRegiao);
            this.Controls.Add(this.lblRegiao);
            this.Controls.Add(this.txtHabitat);
            this.Controls.Add(this.lblHabitat);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.cmbEscolhaAnimal);
            this.Controls.Add(this.lblEscolhaAnimal);
            this.Name = "frmMostraAnimal";
            this.Text = "Mostrar Animal";
            this.Load += new System.EventHandler(this.frmMostraAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEscolhaAnimal;
        private System.Windows.Forms.ComboBox cmbEscolhaAnimal;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtHabitat;
        private System.Windows.Forms.Label lblHabitat;
        private System.Windows.Forms.TextBox txtRegiao;
        private System.Windows.Forms.Label lblRegiao;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.PictureBox imgFoto;
        private System.Windows.Forms.Button btnMostrar;
    }
}

