﻿
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
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnConvenios = new System.Windows.Forms.Button();
            this.btnVisitas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracoes.Location = new System.Drawing.Point(652, 12);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(136, 65);
            this.btnConfiguracoes.TabIndex = 0;
            this.btnConfiguracoes.Text = "Configurações da Conta";
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.Location = new System.Drawing.Point(60, 178);
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
            this.btnConsultas.Location = new System.Drawing.Point(240, 178);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(144, 85);
            this.btnConsultas.TabIndex = 4;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnConvenios
            // 
            this.btnConvenios.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvenios.Location = new System.Drawing.Point(418, 178);
            this.btnConvenios.Name = "btnConvenios";
            this.btnConvenios.Size = new System.Drawing.Size(144, 85);
            this.btnConvenios.TabIndex = 5;
            this.btnConvenios.Text = "Convênios";
            this.btnConvenios.UseVisualStyleBackColor = true;
            this.btnConvenios.Click += new System.EventHandler(this.btnConvenios_Click);
            // 
            // btnVisitas
            // 
            this.btnVisitas.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitas.Location = new System.Drawing.Point(602, 178);
            this.btnVisitas.Name = "btnVisitas";
            this.btnVisitas.Size = new System.Drawing.Size(144, 85);
            this.btnVisitas.TabIndex = 6;
            this.btnVisitas.Text = "Visitas";
            this.btnVisitas.UseVisualStyleBackColor = true;
            // 
            // FormEntradaRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisitas);
            this.Controls.Add(this.btnConvenios);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnPacientes);
            this.Controls.Add(this.btnConfiguracoes);
            this.Name = "FormEntradaRecepcionista";
            this.Text = "Entrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnConvenios;
        private System.Windows.Forms.Button btnVisitas;
    }
}