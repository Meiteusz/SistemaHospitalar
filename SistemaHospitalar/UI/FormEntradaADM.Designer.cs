
namespace SistemaHospitalar.UI
{
    partial class FormEntradaADM
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
            this.txtDiariaInternacao = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAtualizarDiaria = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEncerrarSessão = new System.Windows.Forms.Button();
            this.btnFazerBackup = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnQuartos = new System.Windows.Forms.Button();
            this.btnConvenios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiariaInternacao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Diária Internação:";
            // 
            // txtDiariaInternacao
            // 
            this.txtDiariaInternacao.DecimalPlaces = 2;
            this.txtDiariaInternacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiariaInternacao.Location = new System.Drawing.Point(335, 31);
            this.txtDiariaInternacao.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtDiariaInternacao.Name = "txtDiariaInternacao";
            this.txtDiariaInternacao.Size = new System.Drawing.Size(166, 30);
            this.txtDiariaInternacao.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.btnAtualizarDiaria);
            this.groupBox1.Controls.Add(this.txtDiariaInternacao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(288, 517);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 83);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnAtualizarDiaria
            // 
            this.btnAtualizarDiaria.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAtualizarDiaria.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtualizarDiaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarDiaria.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarDiaria.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarDiaria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizarDiaria.Location = new System.Drawing.Point(520, 14);
            this.btnAtualizarDiaria.Name = "btnAtualizarDiaria";
            this.btnAtualizarDiaria.Size = new System.Drawing.Size(154, 60);
            this.btnAtualizarDiaria.TabIndex = 7;
            this.btnAtualizarDiaria.Text = "Atualizar Diária";
            this.btnAtualizarDiaria.UseVisualStyleBackColor = false;
            this.btnAtualizarDiaria.Click += new System.EventHandler(this.btnAtualizarDiaria_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnFazerBackup);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnEncerrarSessão);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 600);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemaHospitalar.Properties.Resources._5027870_128__1_;
            this.pictureBox1.Location = new System.Drawing.Point(78, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 122);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnEncerrarSessão
            // 
            this.btnEncerrarSessão.BackColor = System.Drawing.Color.Teal;
            this.btnEncerrarSessão.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEncerrarSessão.FlatAppearance.BorderSize = 0;
            this.btnEncerrarSessão.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrarSessão.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrarSessão.ForeColor = System.Drawing.Color.White;
            this.btnEncerrarSessão.Image = global::SistemaHospitalar.Properties.Resources._307612__1_1;
            this.btnEncerrarSessão.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEncerrarSessão.Location = new System.Drawing.Point(1, 524);
            this.btnEncerrarSessão.Name = "btnEncerrarSessão";
            this.btnEncerrarSessão.Size = new System.Drawing.Size(287, 75);
            this.btnEncerrarSessão.TabIndex = 2;
            this.btnEncerrarSessão.Text = "Log Out";
            this.btnEncerrarSessão.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncerrarSessão.UseVisualStyleBackColor = false;
            this.btnEncerrarSessão.Click += new System.EventHandler(this.btnEncerrarSessão_Click);
            // 
            // btnFazerBackup
            // 
            this.btnFazerBackup.BackColor = System.Drawing.Color.Teal;
            this.btnFazerBackup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFazerBackup.FlatAppearance.BorderSize = 0;
            this.btnFazerBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFazerBackup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazerBackup.ForeColor = System.Drawing.Color.White;
            this.btnFazerBackup.Image = global::SistemaHospitalar.Properties.Resources.backupIcon__1_;
            this.btnFazerBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFazerBackup.Location = new System.Drawing.Point(0, 443);
            this.btnFazerBackup.Name = "btnFazerBackup";
            this.btnFazerBackup.Size = new System.Drawing.Size(290, 77);
            this.btnFazerBackup.TabIndex = 7;
            this.btnFazerBackup.Text = "Backup";
            this.btnFazerBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFazerBackup.UseVisualStyleBackColor = false;
            this.btnFazerBackup.Click += new System.EventHandler(this.btnFazerBackup_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.Color.Teal;
            this.btnFuncionarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btnFuncionarios.Image = global::SistemaHospitalar.Properties.Resources.funcionariosIcon__1_;
            this.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionarios.Location = new System.Drawing.Point(288, 0);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(267, 128);
            this.btnFuncionarios.TabIndex = 0;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnQuartos
            // 
            this.btnQuartos.BackColor = System.Drawing.Color.Teal;
            this.btnQuartos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuartos.FlatAppearance.BorderSize = 0;
            this.btnQuartos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuartos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuartos.ForeColor = System.Drawing.Color.White;
            this.btnQuartos.Image = global::SistemaHospitalar.Properties.Resources.quartosIcon__1_;
            this.btnQuartos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuartos.Location = new System.Drawing.Point(555, 0);
            this.btnQuartos.Name = "btnQuartos";
            this.btnQuartos.Size = new System.Drawing.Size(267, 128);
            this.btnQuartos.TabIndex = 3;
            this.btnQuartos.Text = "Quartos";
            this.btnQuartos.UseVisualStyleBackColor = false;
            this.btnQuartos.Click += new System.EventHandler(this.btnQuartos_Click);
            // 
            // btnConvenios
            // 
            this.btnConvenios.BackColor = System.Drawing.Color.Teal;
            this.btnConvenios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConvenios.FlatAppearance.BorderSize = 0;
            this.btnConvenios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvenios.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvenios.ForeColor = System.Drawing.Color.White;
            this.btnConvenios.Image = global::SistemaHospitalar.Properties.Resources.conveniosIcon__1_;
            this.btnConvenios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvenios.Location = new System.Drawing.Point(822, 0);
            this.btnConvenios.Name = "btnConvenios";
            this.btnConvenios.Size = new System.Drawing.Size(267, 128);
            this.btnConvenios.TabIndex = 1;
            this.btnConvenios.Text = "Convenios";
            this.btnConvenios.UseVisualStyleBackColor = false;
            this.btnConvenios.Click += new System.EventHandler(this.btnConvenios_Click);
            // 
            // FormEntradaADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1089, 600);
            this.Controls.Add(this.btnFuncionarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuartos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConvenios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEntradaADM";
            this.Text = "FormEntradaADM";
            ((System.ComponentModel.ISupportInitialize)(this.txtDiariaInternacao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnConvenios;
        private System.Windows.Forms.Button btnEncerrarSessão;
        private System.Windows.Forms.Button btnQuartos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtDiariaInternacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAtualizarDiaria;
        private System.Windows.Forms.Button btnFazerBackup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}