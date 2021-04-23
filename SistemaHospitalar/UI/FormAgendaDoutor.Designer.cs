
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAgendaDoutor = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaDoutor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAgendaDoutor
            // 
            this.dgvAgendaDoutor.AllowUserToAddRows = false;
            this.dgvAgendaDoutor.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgendaDoutor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgendaDoutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendaDoutor.EnableHeadersVisualStyles = false;
            this.dgvAgendaDoutor.GridColor = System.Drawing.Color.Black;
            this.dgvAgendaDoutor.Location = new System.Drawing.Point(47, 27);
            this.dgvAgendaDoutor.Name = "dgvAgendaDoutor";
            this.dgvAgendaDoutor.ReadOnly = true;
            this.dgvAgendaDoutor.RowHeadersVisible = false;
            this.dgvAgendaDoutor.Size = new System.Drawing.Size(234, 404);
            this.dgvAgendaDoutor.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(84, 454);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(147, 73);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormAgendaDoutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 563);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvAgendaDoutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgendaDoutor";
            this.Text = "FormAgendaDoutor";
            this.Load += new System.EventHandler(this.FormAgendaDoutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaDoutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgendaDoutor;
        private System.Windows.Forms.Button btnFechar;
    }
}