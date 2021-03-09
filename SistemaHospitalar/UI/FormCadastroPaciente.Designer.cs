
namespace SistemaHospitalar.Views
{
    partial class FormCadastroPaciente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCadastrarPaciente = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.cmbGeneroPaciente = new System.Windows.Forms.ComboBox();
            this.mtbCpfPaciente = new System.Windows.Forms.MaskedTextBox();
            this.mtbCelularPaciente = new System.Windows.Forms.MaskedTextBox();
            this.mtbCelular2Paciente = new System.Windows.Forms.MaskedTextBox();
            this.cmbGravidadePaciente = new System.Windows.Forms.ComboBox();
            this.dtpDataEntradaPaciente = new System.Windows.Forms.DateTimePicker();
            this.dtpDataSaidaPaciente = new System.Windows.Forms.DateTimePicker();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePaciente.Location = new System.Drawing.Point(35, 128);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(336, 30);
            this.txtNomePaciente.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Genero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Celular 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "CPF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "Possui  Plano?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(398, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 25);
            this.label10.TabIndex = 38;
            this.label10.Text = "Data saída";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(398, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 25);
            this.label11.TabIndex = 36;
            this.label11.Text = "Data entrada";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(398, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 25);
            this.label12.TabIndex = 34;
            this.label12.Text = "Gravidade";
            // 
            // btnCadastrarPaciente
            // 
            this.btnCadastrarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPaciente.Location = new System.Drawing.Point(418, 433);
            this.btnCadastrarPaciente.Name = "btnCadastrarPaciente";
            this.btnCadastrarPaciente.Size = new System.Drawing.Size(125, 58);
            this.btnCadastrarPaciente.TabIndex = 41;
            this.btnCadastrarPaciente.Text = "Cadastrar Paciente";
            this.btnCadastrarPaciente.UseVisualStyleBackColor = true;
            this.btnCadastrarPaciente.Click += new System.EventHandler(this.btnCadastrarPaciente_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(588, 433);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(125, 58);
            this.btnApagar.TabIndex = 42;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // cmbGeneroPaciente
            // 
            this.cmbGeneroPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneroPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGeneroPaciente.FormattingEnabled = true;
            this.cmbGeneroPaciente.Location = new System.Drawing.Point(35, 445);
            this.cmbGeneroPaciente.Name = "cmbGeneroPaciente";
            this.cmbGeneroPaciente.Size = new System.Drawing.Size(336, 33);
            this.cmbGeneroPaciente.TabIndex = 43;
            // 
            // mtbCpfPaciente
            // 
            this.mtbCpfPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpfPaciente.Location = new System.Drawing.Point(35, 207);
            this.mtbCpfPaciente.Mask = "000.000.000-00";
            this.mtbCpfPaciente.Name = "mtbCpfPaciente";
            this.mtbCpfPaciente.Size = new System.Drawing.Size(336, 30);
            this.mtbCpfPaciente.TabIndex = 44;
            this.mtbCpfPaciente.Click += new System.EventHandler(this.mtbCpfPaciente_Click);
            // 
            // mtbCelularPaciente
            // 
            this.mtbCelularPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCelularPaciente.Location = new System.Drawing.Point(35, 282);
            this.mtbCelularPaciente.Mask = "(00) 00000-0000";
            this.mtbCelularPaciente.Name = "mtbCelularPaciente";
            this.mtbCelularPaciente.Size = new System.Drawing.Size(336, 30);
            this.mtbCelularPaciente.TabIndex = 45;
            this.mtbCelularPaciente.Click += new System.EventHandler(this.mtbCelularPaciente_Click);
            // 
            // mtbCelular2Paciente
            // 
            this.mtbCelular2Paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCelular2Paciente.Location = new System.Drawing.Point(35, 363);
            this.mtbCelular2Paciente.Mask = "(00) 00000-0000";
            this.mtbCelular2Paciente.Name = "mtbCelular2Paciente";
            this.mtbCelular2Paciente.Size = new System.Drawing.Size(336, 30);
            this.mtbCelular2Paciente.TabIndex = 46;
            this.mtbCelular2Paciente.Click += new System.EventHandler(this.mtbCelular2Paciente_Click);
            // 
            // cmbGravidadePaciente
            // 
            this.cmbGravidadePaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGravidadePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGravidadePaciente.FormattingEnabled = true;
            this.cmbGravidadePaciente.Location = new System.Drawing.Point(403, 125);
            this.cmbGravidadePaciente.Name = "cmbGravidadePaciente";
            this.cmbGravidadePaciente.Size = new System.Drawing.Size(336, 33);
            this.cmbGravidadePaciente.TabIndex = 47;
            // 
            // dtpDataEntradaPaciente
            // 
            this.dtpDataEntradaPaciente.CustomFormat = "dd/MM/yyyy";
            this.dtpDataEntradaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEntradaPaciente.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataEntradaPaciente.Location = new System.Drawing.Point(403, 205);
            this.dtpDataEntradaPaciente.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpDataEntradaPaciente.MinDate = new System.DateTime(2021, 2, 23, 0, 0, 0, 0);
            this.dtpDataEntradaPaciente.Name = "dtpDataEntradaPaciente";
            this.dtpDataEntradaPaciente.Size = new System.Drawing.Size(336, 30);
            this.dtpDataEntradaPaciente.TabIndex = 49;
            this.dtpDataEntradaPaciente.Value = new System.DateTime(2021, 2, 23, 0, 0, 0, 0);
            // 
            // dtpDataSaidaPaciente
            // 
            this.dtpDataSaidaPaciente.CustomFormat = "dd/MM/yyyy";
            this.dtpDataSaidaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataSaidaPaciente.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataSaidaPaciente.Location = new System.Drawing.Point(403, 280);
            this.dtpDataSaidaPaciente.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpDataSaidaPaciente.MinDate = new System.DateTime(2021, 2, 23, 0, 0, 0, 0);
            this.dtpDataSaidaPaciente.Name = "dtpDataSaidaPaciente";
            this.dtpDataSaidaPaciente.Size = new System.Drawing.Size(336, 30);
            this.dtpDataSaidaPaciente.TabIndex = 50;
            this.dtpDataSaidaPaciente.Value = new System.DateTime(2021, 2, 23, 0, 0, 0, 0);
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSim.Location = new System.Drawing.Point(38, 63);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(54, 24);
            this.rbSim.TabIndex = 51;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNao.Location = new System.Drawing.Point(128, 63);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(56, 24);
            this.rbNao.TabIndex = 52;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rbNao);
            this.groupBox1.Controls.Add(this.rbSim);
            this.groupBox1.Location = new System.Drawing.Point(457, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 100);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 38);
            this.btnVoltar.TabIndex = 54;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormCadastroPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 552);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDataSaidaPaciente);
            this.Controls.Add(this.dtpDataEntradaPaciente);
            this.Controls.Add(this.cmbGravidadePaciente);
            this.Controls.Add(this.mtbCelular2Paciente);
            this.Controls.Add(this.mtbCelularPaciente);
            this.Controls.Add(this.mtbCpfPaciente);
            this.Controls.Add(this.cmbGeneroPaciente);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnCadastrarPaciente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomePaciente);
            this.Name = "FormCadastroPaciente";
            this.Text = "Cadastro de Paciente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCadastrarPaciente;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.ComboBox cmbGeneroPaciente;
        private System.Windows.Forms.MaskedTextBox mtbCpfPaciente;
        private System.Windows.Forms.MaskedTextBox mtbCelularPaciente;
        private System.Windows.Forms.MaskedTextBox mtbCelular2Paciente;
        private System.Windows.Forms.ComboBox cmbGravidadePaciente;
        private System.Windows.Forms.DateTimePicker dtpDataEntradaPaciente;
        private System.Windows.Forms.DateTimePicker dtpDataSaidaPaciente;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVoltar;
    }
}