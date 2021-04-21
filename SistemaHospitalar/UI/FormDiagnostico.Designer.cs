
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
            this.txtDescricaoDiagnostico = new System.Windows.Forms.RichTextBox();
            this.btnPronto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescricaoDiagnostico
            // 
            this.txtDescricaoDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoDiagnostico.Location = new System.Drawing.Point(52, 52);
            this.txtDescricaoDiagnostico.MaxLength = 500;
            this.txtDescricaoDiagnostico.Name = "txtDescricaoDiagnostico";
            this.txtDescricaoDiagnostico.Size = new System.Drawing.Size(535, 237);
            this.txtDescricaoDiagnostico.TabIndex = 0;
            this.txtDescricaoDiagnostico.Text = "";
            // 
            // btnPronto
            // 
            this.btnPronto.BackColor = System.Drawing.Color.Green;
            this.btnPronto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPronto.ForeColor = System.Drawing.Color.White;
            this.btnPronto.Location = new System.Drawing.Point(431, 312);
            this.btnPronto.Name = "btnPronto";
            this.btnPronto.Size = new System.Drawing.Size(156, 56);
            this.btnPronto.TabIndex = 3;
            this.btnPronto.Text = "PRONTO";
            this.btnPronto.UseVisualStyleBackColor = false;
            this.btnPronto.Click += new System.EventHandler(this.btnPronto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Diagnóstico:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(52, 312);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 56);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormDiagnosticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(652, 393);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPronto);
            this.Controls.Add(this.txtDescricaoDiagnostico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDiagnosticos";
            this.Text = "FormDiagnosticos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtDescricaoDiagnostico;
        private System.Windows.Forms.Button btnPronto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
    }
}