
namespace SistemaHospitalar.UI
{
    partial class FormAgendarConsulta
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
            this.cmbCpfPacientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MtbDataConsulta = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MtbHorarioConsulta = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeDoutor = new System.Windows.Forms.TextBox();
            this.dgvDoutores = new System.Windows.Forms.DataGridView();
            this.cmbEspecialidade = new System.Windows.Forms.ComboBox();
            this.btnCadastrarConsulta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoutores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCpfPacientes
            // 
            this.cmbCpfPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCpfPacientes.Location = new System.Drawing.Point(53, 45);
            this.cmbCpfPacientes.Name = "cmbCpfPacientes";
            this.cmbCpfPacientes.Size = new System.Drawing.Size(270, 28);
            this.cmbCpfPacientes.TabIndex = 0;
            this.cmbCpfPacientes.SelectedIndexChanged += new System.EventHandler(this.cmbCpfPacientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paciente (CPF)";
            // 
            // MtbDataConsulta
            // 
            this.MtbDataConsulta.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.MtbDataConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbDataConsulta.Location = new System.Drawing.Point(99, 202);
            this.MtbDataConsulta.Mask = "0000/00/00";
            this.MtbDataConsulta.Name = "MtbDataConsulta";
            this.MtbDataConsulta.Size = new System.Drawing.Size(90, 27);
            this.MtbDataConsulta.TabIndex = 2;
            this.MtbDataConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MtbDataConsulta.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doutor(a)";
            // 
            // MtbHorarioConsulta
            // 
            this.MtbHorarioConsulta.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.MtbHorarioConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbHorarioConsulta.Location = new System.Drawing.Point(257, 202);
            this.MtbHorarioConsulta.Mask = "00:00";
            this.MtbHorarioConsulta.Name = "MtbHorarioConsulta";
            this.MtbHorarioConsulta.Size = new System.Drawing.Size(66, 27);
            this.MtbHorarioConsulta.TabIndex = 6;
            this.MtbHorarioConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MtbHorarioConsulta.ValidatingType = typeof(System.DateTime);
            // 
            // txtNomeDoutor
            // 
            this.txtNomeDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDoutor.Location = new System.Drawing.Point(95, 364);
            this.txtNomeDoutor.Name = "txtNomeDoutor";
            this.txtNomeDoutor.Size = new System.Drawing.Size(224, 27);
            this.txtNomeDoutor.TabIndex = 8;
            this.txtNomeDoutor.Click += new System.EventHandler(this.txtNomeDoutor_Click);
            // 
            // dgvDoutores
            // 
            this.dgvDoutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoutores.Location = new System.Drawing.Point(12, 96);
            this.dgvDoutores.Name = "dgvDoutores";
            this.dgvDoutores.Size = new System.Drawing.Size(343, 248);
            this.dgvDoutores.TabIndex = 9;
            this.dgvDoutores.Visible = false;
            this.dgvDoutores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoutores_CellClick);
            // 
            // cmbEspecialidade
            // 
            this.cmbEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspecialidade.FormattingEnabled = true;
            this.cmbEspecialidade.Location = new System.Drawing.Point(12, 56);
            this.cmbEspecialidade.Name = "cmbEspecialidade";
            this.cmbEspecialidade.Size = new System.Drawing.Size(224, 28);
            this.cmbEspecialidade.TabIndex = 10;
            this.cmbEspecialidade.Visible = false;
            // 
            // btnCadastrarConsulta
            // 
            this.btnCadastrarConsulta.Location = new System.Drawing.Point(517, 351);
            this.btnCadastrarConsulta.Name = "btnCadastrarConsulta";
            this.btnCadastrarConsulta.Size = new System.Drawing.Size(138, 54);
            this.btnCadastrarConsulta.TabIndex = 11;
            this.btnCadastrarConsulta.Text = "Agendar Consulta";
            this.btnCadastrarConsulta.UseVisualStyleBackColor = true;
            this.btnCadastrarConsulta.Click += new System.EventHandler(this.btnAgendarConsulta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hora";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(272, 54);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(83, 30);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Visible = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNomePaciente);
            this.groupBox1.Controls.Add(this.cmbCpfPacientes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MtbHorarioConsulta);
            this.groupBox1.Controls.Add(this.MtbDataConsulta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(404, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 256);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.Location = new System.Drawing.Point(49, 126);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(0, 20);
            this.lblNomePaciente.TabIndex = 13;
            // 
            // FormAgendarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCadastrarConsulta);
            this.Controls.Add(this.cmbEspecialidade);
            this.Controls.Add(this.dgvDoutores);
            this.Controls.Add(this.txtNomeDoutor);
            this.Controls.Add(this.label3);
            this.Name = "FormAgendarConsulta";
            this.Text = "FormAgendarConsulta";
            this.Load += new System.EventHandler(this.FormCadastroConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoutores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCpfPacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MtbDataConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MtbHorarioConsulta;
        private System.Windows.Forms.TextBox txtNomeDoutor;
        private System.Windows.Forms.DataGridView dgvDoutores;
        private System.Windows.Forms.ComboBox cmbEspecialidade;
        private System.Windows.Forms.Button btnCadastrarConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNomePaciente;
    }
}