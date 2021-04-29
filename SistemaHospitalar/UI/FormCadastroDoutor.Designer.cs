
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
            this.MtbCelularDoutor = new System.Windows.Forms.MaskedTextBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.cbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.MtbCpfDoutor = new System.Windows.Forms.MaskedTextBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtValorExame = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorConsulta = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorExame)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // MtbCelularDoutor
            // 
            this.MtbCelularDoutor.BeepOnError = true;
            this.MtbCelularDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbCelularDoutor.Location = new System.Drawing.Point(32, 142);
            this.MtbCelularDoutor.Mask = "(00) 00000-0000";
            this.MtbCelularDoutor.Name = "MtbCelularDoutor";
            this.MtbCelularDoutor.Size = new System.Drawing.Size(336, 30);
            this.MtbCelularDoutor.TabIndex = 49;
            this.MtbCelularDoutor.Click += new System.EventHandler(this.txtMaskedCelularDoutor_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(504, 598);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(147, 73);
            this.btnApagar.TabIndex = 48;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMostrarSenha.ForeColor = System.Drawing.Color.White;
            this.cbMostrarSenha.Location = new System.Drawing.Point(237, 232);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(133, 24);
            this.cbMostrarSenha.TabIndex = 47;
            this.cbMostrarSenha.Text = "Mostrar Senha";
            this.cbMostrarSenha.UseVisualStyleBackColor = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.cbMostrarSenha_CheckedChanged);
            // 
            // MtbCpfDoutor
            // 
            this.MtbCpfDoutor.BeepOnError = true;
            this.MtbCpfDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbCpfDoutor.Location = new System.Drawing.Point(33, 140);
            this.MtbCpfDoutor.Mask = "000.000.000-00";
            this.MtbCpfDoutor.Name = "MtbCpfDoutor";
            this.MtbCpfDoutor.Size = new System.Drawing.Size(336, 30);
            this.MtbCpfDoutor.TabIndex = 46;
            this.MtbCpfDoutor.Click += new System.EventHandler(this.txtMaskedCpfDoutor_Click);
            // 
            // cmbGeneroDoutor
            // 
            this.cmbGeneroDoutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneroDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGeneroDoutor.FormattingEnabled = true;
            this.cmbGeneroDoutor.Location = new System.Drawing.Point(32, 58);
            this.cmbGeneroDoutor.Name = "cmbGeneroDoutor";
            this.cmbGeneroDoutor.Size = new System.Drawing.Size(336, 28);
            this.cmbGeneroDoutor.TabIndex = 45;
            // 
            // cmbTurnoDoutor
            // 
            this.cmbTurnoDoutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurnoDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurnoDoutor.FormattingEnabled = true;
            this.cmbTurnoDoutor.Items.AddRange(new object[] {
            "Selecione"});
            this.cmbTurnoDoutor.Location = new System.Drawing.Point(33, 226);
            this.cmbTurnoDoutor.Name = "cmbTurnoDoutor";
            this.cmbTurnoDoutor.Size = new System.Drawing.Size(336, 28);
            this.cmbTurnoDoutor.TabIndex = 44;
            // 
            // btnCadastrarDoutor
            // 
            this.btnCadastrarDoutor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarDoutor.Location = new System.Drawing.Point(762, 598);
            this.btnCadastrarDoutor.Name = "btnCadastrarDoutor";
            this.btnCadastrarDoutor.Size = new System.Drawing.Size(147, 73);
            this.btnCadastrarDoutor.TabIndex = 43;
            this.btnCadastrarDoutor.Text = "Cadastrar Doutor(a)";
            this.btnCadastrarDoutor.UseVisualStyleBackColor = true;
            this.btnCadastrarDoutor.Click += new System.EventHandler(this.btnCadastrarDoutor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 42;
            this.label5.Text = "Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 41;
            this.label6.Text = "Genero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 22);
            this.label7.TabIndex = 40;
            this.label7.Text = "Turno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(29, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 22);
            this.label8.TabIndex = 39;
            this.label8.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "Repita a Senha";
            // 
            // txtRepitaSenhaDoutor
            // 
            this.txtRepitaSenhaDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepitaSenhaDoutor.Location = new System.Drawing.Point(34, 271);
            this.txtRepitaSenhaDoutor.Name = "txtRepitaSenhaDoutor";
            this.txtRepitaSenhaDoutor.Size = new System.Drawing.Size(336, 30);
            this.txtRepitaSenhaDoutor.TabIndex = 37;
            this.txtRepitaSenhaDoutor.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 36;
            this.label3.Text = "Senha";
            // 
            // txtEmailDoutor
            // 
            this.txtEmailDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailDoutor.Location = new System.Drawing.Point(34, 87);
            this.txtEmailDoutor.Name = "txtEmailDoutor";
            this.txtEmailDoutor.Size = new System.Drawing.Size(336, 30);
            this.txtEmailDoutor.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "Email";
            // 
            // txtSenhaDoutor
            // 
            this.txtSenhaDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaDoutor.Location = new System.Drawing.Point(34, 180);
            this.txtSenhaDoutor.Name = "txtSenhaDoutor";
            this.txtSenhaDoutor.Size = new System.Drawing.Size(336, 30);
            this.txtSenhaDoutor.TabIndex = 33;
            this.txtSenhaDoutor.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nome";
            // 
            // txtNomeDoutor
            // 
            this.txtNomeDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDoutor.Location = new System.Drawing.Point(33, 54);
            this.txtNomeDoutor.Name = "txtNomeDoutor";
            this.txtNomeDoutor.Size = new System.Drawing.Size(336, 30);
            this.txtNomeDoutor.TabIndex = 31;
            // 
            // cmbEspecialidadeDoutor
            // 
            this.cmbEspecialidadeDoutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidadeDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspecialidadeDoutor.FormattingEnabled = true;
            this.cmbEspecialidadeDoutor.Location = new System.Drawing.Point(33, 317);
            this.cmbEspecialidadeDoutor.Name = "cmbEspecialidadeDoutor";
            this.cmbEspecialidadeDoutor.Size = new System.Drawing.Size(336, 28);
            this.cmbEspecialidadeDoutor.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(29, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 22);
            this.label10.TabIndex = 50;
            this.label10.Text = "Especialidade";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(41, 598);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 73);
            this.btnVoltar.TabIndex = 53;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEspecialidadeDoutor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbTurnoDoutor);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.MtbCpfDoutor);
            this.groupBox1.Controls.Add(this.txtNomeDoutor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(41, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 366);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Profissionais";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSenhaDoutor);
            this.groupBox2.Controls.Add(this.txtEmailDoutor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtRepitaSenhaDoutor);
            this.groupBox2.Controls.Add(this.cbMostrarSenha);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(504, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 366);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações de Login";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MtbCelularDoutor);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmbGeneroDoutor);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(41, 384);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 185);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Outros";
            // 
            // txtValorExame
            // 
            this.txtValorExame.DecimalPlaces = 2;
            this.txtValorExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorExame.Location = new System.Drawing.Point(245, 110);
            this.txtValorExame.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txtValorExame.Name = "txtValorExame";
            this.txtValorExame.Size = new System.Drawing.Size(81, 26);
            this.txtValorExame.TabIndex = 58;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtValorExame);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtValorConsulta);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(504, 384);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(405, 185);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Valores";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(214, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 22);
            this.label9.TabIndex = 5;
            this.label9.Text = "R$";
            // 
            // txtValorConsulta
            // 
            this.txtValorConsulta.DecimalPlaces = 2;
            this.txtValorConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorConsulta.Location = new System.Drawing.Point(245, 70);
            this.txtValorConsulta.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtValorConsulta.Name = "txtValorConsulta";
            this.txtValorConsulta.Size = new System.Drawing.Size(81, 26);
            this.txtValorConsulta.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(214, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 22);
            this.label11.TabIndex = 6;
            this.label11.Text = "R$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(84, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 22);
            this.label12.TabIndex = 4;
            this.label12.Text = "Valor exame:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(83, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 22);
            this.label13.TabIndex = 3;
            this.label13.Text = "Valor consulta:";
            // 
            // FormCadastroDoutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(945, 683);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnCadastrarDoutor);
            this.Name = "FormCadastroDoutor";
            this.Text = "FormDoutor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorExame)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MtbCelularDoutor;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.CheckBox cbMostrarSenha;
        private System.Windows.Forms.MaskedTextBox MtbCpfDoutor;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown txtValorExame;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtValorConsulta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}