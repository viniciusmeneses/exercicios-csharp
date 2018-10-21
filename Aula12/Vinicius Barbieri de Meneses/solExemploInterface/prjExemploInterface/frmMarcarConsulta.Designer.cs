namespace prjExemploInterface
{
    partial class frmMarcarConsulta
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
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.dtpDataConsulta = new System.Windows.Forms.DateTimePicker();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblDataDaConsulta = new System.Windows.Forms.Label();
            this.lblSintomas = new System.Windows.Forms.Label();
            this.lblAvaliacao = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtAvaliacao = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Items.AddRange(new object[] {
            "Vinicius (Sócio) - 17 anos",
            "Futrica (Animal) - 9 anos"});
            this.cmbPaciente.Location = new System.Drawing.Point(128, 48);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(236, 21);
            this.cmbPaciente.TabIndex = 0;
            this.cmbPaciente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtpDataConsulta
            // 
            this.dtpDataConsulta.CustomFormat = "";
            this.dtpDataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataConsulta.Location = new System.Drawing.Point(128, 271);
            this.dtpDataConsulta.MaxDate = new System.DateTime(9998, 1, 1, 0, 0, 0, 0);
            this.dtpDataConsulta.MinDate = new System.DateTime(2018, 6, 7, 0, 0, 0, 0);
            this.dtpDataConsulta.Name = "dtpDataConsulta";
            this.dtpDataConsulta.Size = new System.Drawing.Size(236, 20);
            this.dtpDataConsulta.TabIndex = 1;
            this.dtpDataConsulta.Value = new System.DateTime(2018, 6, 7, 0, 0, 0, 0);
            // 
            // txtSintomas
            // 
            this.txtSintomas.Location = new System.Drawing.Point(128, 82);
            this.txtSintomas.Multiline = true;
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(236, 82);
            this.txtSintomas.TabIndex = 2;
            this.txtSintomas.TextChanged += new System.EventHandler(this.txtSintomas_TextChanged);
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(12, 51);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(110, 13);
            this.lblPaciente.TabIndex = 4;
            this.lblPaciente.Text = "Selecione o paciente:";
            // 
            // lblDataDaConsulta
            // 
            this.lblDataDaConsulta.AutoSize = true;
            this.lblDataDaConsulta.Location = new System.Drawing.Point(12, 275);
            this.lblDataDaConsulta.Name = "lblDataDaConsulta";
            this.lblDataDaConsulta.Size = new System.Drawing.Size(91, 13);
            this.lblDataDaConsulta.TabIndex = 5;
            this.lblDataDaConsulta.Text = "Data da consulta:";
            // 
            // lblSintomas
            // 
            this.lblSintomas.AutoSize = true;
            this.lblSintomas.Location = new System.Drawing.Point(12, 85);
            this.lblSintomas.Name = "lblSintomas";
            this.lblSintomas.Size = new System.Drawing.Size(53, 13);
            this.lblSintomas.TabIndex = 6;
            this.lblSintomas.Text = "Sintomas:";
            // 
            // lblAvaliacao
            // 
            this.lblAvaliacao.AutoSize = true;
            this.lblAvaliacao.Location = new System.Drawing.Point(12, 181);
            this.lblAvaliacao.Name = "lblAvaliacao";
            this.lblAvaliacao.Size = new System.Drawing.Size(57, 13);
            this.lblAvaliacao.TabIndex = 7;
            this.lblAvaliacao.Text = "Avaliação:";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(12, 352);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(48, 13);
            this.lblMedico.TabIndex = 8;
            this.lblMedico.Text = "Médico: ";
            // 
            // btnMarcar
            // 
            this.btnMarcar.BackColor = System.Drawing.Color.Peru;
            this.btnMarcar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMarcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcar.Location = new System.Drawing.Point(128, 302);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(236, 44);
            this.btnMarcar.TabIndex = 9;
            this.btnMarcar.Text = "Marcar";
            this.btnMarcar.UseVisualStyleBackColor = false;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(123, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(140, 20);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Marcar Consulta";
            // 
            // txtAvaliacao
            // 
            this.txtAvaliacao.Location = new System.Drawing.Point(128, 177);
            this.txtAvaliacao.Multiline = true;
            this.txtAvaliacao.Name = "txtAvaliacao";
            this.txtAvaliacao.Size = new System.Drawing.Size(236, 82);
            this.txtAvaliacao.TabIndex = 11;
            this.txtAvaliacao.TextChanged += new System.EventHandler(this.txtAvaliacao_TextChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFechar.Location = new System.Drawing.Point(359, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(19, 23);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmMarcarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(379, 374);
            this.ControlBox = false;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtAvaliacao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnMarcar);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.lblAvaliacao);
            this.Controls.Add(this.lblSintomas);
            this.Controls.Add(this.lblDataDaConsulta);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.txtSintomas);
            this.Controls.Add(this.dtpDataConsulta);
            this.Controls.Add(this.cmbPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMarcarConsulta";
            this.Text = "Marcar Consulta";
            this.Load += new System.EventHandler(this.frmMarcarConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.DateTimePicker dtpDataConsulta;
        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblDataDaConsulta;
        private System.Windows.Forms.Label lblSintomas;
        private System.Windows.Forms.Label lblAvaliacao;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtAvaliacao;
        private System.Windows.Forms.Button btnFechar;
    }
}