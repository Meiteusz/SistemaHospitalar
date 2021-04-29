
namespace SistemaHospitalar.UI
{
    partial class FormDescricaoDiagnostico
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtDescricaoDiagnostico = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(210, 274);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(176, 59);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Voltar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtDescricaoDiagnostico
            // 
            this.txtDescricaoDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoDiagnostico.Location = new System.Drawing.Point(26, 31);
            this.txtDescricaoDiagnostico.Name = "txtDescricaoDiagnostico";
            this.txtDescricaoDiagnostico.ReadOnly = true;
            this.txtDescricaoDiagnostico.Size = new System.Drawing.Size(547, 219);
            this.txtDescricaoDiagnostico.TabIndex = 1;
            this.txtDescricaoDiagnostico.Text = "";
            this.txtDescricaoDiagnostico.Click += new System.EventHandler(this.txtDescricaoDiagnostico_Click);
            // 
            // FormDescricaoDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(605, 345);
            this.Controls.Add(this.txtDescricaoDiagnostico);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDescricaoDiagnostico";
            this.Text = "FormDescricaoDiagnostico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.RichTextBox txtDescricaoDiagnostico;
    }
}