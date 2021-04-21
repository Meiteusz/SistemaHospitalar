﻿
namespace SistemaHospitalar.UI
{
    partial class FormVisitantes
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
            this.dgvVisitantes = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrarVisitante = new System.Windows.Forms.Button();
            this.txtNomeVisitante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MtbCpfVisitante = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisitantes
            // 
            this.dgvVisitantes.AllowUserToAddRows = false;
            this.dgvVisitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitantes.Location = new System.Drawing.Point(29, 64);
            this.dgvVisitantes.Name = "dgvVisitantes";
            this.dgvVisitantes.ReadOnly = true;
            this.dgvVisitantes.Size = new System.Drawing.Size(396, 238);
            this.dgvVisitantes.TabIndex = 0;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(29, 384);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(119, 54);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrarVisitante
            // 
            this.btnCadastrarVisitante.Location = new System.Drawing.Point(560, 384);
            this.btnCadastrarVisitante.Name = "btnCadastrarVisitante";
            this.btnCadastrarVisitante.Size = new System.Drawing.Size(119, 54);
            this.btnCadastrarVisitante.TabIndex = 2;
            this.btnCadastrarVisitante.Text = "Cadastrar Visitante";
            this.btnCadastrarVisitante.UseVisualStyleBackColor = true;
            this.btnCadastrarVisitante.Click += new System.EventHandler(this.btnCadastrarVisitante_Click);
            // 
            // txtNomeVisitante
            // 
            this.txtNomeVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeVisitante.Location = new System.Drawing.Point(488, 174);
            this.txtNomeVisitante.Name = "txtNomeVisitante";
            this.txtNomeVisitante.Size = new System.Drawing.Size(260, 26);
            this.txtNomeVisitante.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cpf";
            // 
            // MtbCpfVisitante
            // 
            this.MtbCpfVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbCpfVisitante.Location = new System.Drawing.Point(488, 276);
            this.MtbCpfVisitante.Mask = "000.000.000-00";
            this.MtbCpfVisitante.Name = "MtbCpfVisitante";
            this.MtbCpfVisitante.Size = new System.Drawing.Size(260, 26);
            this.MtbCpfVisitante.TabIndex = 7;
            this.MtbCpfVisitante.Click += new System.EventHandler(this.txtCpfVisitante_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cadastro de Visitante";
            // 
            // FormVisitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MtbCpfVisitante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeVisitante);
            this.Controls.Add(this.btnCadastrarVisitante);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvVisitantes);
            this.Name = "FormVisitantes";
            this.Text = "FormVisitantes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisitantes;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrarVisitante;
        private System.Windows.Forms.TextBox txtNomeVisitante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MtbCpfVisitante;
        private System.Windows.Forms.Label label3;
    }
}