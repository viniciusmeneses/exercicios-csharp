namespace prjExemploInterface
{
    partial class frmPaciente
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
            this.btnMostraPaciente = new System.Windows.Forms.Button();
            this.txtPaciente1 = new System.Windows.Forms.TextBox();
            this.txtPaciente2 = new System.Windows.Forms.TextBox();
            this.txtPaciente3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMostraPaciente
            // 
            this.btnMostraPaciente.Location = new System.Drawing.Point(86, 326);
            this.btnMostraPaciente.Name = "btnMostraPaciente";
            this.btnMostraPaciente.Size = new System.Drawing.Size(90, 40);
            this.btnMostraPaciente.TabIndex = 0;
            this.btnMostraPaciente.Text = "Mostra";
            this.btnMostraPaciente.UseVisualStyleBackColor = true;
            this.btnMostraPaciente.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPaciente1
            // 
            this.txtPaciente1.Location = new System.Drawing.Point(12, 41);
            this.txtPaciente1.Multiline = true;
            this.txtPaciente1.Name = "txtPaciente1";
            this.txtPaciente1.Size = new System.Drawing.Size(112, 167);
            this.txtPaciente1.TabIndex = 1;
            // 
            // txtPaciente2
            // 
            this.txtPaciente2.Location = new System.Drawing.Point(147, 41);
            this.txtPaciente2.Multiline = true;
            this.txtPaciente2.Name = "txtPaciente2";
            this.txtPaciente2.Size = new System.Drawing.Size(112, 167);
            this.txtPaciente2.TabIndex = 2;
            // 
            // txtPaciente3
            // 
            this.txtPaciente3.Location = new System.Drawing.Point(12, 236);
            this.txtPaciente3.Multiline = true;
            this.txtPaciente3.Name = "txtPaciente3";
            this.txtPaciente3.Size = new System.Drawing.Size(247, 63);
            this.txtPaciente3.TabIndex = 3;
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 378);
            this.Controls.Add(this.txtPaciente3);
            this.Controls.Add(this.txtPaciente2);
            this.Controls.Add(this.txtPaciente1);
            this.Controls.Add(this.btnMostraPaciente);
            this.Name = "frmPaciente";
            this.Text = "Mostra Pacientes";
            this.Load += new System.EventHandler(this.frmPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostraPaciente;
        private System.Windows.Forms.TextBox txtPaciente1;
        private System.Windows.Forms.TextBox txtPaciente2;
        private System.Windows.Forms.TextBox txtPaciente3;
    }
}

