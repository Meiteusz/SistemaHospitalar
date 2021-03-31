
namespace SistemaHospitalar.UI
{
    partial class FormEscolhaDeVisualizacaoDiagnostico
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
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.rbImpressao = new System.Windows.Forms.RadioButton();
            this.txtEmailPaciente = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gpEmailPaciente = new System.Windows.Forms.GroupBox();
            this.gpEmailPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe como deseja enviar a Visualização do Diagnóstico";
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmail.Location = new System.Drawing.Point(113, 90);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(66, 24);
            this.rbEmail.TabIndex = 1;
            this.rbEmail.TabStop = true;
            this.rbEmail.Text = "Email";
            this.rbEmail.UseVisualStyleBackColor = true;
            this.rbEmail.CheckedChanged += new System.EventHandler(this.rbEmail_CheckedChanged);
            // 
            // rbImpressao
            // 
            this.rbImpressao.AutoSize = true;
            this.rbImpressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbImpressao.Location = new System.Drawing.Point(326, 90);
            this.rbImpressao.Name = "rbImpressao";
            this.rbImpressao.Size = new System.Drawing.Size(102, 24);
            this.rbImpressao.TabIndex = 2;
            this.rbImpressao.TabStop = true;
            this.rbImpressao.Text = "Impressão";
            this.rbImpressao.UseVisualStyleBackColor = true;
            this.rbImpressao.CheckedChanged += new System.EventHandler(this.rbImpressao_CheckedChanged);
            // 
            // txtEmailPaciente
            // 
            this.txtEmailPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailPaciente.Location = new System.Drawing.Point(31, 40);
            this.txtEmailPaciente.Name = "txtEmailPaciente";
            this.txtEmailPaciente.Size = new System.Drawing.Size(316, 26);
            this.txtEmailPaciente.TabIndex = 3;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(441, 170);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(96, 41);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insira o email do Paciente";
            // 
            // gpEmailPaciente
            // 
            this.gpEmailPaciente.Controls.Add(this.txtEmailPaciente);
            this.gpEmailPaciente.Controls.Add(this.label2);
            this.gpEmailPaciente.Location = new System.Drawing.Point(65, 134);
            this.gpEmailPaciente.Name = "gpEmailPaciente";
            this.gpEmailPaciente.Size = new System.Drawing.Size(366, 79);
            this.gpEmailPaciente.TabIndex = 6;
            this.gpEmailPaciente.TabStop = false;
            // 
            // FormEscolhaDeVisualizacaoDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 221);
            this.Controls.Add(this.gpEmailPaciente);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.rbImpressao);
            this.Controls.Add(this.rbEmail);
            this.Controls.Add(this.label1);
            this.Name = "FormEscolhaDeVisualizacaoDiagnostico";
            this.Text = "FormEscolhaDeVisualizacaoDiagnostico";
            this.gpEmailPaciente.ResumeLayout(false);
            this.gpEmailPaciente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.RadioButton rbImpressao;
        private System.Windows.Forms.TextBox txtEmailPaciente;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpEmailPaciente;
    }
}