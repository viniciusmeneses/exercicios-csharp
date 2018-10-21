namespace prjExemploStatic
{
    partial class frmExemploStatic
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
            this.btnCria = new System.Windows.Forms.Button();
            this.btnApaga = new System.Windows.Forms.Button();
            this.lblNroClientes = new System.Windows.Forms.Label();
            this.txtNroClientes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCria
            // 
            this.btnCria.Location = new System.Drawing.Point(39, 209);
            this.btnCria.Name = "btnCria";
            this.btnCria.Size = new System.Drawing.Size(75, 23);
            this.btnCria.TabIndex = 0;
            this.btnCria.Text = "Cria";
            this.btnCria.UseVisualStyleBackColor = true;
            this.btnCria.Click += new System.EventHandler(this.btnCria_Click);
            // 
            // btnApaga
            // 
            this.btnApaga.Location = new System.Drawing.Point(160, 209);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(75, 23);
            this.btnApaga.TabIndex = 1;
            this.btnApaga.Text = "Apaga";
            this.btnApaga.UseVisualStyleBackColor = true;
            this.btnApaga.Click += new System.EventHandler(this.btnApaga_Click);
            // 
            // lblNroClientes
            // 
            this.lblNroClientes.AutoSize = true;
            this.lblNroClientes.Location = new System.Drawing.Point(39, 70);
            this.lblNroClientes.Name = "lblNroClientes";
            this.lblNroClientes.Size = new System.Drawing.Size(105, 13);
            this.lblNroClientes.TabIndex = 2;
            this.lblNroClientes.Text = "Número de Clientes: ";
            // 
            // txtNroClientes
            // 
            this.txtNroClientes.Enabled = false;
            this.txtNroClientes.Location = new System.Drawing.Point(150, 70);
            this.txtNroClientes.Name = "txtNroClientes";
            this.txtNroClientes.Size = new System.Drawing.Size(31, 20);
            this.txtNroClientes.TabIndex = 3;
            this.txtNroClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmExemploStatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtNroClientes);
            this.Controls.Add(this.lblNroClientes);
            this.Controls.Add(this.btnApaga);
            this.Controls.Add(this.btnCria);
            this.Name = "frmExemploStatic";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmExemploStatic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCria;
        private System.Windows.Forms.Button btnApaga;
        private System.Windows.Forms.Label lblNroClientes;
        private System.Windows.Forms.TextBox txtNroClientes;
    }
}

