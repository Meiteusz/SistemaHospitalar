
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
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnConvenios = new System.Windows.Forms.Button();
            this.btnEncerrarSessão = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.Location = new System.Drawing.Point(130, 164);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(176, 93);
            this.btnFuncionarios.TabIndex = 0;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnConvenios
            // 
            this.btnConvenios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvenios.Location = new System.Drawing.Point(491, 164);
            this.btnConvenios.Name = "btnConvenios";
            this.btnConvenios.Size = new System.Drawing.Size(176, 93);
            this.btnConvenios.TabIndex = 1;
            this.btnConvenios.Text = "Convenios";
            this.btnConvenios.UseVisualStyleBackColor = true;
            this.btnConvenios.Click += new System.EventHandler(this.btnConvenios_Click);
            // 
            // btnEncerrarSessão
            // 
            this.btnEncerrarSessão.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrarSessão.Location = new System.Drawing.Point(689, 387);
            this.btnEncerrarSessão.Name = "btnEncerrarSessão";
            this.btnEncerrarSessão.Size = new System.Drawing.Size(99, 51);
            this.btnEncerrarSessão.TabIndex = 2;
            this.btnEncerrarSessão.Text = "Encerrar Sessão";
            this.btnEncerrarSessão.UseVisualStyleBackColor = true;
            this.btnEncerrarSessão.Click += new System.EventHandler(this.btnEncerrarSessão_Click);
            // 
            // FormEntradaADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEncerrarSessão);
            this.Controls.Add(this.btnConvenios);
            this.Controls.Add(this.btnFuncionarios);
            this.Name = "FormEntradaADM";
            this.Text = "FormEntradaADM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnConvenios;
        private System.Windows.Forms.Button btnEncerrarSessão;
    }
}