
namespace SistemaHospitalar.UI
{
    partial class FormEntradaDoutores
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
            this.lblNome = new System.Windows.Forms.Label();
            this.btnValores = new System.Windows.Forms.Button();
            this.lblEspecialidadeDoutor = new System.Windows.Forms.Label();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.brnEncerrarSessão = new System.Windows.Forms.Button();
            this.btnInternacoesDoutor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracoes.Location = new System.Drawing.Point(652, 12);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(136, 65);
            this.btnConfiguracoes.TabIndex = 1;
            this.btnConfiguracoes.Text = "Configurações da Conta";
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblNome.Location = new System.Drawing.Point(171, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 39);
            this.lblNome.TabIndex = 2;
            // 
            // btnValores
            // 
            this.btnValores.BackColor = System.Drawing.Color.Transparent;
            this.btnValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValores.Location = new System.Drawing.Point(652, 95);
            this.btnValores.Name = "btnValores";
            this.btnValores.Size = new System.Drawing.Size(136, 65);
            this.btnValores.TabIndex = 3;
            this.btnValores.Text = "Valores";
            this.btnValores.UseVisualStyleBackColor = false;
            this.btnValores.Click += new System.EventHandler(this.btnValores_Click);
            // 
            // lblEspecialidadeDoutor
            // 
            this.lblEspecialidadeDoutor.AutoSize = true;
            this.lblEspecialidadeDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidadeDoutor.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblEspecialidadeDoutor.Location = new System.Drawing.Point(12, 416);
            this.lblEspecialidadeDoutor.Name = "lblEspecialidadeDoutor";
            this.lblEspecialidadeDoutor.Size = new System.Drawing.Size(0, 25);
            this.lblEspecialidadeDoutor.TabIndex = 4;
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Location = new System.Drawing.Point(168, 216);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(136, 76);
            this.btnConsultas.TabIndex = 5;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // brnEncerrarSessão
            // 
            this.brnEncerrarSessão.BackColor = System.Drawing.Color.Transparent;
            this.brnEncerrarSessão.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnEncerrarSessão.Location = new System.Drawing.Point(652, 373);
            this.brnEncerrarSessão.Name = "brnEncerrarSessão";
            this.brnEncerrarSessão.Size = new System.Drawing.Size(136, 65);
            this.brnEncerrarSessão.TabIndex = 6;
            this.brnEncerrarSessão.Text = "Encerrar Sessão";
            this.brnEncerrarSessão.UseVisualStyleBackColor = false;
            this.brnEncerrarSessão.Click += new System.EventHandler(this.brnEncerrarSessão_Click);
            // 
            // btnInternacoesDoutor
            // 
            this.btnInternacoesDoutor.BackColor = System.Drawing.Color.Transparent;
            this.btnInternacoesDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInternacoesDoutor.Location = new System.Drawing.Point(431, 216);
            this.btnInternacoesDoutor.Name = "btnInternacoesDoutor";
            this.btnInternacoesDoutor.Size = new System.Drawing.Size(136, 76);
            this.btnInternacoesDoutor.TabIndex = 7;
            this.btnInternacoesDoutor.Text = "Internações";
            this.btnInternacoesDoutor.UseVisualStyleBackColor = false;
            this.btnInternacoesDoutor.Click += new System.EventHandler(this.btnInternacoesDoutor_Click);
            // 
            // FormEntradaDoutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInternacoesDoutor);
            this.Controls.Add(this.brnEncerrarSessão);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.lblEspecialidadeDoutor);
            this.Controls.Add(this.btnValores);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnConfiguracoes);
            this.Name = "FormEntradaDoutores";
            this.Text = "FormEntradaDoutores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnValores;
        private System.Windows.Forms.Label lblEspecialidadeDoutor;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button brnEncerrarSessão;
        private System.Windows.Forms.Button btnInternacoesDoutor;
    }
}