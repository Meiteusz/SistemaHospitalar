
namespace SistemaHospitalar.UI
{
    partial class FormDiagnostico
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
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.btnCadastrarDiagnostico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diagnostico";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Enabled = false;
            this.txtNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePaciente.Location = new System.Drawing.Point(228, 130);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(330, 30);
            this.txtNomePaciente.TabIndex = 1;
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescricao.Location = new System.Drawing.Point(99, 198);
            this.rtbDescricao.MaxLength = 250;
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(594, 223);
            this.rtbDescricao.TabIndex = 2;
            this.rtbDescricao.Text = "";
            // 
            // btnCadastrarDiagnostico
            // 
            this.btnCadastrarDiagnostico.Location = new System.Drawing.Point(653, 119);
            this.btnCadastrarDiagnostico.Name = "btnCadastrarDiagnostico";
            this.btnCadastrarDiagnostico.Size = new System.Drawing.Size(113, 59);
            this.btnCadastrarDiagnostico.TabIndex = 3;
            this.btnCadastrarDiagnostico.Text = "Cadastrar Diagnóstico";
            this.btnCadastrarDiagnostico.UseVisualStyleBackColor = true;
            // 
            // FormDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarDiagnostico);
            this.Controls.Add(this.rtbDescricao);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.label1);
            this.Name = "FormDiagnostico";
            this.Text = "FormDiagnostico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Button btnCadastrarDiagnostico;
    }
}