
namespace SistemaHospitalar.UI
{
    partial class FormAgendaDoutor
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
            this.dgvAgendaDoutor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaDoutor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAgendaDoutor
            // 
            this.dgvAgendaDoutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendaDoutor.Location = new System.Drawing.Point(21, 13);
            this.dgvAgendaDoutor.Name = "dgvAgendaDoutor";
            this.dgvAgendaDoutor.Size = new System.Drawing.Size(495, 279);
            this.dgvAgendaDoutor.TabIndex = 0;
            // 
            // FormAgendaDoutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 304);
            this.Controls.Add(this.dgvAgendaDoutor);
            this.Name = "FormAgendaDoutor";
            this.Text = "FormAgendaDoutor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaDoutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgendaDoutor;
    }
}