
namespace SistemaHospitalar.UI
{
    partial class FormInternacao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbPacientes = new System.Windows.Forms.ComboBox();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.cmbTipoInternacao = new System.Windows.Forms.ComboBox();
            this.cmbQuartos = new System.Windows.Forms.ComboBox();
            this.dtpDataEntradaInternacao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrarInternação = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.dgvDoutores = new System.Windows.Forms.DataGridView();
            this.txtNomeDoutor = new System.Windows.Forms.TextBox();
            this.cmbEspecialidades = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoutores)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPacientes
            // 
            this.cmbPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPacientes.FormattingEnabled = true;
            this.cmbPacientes.Location = new System.Drawing.Point(920, 330);
            this.cmbPacientes.Name = "cmbPacientes";
            this.cmbPacientes.Size = new System.Drawing.Size(264, 28);
            this.cmbPacientes.TabIndex = 0;
            this.cmbPacientes.SelectedIndexChanged += new System.EventHandler(this.cmbPacientes_SelectedIndexChanged);
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescricao.Location = new System.Drawing.Point(838, 148);
            this.rtbDescricao.MaxLength = 250;
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(408, 127);
            this.rtbDescricao.TabIndex = 2;
            this.rtbDescricao.Text = "";
            // 
            // cmbTipoInternacao
            // 
            this.cmbTipoInternacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoInternacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoInternacao.FormattingEnabled = true;
            this.cmbTipoInternacao.Location = new System.Drawing.Point(538, 199);
            this.cmbTipoInternacao.Name = "cmbTipoInternacao";
            this.cmbTipoInternacao.Size = new System.Drawing.Size(264, 28);
            this.cmbTipoInternacao.TabIndex = 3;
            // 
            // cmbQuartos
            // 
            this.cmbQuartos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuartos.FormattingEnabled = true;
            this.cmbQuartos.Location = new System.Drawing.Point(536, 314);
            this.cmbQuartos.Name = "cmbQuartos";
            this.cmbQuartos.Size = new System.Drawing.Size(264, 28);
            this.cmbQuartos.TabIndex = 4;
            // 
            // dtpDataEntradaInternacao
            // 
            this.dtpDataEntradaInternacao.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataEntradaInternacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEntradaInternacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataEntradaInternacao.Location = new System.Drawing.Point(538, 431);
            this.dtpDataEntradaInternacao.Name = "dtpDataEntradaInternacao";
            this.dtpDataEntradaInternacao.Size = new System.Drawing.Size(264, 27);
            this.dtpDataEntradaInternacao.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(916, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(535, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Doutor responsável";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(834, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descricao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(535, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo da internação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(533, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quarto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(535, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data de entrada";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(367, 505);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(147, 73);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrarInternação
            // 
            this.btnCadastrarInternação.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarInternação.Location = new System.Drawing.Point(1099, 505);
            this.btnCadastrarInternação.Name = "btnCadastrarInternação";
            this.btnCadastrarInternação.Size = new System.Drawing.Size(147, 73);
            this.btnCadastrarInternação.TabIndex = 13;
            this.btnCadastrarInternação.Text = "Internar";
            this.btnCadastrarInternação.UseVisualStyleBackColor = true;
            this.btnCadastrarInternação.Click += new System.EventHandler(this.btnCadastrarInternação_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(26, 505);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 73);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNomePaciente);
            this.groupBox1.Location = new System.Drawing.Point(921, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 61);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.ForeColor = System.Drawing.Color.White;
            this.lblNomePaciente.Location = new System.Drawing.Point(71, 25);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(117, 20);
            this.lblNomePaciente.TabIndex = 16;
            this.lblNomePaciente.Text = "Nome Paciente";
            // 
            // dgvDoutores
            // 
            this.dgvDoutores.AllowUserToAddRows = false;
            this.dgvDoutores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoutores.EnableHeadersVisualStyles = false;
            this.dgvDoutores.GridColor = System.Drawing.Color.Black;
            this.dgvDoutores.Location = new System.Drawing.Point(26, 61);
            this.dgvDoutores.Name = "dgvDoutores";
            this.dgvDoutores.ReadOnly = true;
            this.dgvDoutores.Size = new System.Drawing.Size(488, 397);
            this.dgvDoutores.TabIndex = 16;
            this.dgvDoutores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoutores_CellClick);
            // 
            // txtNomeDoutor
            // 
            this.txtNomeDoutor.Enabled = false;
            this.txtNomeDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDoutor.Location = new System.Drawing.Point(536, 83);
            this.txtNomeDoutor.Name = "txtNomeDoutor";
            this.txtNomeDoutor.Size = new System.Drawing.Size(265, 27);
            this.txtNomeDoutor.TabIndex = 17;
            // 
            // cmbEspecialidades
            // 
            this.cmbEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspecialidades.FormattingEnabled = true;
            this.cmbEspecialidades.Location = new System.Drawing.Point(26, 27);
            this.cmbEspecialidades.Name = "cmbEspecialidades";
            this.cmbEspecialidades.Size = new System.Drawing.Size(264, 28);
            this.cmbEspecialidades.TabIndex = 18;
            this.cmbEspecialidades.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidades_SelectedIndexChanged);
            // 
            // FormInternacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1265, 590);
            this.Controls.Add(this.cmbEspecialidades);
            this.Controls.Add(this.txtNomeDoutor);
            this.Controls.Add(this.dgvDoutores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrarInternação);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDataEntradaInternacao);
            this.Controls.Add(this.cmbQuartos);
            this.Controls.Add(this.cmbTipoInternacao);
            this.Controls.Add(this.rtbDescricao);
            this.Controls.Add(this.cmbPacientes);
            this.Name = "FormInternacao";
            this.Text = "FormInternacao";
            this.Load += new System.EventHandler(this.FormInternacao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPacientes;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.ComboBox cmbTipoInternacao;
        private System.Windows.Forms.ComboBox cmbQuartos;
        private System.Windows.Forms.DateTimePicker dtpDataEntradaInternacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrarInternação;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.DataGridView dgvDoutores;
        private System.Windows.Forms.TextBox txtNomeDoutor;
        private System.Windows.Forms.ComboBox cmbEspecialidades;
    }
}