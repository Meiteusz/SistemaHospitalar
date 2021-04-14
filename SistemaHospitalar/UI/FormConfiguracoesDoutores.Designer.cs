
namespace SistemaHospitalar.UI
{
    partial class FormConfiguracoesDoutores
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
            this.cbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.txtMaskedCelularDoutor = new System.Windows.Forms.MaskedTextBox();
            this.cmbTurnoDoutor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRepetirSenhaDoutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenhaDoutor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailDoutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtualizarInformacoes = new System.Windows.Forms.Button();
            this.txtNomeDoutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMostrarSenha.Location = new System.Drawing.Point(644, 255);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(120, 21);
            this.cbMostrarSenha.TabIndex = 34;
            this.cbMostrarSenha.Text = "Mostrar Senha";
            this.cbMostrarSenha.UseVisualStyleBackColor = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.cbMostrarSenha_CheckedChanged);
            // 
            // txtMaskedCelularDoutor
            // 
            this.txtMaskedCelularDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaskedCelularDoutor.Location = new System.Drawing.Point(46, 289);
            this.txtMaskedCelularDoutor.Mask = "(00) 00000-0000";
            this.txtMaskedCelularDoutor.Name = "txtMaskedCelularDoutor";
            this.txtMaskedCelularDoutor.Size = new System.Drawing.Size(345, 26);
            this.txtMaskedCelularDoutor.TabIndex = 33;
            this.txtMaskedCelularDoutor.Click += new System.EventHandler(this.txtMaskedCelularDoutor_Click);
            // 
            // cmbTurnoDoutor
            // 
            this.cmbTurnoDoutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurnoDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurnoDoutor.FormattingEnabled = true;
            this.cmbTurnoDoutor.Location = new System.Drawing.Point(418, 142);
            this.cmbTurnoDoutor.Name = "cmbTurnoDoutor";
            this.cmbTurnoDoutor.Size = new System.Drawing.Size(344, 28);
            this.cmbTurnoDoutor.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(416, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Turno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(416, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Repita a senha";
            // 
            // txtRepetirSenhaDoutor
            // 
            this.txtRepetirSenhaDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepetirSenhaDoutor.Location = new System.Drawing.Point(420, 289);
            this.txtRepetirSenhaDoutor.Name = "txtRepetirSenhaDoutor";
            this.txtRepetirSenhaDoutor.Size = new System.Drawing.Size(344, 26);
            this.txtRepetirSenhaDoutor.TabIndex = 28;
            this.txtRepetirSenhaDoutor.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(415, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Senha";
            // 
            // txtSenhaDoutor
            // 
            this.txtSenhaDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaDoutor.Location = new System.Drawing.Point(418, 215);
            this.txtSenhaDoutor.Name = "txtSenhaDoutor";
            this.txtSenhaDoutor.Size = new System.Drawing.Size(344, 26);
            this.txtSenhaDoutor.TabIndex = 26;
            this.txtSenhaDoutor.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Celular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Email";
            // 
            // txtEmailDoutor
            // 
            this.txtEmailDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailDoutor.Location = new System.Drawing.Point(47, 215);
            this.txtEmailDoutor.Name = "txtEmailDoutor";
            this.txtEmailDoutor.Size = new System.Drawing.Size(344, 26);
            this.txtEmailDoutor.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nome";
            // 
            // btnAtualizarInformacoes
            // 
            this.btnAtualizarInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarInformacoes.Location = new System.Drawing.Point(307, 363);
            this.btnAtualizarInformacoes.Name = "btnAtualizarInformacoes";
            this.btnAtualizarInformacoes.Size = new System.Drawing.Size(200, 61);
            this.btnAtualizarInformacoes.TabIndex = 21;
            this.btnAtualizarInformacoes.Text = "Atualizar informações da conta";
            this.btnAtualizarInformacoes.UseVisualStyleBackColor = true;
            this.btnAtualizarInformacoes.Click += new System.EventHandler(this.btnAtualizarInformacoes_Click);
            // 
            // txtNomeDoutor
            // 
            this.txtNomeDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDoutor.Location = new System.Drawing.Point(47, 142);
            this.txtNomeDoutor.Name = "txtNomeDoutor";
            this.txtNomeDoutor.Size = new System.Drawing.Size(344, 26);
            this.txtNomeDoutor.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(234, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Informações da Conta";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = global::SistemaHospitalar.Properties.Resources.back_icon;
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(78, 52);
            this.btnVoltar.TabIndex = 35;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormConfiguracoesDoutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.cbMostrarSenha);
            this.Controls.Add(this.txtMaskedCelularDoutor);
            this.Controls.Add(this.cmbTurnoDoutor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRepetirSenhaDoutor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSenhaDoutor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmailDoutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAtualizarInformacoes);
            this.Controls.Add(this.txtNomeDoutor);
            this.Controls.Add(this.label1);
            this.Name = "FormConfiguracoesDoutores";
            this.Text = "FormConfiguracoesDoutores";
            this.Load += new System.EventHandler(this.FormConfiguracoesDoutores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.CheckBox cbMostrarSenha;
        private System.Windows.Forms.MaskedTextBox txtMaskedCelularDoutor;
        private System.Windows.Forms.ComboBox cmbTurnoDoutor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRepetirSenhaDoutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenhaDoutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailDoutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtualizarInformacoes;
        private System.Windows.Forms.TextBox txtNomeDoutor;
        private System.Windows.Forms.Label label1;
    }
}