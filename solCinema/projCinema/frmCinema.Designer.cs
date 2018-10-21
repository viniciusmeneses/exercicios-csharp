namespace projCinema
{
    partial class frmCinema
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
            this.dgvFilme = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilme)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFilme
            // 
            this.dgvFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome});
            this.dgvFilme.Location = new System.Drawing.Point(12, 12);
            this.dgvFilme.Name = "dgvFilme";
            this.dgvFilme.Size = new System.Drawing.Size(336, 270);
            this.dgvFilme.TabIndex = 0;
            this.dgvFilme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilme_CellContentClick);
            this.dgvFilme.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilme_CellEndEdit);
            this.dgvFilme.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilme_CellValueChanged);
            this.dgvFilme.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilme_RowEnter);
            this.dgvFilme.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilme_RowLeave);
            this.dgvFilme.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvFilme_RowsAdded);
            this.dgvFilme.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvFilme_RowsRemoved);
            this.dgvFilme.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvFilme_UserAddedRow);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "CODIGO";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "NOME";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // frmCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 294);
            this.Controls.Add(this.dgvFilme);
            this.Name = "frmCinema";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCinema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilme;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
    }
}

