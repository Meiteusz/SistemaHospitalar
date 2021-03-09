
namespace SistemaHospitalar.Views
{
    partial class FormCadastroDoutor
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
            this.txtMaskedCelularDoutor = new System.Windows.Forms.MaskedTextBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.cbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.txtMaskedCpfDoutor = new System.Windows.Forms.MaskedTextBox();
            this.cmbGeneroDoutor = new System.Windows.Forms.ComboBox();
            this.cmbTurnoDoutor = new System.Windows.Forms.ComboBox();
            this.btnCadastrarDoutor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRepitaSenhaDoutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailDoutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenhaDoutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeDoutor = new System.Windows.Forms.TextBox();
            this.cmbEspecialidadeDoutor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMaskedCelularDoutor
            // 
            this.txtMaskedCelularDoutor.BeepOnError = true;
            this.txtMaskedCelularDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaskedCelularDoutor.Location = new System.Drawing.Point(422, 387);
            this.txtMaskedCelularDoutor.Mask = "(00) 00000-0000";
            this.txtMaskedCelularDoutor.Name = "txtMaskedCelularDoutor";
            this.txtMaskedCelularDoutor.Size = new System.Drawing.Size(336, 30);
            this.txtMaskedCelularDoutor.TabIndex = 49;
            this.txtMaskedCelularDoutor.Click += new System.EventHandler(this.txtMaskedCelularDoutor_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(41, 404);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(160, 65);
            this.btnApagar.TabIndex = 48;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMostrarSenha.Location = new System.Drawing.Point(253, 278);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(133, 24);
            this.cbMostrarSenha.TabIndex = 47;
            this.cbMostrarSenha.Text = "Mostrar Senha";
            this.cbMostrarSenha.UseVisualStyleBackColor = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.cbMostrarSenha_CheckedChanged);
            // 
            // txtMaskedCpfDoutor
            // 
            this.txtMaskedCpfDoutor.BeepOnError = true;
            this.txtMaskedCpfDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaskedCpfDoutor.Location = new System.Drawing.Point(422, 113);
            this.txtMaskedCpfDoutor.Mask = "000.000.000-00";
            this.txtMaskedCpfDoutor.Name = "txtMaskedCpfDoutor";
            this.txtMaskedCpfDoutor.Size = new System.Drawing.Size(336, 30);
            this.txtMaskedCpfDoutor.TabIndex = 46;
            this.txtMaskedCpfDoutor.Click += new System.EventHandler(this.txtMaskedCpfDoutor_Click);
            // 
            // cmbGeneroDoutor
            // 
            this.cmbGeneroDoutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneroDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGeneroDoutor.FormattingEnabled = true;
            this.cmbGeneroDoutor.Location = new System.Drawing.Point(422, 246);
            this.cmbGeneroDoutor.Name = "cmbGeneroDoutor";
            this.cmbGeneroDoutor.Size = new System.Drawing.Size(336, 33);
            this.cmbGeneroDoutor.TabIndex = 45;
            // 
            // cmbTurnoDoutor
            // 
            this.cmbTurnoDoutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurnoDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurnoDoutor.FormattingEnabled = true;
            this.cmbTurnoDoutor.Items.AddRange(new object[] {
            "Selecione"});
            this.cmbTurnoDoutor.Location = new System.Drawing.Point(422, 175);
            this.cmbTurnoDoutor.Name = "cmbTurnoDoutor";
            this.cmbTurnoDoutor.Size = new System.Drawing.Size(336, 33);
            this.cmbTurnoDoutor.TabIndex = 44;
            // 
            // btnCadastrarDoutor
            // 
            this.btnCadastrarDoutor.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarDoutor.Location = new System.Drawing.Point(218, 404);
            this.btnCadastrarDoutor.Name = "btnCadastrarDoutor";
            this.btnCadastrarDoutor.Size = new System.Drawing.Size(160, 65);
            this.btnCadastrarDoutor.TabIndex = 43;
            this.btnCadastrarDoutor.Text = "Cadastrar Recepcionista";
            this.btnCadastrarDoutor.UseVisualStyleBackColor = true;
            this.btnCadastrarDoutor.Click += new System.EventHandler(this.btnCadastrarDoutor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(423, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "Genero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(423, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "Turno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(423, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 39;
            this.label8.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Repita a Senha";
            // 
            // txtRepitaSenhaDoutor
            // 
            this.txtRepitaSenhaDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepitaSenhaDoutor.Location = new System.Drawing.Point(41, 310);
            this.txtRepitaSenhaDoutor.Name = "txtRepitaSenhaDoutor";
            this.txtRepitaSenhaDoutor.Size = new System.Drawing.Size(336, 30);
            this.txtRepitaSenhaDoutor.TabIndex = 37;
            this.txtRepitaSenhaDoutor.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Senha";
            // 
            // txtEmailDoutor
            // 
            this.txtEmailDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailDoutor.Location = new System.Drawing.Point(41, 174);
            this.txtEmailDoutor.Name = "txtEmailDoutor";
            this.txtEmailDoutor.Size = new System.Drawing.Size(336, 30);
            this.txtEmailDoutor.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Email";
            // 
            // txtSenhaDoutor
            // 
            this.txtSenhaDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaDoutor.Location = new System.Drawing.Point(41, 242);
            this.txtSenhaDoutor.Name = "txtSenhaDoutor";
            this.txtSenhaDoutor.Size = new System.Drawing.Size(336, 30);
            this.txtSenhaDoutor.TabIndex = 33;
            this.txtSenhaDoutor.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nome";
            // 
            // txtNomeDoutor
            // 
            this.txtNomeDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDoutor.Location = new System.Drawing.Point(41, 106);
            this.txtNomeDoutor.Name = "txtNomeDoutor";
            this.txtNomeDoutor.Size = new System.Drawing.Size(336, 30);
            this.txtNomeDoutor.TabIndex = 31;
            // 
            // cmbEspecialidadeDoutor
            // 
            this.cmbEspecialidadeDoutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidadeDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspecialidadeDoutor.FormattingEnabled = true;
            this.cmbEspecialidadeDoutor.Location = new System.Drawing.Point(422, 320);
            this.cmbEspecialidadeDoutor.Name = "cmbEspecialidadeDoutor";
            this.cmbEspecialidadeDoutor.Size = new System.Drawing.Size(336, 33);
            this.cmbEspecialidadeDoutor.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(423, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 25);
            this.label10.TabIndex = 50;
            this.label10.Text = "Especialidade";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 39);
            this.btnVoltar.TabIndex = 53;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormCadastroDoutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.cmbEspecialidadeDoutor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMaskedCelularDoutor);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.cbMostrarSenha);
            this.Controls.Add(this.txtMaskedCpfDoutor);
            this.Controls.Add(this.cmbGeneroDoutor);
            this.Controls.Add(this.cmbTurnoDoutor);
            this.Controls.Add(this.btnCadastrarDoutor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRepitaSenhaDoutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmailDoutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenhaDoutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeDoutor);
            this.Name = "FormCadastroDoutor";
            this.Text = "FormDoutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtMaskedCelularDoutor;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.CheckBox cbMostrarSenha;
        private System.Windows.Forms.MaskedTextBox txtMaskedCpfDoutor;
        private System.Windows.Forms.ComboBox cmbGeneroDoutor;
        private System.Windows.Forms.ComboBox cmbTurnoDoutor;
        private System.Windows.Forms.Button btnCadastrarDoutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRepitaSenhaDoutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailDoutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenhaDoutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeDoutor;
        private System.Windows.Forms.ComboBox cmbEspecialidadeDoutor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnVoltar;
    }
}