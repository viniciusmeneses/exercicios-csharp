namespace prjViniciusBarbieri
{
    partial class frmMostraJuridica
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
            this.lblMostra = new System.Windows.Forms.Label();
            this.txtMostra = new System.Windows.Forms.TextBox();
            this.btnMostra = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMostra
            // 
            this.lblMostra.AutoSize = true;
            this.lblMostra.Location = new System.Drawing.Point(12, 65);
            this.lblMostra.Name = "lblMostra";
            this.lblMostra.Size = new System.Drawing.Size(42, 13);
            this.lblMostra.TabIndex = 0;
            this.lblMostra.Text = "Mostra:";
            // 
            // txtMostra
            // 
            this.txtMostra.Enabled = false;
            this.txtMostra.Location = new System.Drawing.Point(60, 62);
            this.txtMostra.Name = "txtMostra";
            this.txtMostra.ReadOnly = true;
            this.txtMostra.Size = new System.Drawing.Size(212, 20);
            this.txtMostra.TabIndex = 1;
            this.txtMostra.TextChanged += new System.EventHandler(this.txtMostra_TextChanged);
            // 
            // btnMostra
            // 
            this.btnMostra.Location = new System.Drawing.Point(60, 88);
            this.btnMostra.Name = "btnMostra";
            this.btnMostra.Size = new System.Drawing.Size(97, 32);
            this.btnMostra.TabIndex = 2;
            this.btnMostra.Text = "Mostra";
            this.btnMostra.UseVisualStyleBackColor = true;
            this.btnMostra.Click += new System.EventHandler(this.btnMostra_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(174, 88);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(98, 32);
            this.btnLimpa.TabIndex = 3;
            this.btnLimpa.Text = "Limpa";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitulo.Location = new System.Drawing.Point(46, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(198, 31);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Mostra Jurídica";
            // 
            // frmMostraJuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnMostra);
            this.Controls.Add(this.txtMostra);
            this.Controls.Add(this.lblMostra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMostraJuridica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostra Jurídica";
            this.Load += new System.EventHandler(this.frmMostra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMostra;
        private System.Windows.Forms.TextBox txtMostra;
        private System.Windows.Forms.Button btnMostra;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Label lblTitulo;
    }
}

