
namespace SistemaHospitalar.Views
{
    partial class FormVisitante
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
            this.btnMsgPaciente = new System.Windows.Forms.Button();
            this.btnAgendarVisita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMsgPaciente
            // 
            this.btnMsgPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMsgPaciente.Location = new System.Drawing.Point(127, 154);
            this.btnMsgPaciente.Name = "btnMsgPaciente";
            this.btnMsgPaciente.Size = new System.Drawing.Size(199, 107);
            this.btnMsgPaciente.TabIndex = 1;
            this.btnMsgPaciente.Text = "Mandar mensagem para um Paciente";
            this.btnMsgPaciente.UseVisualStyleBackColor = true;
            // 
            // btnAgendarVisita
            // 
            this.btnAgendarVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarVisita.Location = new System.Drawing.Point(470, 154);
            this.btnAgendarVisita.Name = "btnAgendarVisita";
            this.btnAgendarVisita.Size = new System.Drawing.Size(199, 107);
            this.btnAgendarVisita.TabIndex = 2;
            this.btnAgendarVisita.Text = "Agendar uma visita";
            this.btnAgendarVisita.UseVisualStyleBackColor = true;
            // 
            // FormVisitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgendarVisita);
            this.Controls.Add(this.btnMsgPaciente);
            this.Name = "FormVisitante";
            this.Text = "FormVisitante";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMsgPaciente;
        private System.Windows.Forms.Button btnAgendarVisita;
    }
}