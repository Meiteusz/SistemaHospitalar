
namespace SistemaHospitalar.Views
{
    partial class FormInicio
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
            this.btnVisitante = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVisitante
            // 
            this.btnVisitante.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitante.Location = new System.Drawing.Point(114, 140);
            this.btnVisitante.Name = "btnVisitante";
            this.btnVisitante.Size = new System.Drawing.Size(255, 146);
            this.btnVisitante.TabIndex = 0;
            this.btnVisitante.Text = "Visitante";
            this.btnVisitante.UseVisualStyleBackColor = true;
            this.btnVisitante.Click += new System.EventHandler(this.btnVisitante_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.Location = new System.Drawing.Point(426, 140);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(255, 146);
            this.btnFuncionario.TabIndex = 1;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnVisitante);
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVisitante;
        private System.Windows.Forms.Button btnFuncionario;
    }
}