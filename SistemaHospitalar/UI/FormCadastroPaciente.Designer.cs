
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCadastrarPaciente = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.cmbGeneroPaciente = new System.Windows.Forms.ComboBox();
            this.mtbCpfPaciente = new System.Windows.Forms.MaskedTextBox();
            this.mtbCelularPaciente = new System.Windows.Forms.MaskedTextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cmbConvenios = new System.Windows.Forms.ComboBox();
            this.Convênio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePaciente.Location = new System.Drawing.Point(38, 54);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(336, 30);
            this.txtNomePaciente.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(397, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Genero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(397, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(33, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "CPF";
            // 
            // btnCadastrarPaciente
            // 
            this.btnCadastrarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPaciente.Location = new System.Drawing.Point(591, 290);
            this.btnCadastrarPaciente.Name = "btnCadastrarPaciente";
            this.btnCadastrarPaciente.Size = new System.Drawing.Size(147, 73);
            this.btnCadastrarPaciente.TabIndex = 41;
            this.btnCadastrarPaciente.Text = "Cadastrar Paciente";
            this.btnCadastrarPaciente.UseVisualStyleBackColor = true;
            this.btnCadastrarPaciente.Click += new System.EventHandler(this.btnCadastrarPaciente_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(402, 290);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(147, 73);
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
            this.cmbGeneroPaciente.Location = new System.Drawing.Point(402, 51);
            this.cmbGeneroPaciente.Name = "cmbGeneroPaciente";
            this.cmbGeneroPaciente.Size = new System.Drawing.Size(336, 33);
            this.cmbGeneroPaciente.TabIndex = 43;
            // 
            // mtbCpfPaciente
            // 
            this.mtbCpfPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpfPaciente.Location = new System.Drawing.Point(38, 133);
            this.mtbCpfPaciente.Mask = "000.000.000-00";
            this.mtbCpfPaciente.Name = "mtbCpfPaciente";
            this.mtbCpfPaciente.Size = new System.Drawing.Size(336, 30);
            this.mtbCpfPaciente.TabIndex = 44;
            this.mtbCpfPaciente.Click += new System.EventHandler(this.mtbCpfPaciente_Click);
            // 
            // mtbCelularPaciente
            // 
            this.mtbCelularPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCelularPaciente.Location = new System.Drawing.Point(402, 133);
            this.mtbCelularPaciente.Mask = "(00) 00000-0000";
            this.mtbCelularPaciente.Name = "mtbCelularPaciente";
            this.mtbCelularPaciente.Size = new System.Drawing.Size(336, 30);
            this.mtbCelularPaciente.TabIndex = 45;
            this.mtbCelularPaciente.Click += new System.EventHandler(this.mtbCelularPaciente_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(38, 290);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 73);
            this.btnVoltar.TabIndex = 54;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cmbConvenios
            // 
            this.cmbConvenios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConvenios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConvenios.FormattingEnabled = true;
            this.cmbConvenios.Location = new System.Drawing.Point(402, 216);
            this.cmbConvenios.Name = "cmbConvenios";
            this.cmbConvenios.Size = new System.Drawing.Size(336, 33);
            this.cmbConvenios.TabIndex = 56;
            // 
            // Convênio
            // 
            this.Convênio.AutoSize = true;
            this.Convênio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convênio.ForeColor = System.Drawing.Color.White;
            this.Convênio.Location = new System.Drawing.Point(397, 188);
            this.Convênio.Name = "Convênio";
            this.Convênio.Size = new System.Drawing.Size(96, 25);
            this.Convênio.TabIndex = 55;
            this.Convênio.Text = "Convênio";
            // 
            // FormCadastroPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(770, 375);
            this.Controls.Add(this.cmbConvenios);
            this.Controls.Add(this.Convênio);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.mtbCelularPaciente);
            this.Controls.Add(this.mtbCpfPaciente);
            this.Controls.Add(this.cmbGeneroPaciente);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnCadastrarPaciente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomePaciente);
            this.Name = "FormCadastroPaciente";
            this.Text = "Cadastro de Paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCadastrarPaciente;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.ComboBox cmbGeneroPaciente;
        private System.Windows.Forms.MaskedTextBox mtbCpfPaciente;
        private System.Windows.Forms.MaskedTextBox mtbCelularPaciente;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cmbConvenios;
        private System.Windows.Forms.Label Convênio;
    }
}