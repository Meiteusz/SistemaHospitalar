
namespace SistemaHospitalar
{
    partial class FormEntradaRecepcionista
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
            this.btnConfiguracoesRecepcionista = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnVisitas = new System.Windows.Forms.Button();
            this.btnEncerrarSessão = new System.Windows.Forms.Button();
            this.btnInternacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConfiguracoesRecepcionista
            // 
            this.btnConfiguracoesRecepcionista.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracoesRecepcionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracoesRecepcionista.Location = new System.Drawing.Point(652, 12);
            this.btnConfiguracoesRecepcionista.Name = "btnConfiguracoesRecepcionista";
            this.btnConfiguracoesRecepcionista.Size = new System.Drawing.Size(136, 65);
            this.btnConfiguracoesRecepcionista.TabIndex = 0;
            this.btnConfiguracoesRecepcionista.Text = "Configurações da Conta";
            this.btnConfiguracoesRecepcionista.UseVisualStyleBackColor = false;
            this.btnConfiguracoesRecepcionista.Click += new System.EventHandler(this.btnConfiguracoesRecepcionista_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.Location = new System.Drawing.Point(62, 172);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(144, 85);
            this.btnPacientes.TabIndex = 2;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNome.Location = new System.Drawing.Point(191, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 39);
            this.lblNome.TabIndex = 3;
            // 
            // btnConsultas
            // 
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Location = new System.Drawing.Point(242, 172);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(144, 85);
            this.btnConsultas.TabIndex = 4;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnVisitas
            // 
            this.btnVisitas.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitas.Location = new System.Drawing.Point(423, 172);
            this.btnVisitas.Name = "btnVisitas";
            this.btnVisitas.Size = new System.Drawing.Size(144, 85);
            this.btnVisitas.TabIndex = 6;
            this.btnVisitas.Text = "Visitas";
            this.btnVisitas.UseVisualStyleBackColor = true;
            this.btnVisitas.Click += new System.EventHandler(this.btnVisitas_Click);
            // 
            // btnEncerrarSessão
            // 
            this.btnEncerrarSessão.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrarSessão.Location = new System.Drawing.Point(666, 377);
            this.btnEncerrarSessão.Name = "btnEncerrarSessão";
            this.btnEncerrarSessão.Size = new System.Drawing.Size(122, 61);
            this.btnEncerrarSessão.TabIndex = 7;
            this.btnEncerrarSessão.Text = "Encerrar Sessão";
            this.btnEncerrarSessão.UseVisualStyleBackColor = true;
            this.btnEncerrarSessão.Click += new System.EventHandler(this.btnEncerrarSessão_Click);
            // 
            // btnInternacao
            // 
            this.btnInternacao.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInternacao.Location = new System.Drawing.Point(600, 172);
            this.btnInternacao.Name = "btnInternacao";
            this.btnInternacao.Size = new System.Drawing.Size(144, 85);
            this.btnInternacao.TabIndex = 8;
            this.btnInternacao.Text = "Internação";
            this.btnInternacao.UseVisualStyleBackColor = true;
            this.btnInternacao.Click += new System.EventHandler(this.btnInternacao_Click);
            // 
            // FormEntradaRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInternacao);
            this.Controls.Add(this.btnEncerrarSessão);
            this.Controls.Add(this.btnVisitas);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnPacientes);
            this.Controls.Add(this.btnConfiguracoesRecepcionista);
            this.Name = "FormEntradaRecepcionista";
            this.Text = "Entrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfiguracoesRecepcionista;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnVisitas;
        private System.Windows.Forms.Button btnEncerrarSessão;
        private System.Windows.Forms.Button btnInternacao;
    }
}