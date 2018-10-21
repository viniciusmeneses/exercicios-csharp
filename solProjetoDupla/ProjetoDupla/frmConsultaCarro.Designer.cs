namespace ProjetoDupla
{
    partial class frmConsultaCarro
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
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.txtRegistroConsulta = new System.Windows.Forms.TextBox();
            this.lblRegistroConsulta = new System.Windows.Forms.Label();
            this.btnCancelarConsulta = new System.Windows.Forms.Button();
            this.btnOkConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(30, 15);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(227, 24);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Gerenciamento de Carros";
            // 
            // txtRegistroConsulta
            // 
            this.txtRegistroConsulta.Location = new System.Drawing.Point(159, 75);
            this.txtRegistroConsulta.MaxLength = 8;
            this.txtRegistroConsulta.Name = "txtRegistroConsulta";
            this.txtRegistroConsulta.Size = new System.Drawing.Size(98, 20);
            this.txtRegistroConsulta.TabIndex = 28;
            // 
            // lblRegistroConsulta
            // 
            this.lblRegistroConsulta.AutoSize = true;
            this.lblRegistroConsulta.Location = new System.Drawing.Point(25, 78);
            this.lblRegistroConsulta.Name = "lblRegistroConsulta";
            this.lblRegistroConsulta.Size = new System.Drawing.Size(126, 13);
            this.lblRegistroConsulta.TabIndex = 27;
            this.lblRegistroConsulta.Text = "Digite o registro do Carro:";
            // 
            // btnCancelarConsulta
            // 
            this.btnCancelarConsulta.Location = new System.Drawing.Point(159, 104);
            this.btnCancelarConsulta.Name = "btnCancelarConsulta";
            this.btnCancelarConsulta.Size = new System.Drawing.Size(98, 36);
            this.btnCancelarConsulta.TabIndex = 30;
            this.btnCancelarConsulta.Text = "Cancelar";
            this.btnCancelarConsulta.UseVisualStyleBackColor = true;
            this.btnCancelarConsulta.Click += new System.EventHandler(this.btnCancelarConsulta_Click);
            // 
            // btnOkConsulta
            // 
            this.btnOkConsulta.Location = new System.Drawing.Point(28, 104);
            this.btnOkConsulta.Name = "btnOkConsulta";
            this.btnOkConsulta.Size = new System.Drawing.Size(98, 36);
            this.btnOkConsulta.TabIndex = 29;
            this.btnOkConsulta.Text = "OK";
            this.btnOkConsulta.UseVisualStyleBackColor = true;
            this.btnOkConsulta.Click += new System.EventHandler(this.btnOkConsulta_Click);
            // 
            // frmConsultaCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(284, 156);
            this.Controls.Add(this.btnCancelarConsulta);
            this.Controls.Add(this.btnOkConsulta);
            this.Controls.Add(this.txtRegistroConsulta);
            this.Controls.Add(this.lblRegistroConsulta);
            this.Controls.Add(this.lblSubtitulo);
            this.Name = "frmConsultaCarro";
            this.Text = "Consultar Carro";
            this.Load += new System.EventHandler(this.frmConsultaCarro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtitulo;
        public System.Windows.Forms.TextBox txtRegistroConsulta;
        private System.Windows.Forms.Label lblRegistroConsulta;
        private System.Windows.Forms.Button btnCancelarConsulta;
        private System.Windows.Forms.Button btnOkConsulta;
    }
}