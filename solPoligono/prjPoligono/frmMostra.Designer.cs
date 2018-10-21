namespace prjPoligono
{
    partial class frmMostra
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
            this.cmbFigura = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSelecione = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblExibeArea = new System.Windows.Forms.Label();
            this.lblExibePerimetro = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.lblToString = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFigura
            // 
            this.cmbFigura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFigura.FormattingEnabled = true;
            this.cmbFigura.Items.AddRange(new object[] {
            "Círculo",
            "Quadrado",
            "Retângulo",
            "Triângulo Isóceles",
            "Triângulo Escaleno",
            "Triângulo Equilátero",
            "Paralelogramo"});
            this.cmbFigura.Location = new System.Drawing.Point(135, 65);
            this.cmbFigura.Name = "cmbFigura";
            this.cmbFigura.Size = new System.Drawing.Size(204, 21);
            this.cmbFigura.TabIndex = 0;
            this.cmbFigura.SelectedIndexChanged += new System.EventHandler(this.cmbFigura_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitulo.Location = new System.Drawing.Point(82, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(176, 26);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Mostrar Poligono";
            // 
            // lblSelecione
            // 
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.Location = new System.Drawing.Point(12, 68);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(117, 13);
            this.lblSelecione.TabIndex = 2;
            this.lblSelecione.Text = "Selecione um poligono:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(3, 5);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "Área:";
            // 
            // lblExibeArea
            // 
            this.lblExibeArea.AutoSize = true;
            this.lblExibeArea.Location = new System.Drawing.Point(41, 5);
            this.lblExibeArea.Name = "lblExibeArea";
            this.lblExibeArea.Size = new System.Drawing.Size(80, 13);
            this.lblExibeArea.TabIndex = 4;
            this.lblExibeArea.Text = "Resultado Área\r\n";
            // 
            // lblExibePerimetro
            // 
            this.lblExibePerimetro.AutoSize = true;
            this.lblExibePerimetro.Location = new System.Drawing.Point(63, 22);
            this.lblExibePerimetro.Name = "lblExibePerimetro";
            this.lblExibePerimetro.Size = new System.Drawing.Size(102, 13);
            this.lblExibePerimetro.TabIndex = 6;
            this.lblExibePerimetro.Text = "Resultado Perimetro";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(3, 22);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(54, 13);
            this.lblPerimetro.TabIndex = 5;
            this.lblPerimetro.Text = "Perimetro:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.picImagem);
            this.panel1.Controls.Add(this.lblToString);
            this.panel1.Controls.Add(this.lblExibePerimetro);
            this.panel1.Controls.Add(this.lblPerimetro);
            this.panel1.Controls.Add(this.lblArea);
            this.panel1.Controls.Add(this.lblExibeArea);
            this.panel1.Location = new System.Drawing.Point(12, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 340);
            this.panel1.TabIndex = 7;
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(4, 60);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(323, 275);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 8;
            this.picImagem.TabStop = false;
            // 
            // lblToString
            // 
            this.lblToString.AutoSize = true;
            this.lblToString.Location = new System.Drawing.Point(3, 39);
            this.lblToString.Name = "lblToString";
            this.lblToString.Size = new System.Drawing.Size(47, 13);
            this.lblToString.TabIndex = 7;
            this.lblToString.Text = "ToString";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.IndianRed;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpar.Location = new System.Drawing.Point(124, 463);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(134, 41);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmMostra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(355, 516);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblSelecione);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmbFigura);
            this.Controls.Add(this.panel1);
            this.Name = "frmMostra";
            this.Text = "Mostrar Poligono";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFigura;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSelecione;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblExibeArea;
        private System.Windows.Forms.Label lblExibePerimetro;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Label lblToString;
        private System.Windows.Forms.Button btnLimpar;
    }
}

