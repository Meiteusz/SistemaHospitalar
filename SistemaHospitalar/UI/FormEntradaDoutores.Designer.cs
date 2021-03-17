
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
            this.btnValores.Location = new System.Drawing.Point(652, 96);
            this.btnValores.Name = "btnValores";
            this.btnValores.Size = new System.Drawing.Size(136, 65);
            this.btnValores.TabIndex = 3;
            this.btnValores.Text = "Valores";
            this.btnValores.UseVisualStyleBackColor = false;
            this.btnValores.Click += new System.EventHandler(this.btnValores_Click);
            // 
            // FormEntradaDoutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}