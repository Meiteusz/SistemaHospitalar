
namespace SistemaHospitalar.UI
{
    partial class FormAgenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAgendaConsulta = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvAgendaExames = new System.Windows.Forms.DataGridView();
            this.dtpDataConsultaExame = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaExames)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAgendaConsulta
            // 
            this.dgvAgendaConsulta.AllowUserToAddRows = false;
            this.dgvAgendaConsulta.AllowUserToResizeColumns = false;
            this.dgvAgendaConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgendaConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAgendaConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendaConsulta.EnableHeadersVisualStyles = false;
            this.dgvAgendaConsulta.GridColor = System.Drawing.Color.Black;
            this.dgvAgendaConsulta.Location = new System.Drawing.Point(50, 49);
            this.dgvAgendaConsulta.Name = "dgvAgendaConsulta";
            this.dgvAgendaConsulta.ReadOnly = true;
            this.dgvAgendaConsulta.RowHeadersVisible = false;
            this.dgvAgendaConsulta.Size = new System.Drawing.Size(377, 347);
            this.dgvAgendaConsulta.TabIndex = 0;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(50, 402);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(161, 73);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvAgendaExames
            // 
            this.dgvAgendaExames.AllowUserToAddRows = false;
            this.dgvAgendaExames.AllowUserToResizeColumns = false;
            this.dgvAgendaExames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgendaExames.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAgendaExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendaExames.EnableHeadersVisualStyles = false;
            this.dgvAgendaExames.GridColor = System.Drawing.Color.Black;
            this.dgvAgendaExames.Location = new System.Drawing.Point(433, 49);
            this.dgvAgendaExames.Name = "dgvAgendaExames";
            this.dgvAgendaExames.ReadOnly = true;
            this.dgvAgendaExames.RowHeadersVisible = false;
            this.dgvAgendaExames.Size = new System.Drawing.Size(377, 347);
            this.dgvAgendaExames.TabIndex = 3;
            // 
            // dtpDataConsultaExame
            // 
            this.dtpDataConsultaExame.CustomFormat = "dd/MM/yyyy";
            this.dtpDataConsultaExame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataConsultaExame.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataConsultaExame.Location = new System.Drawing.Point(672, 424);
            this.dtpDataConsultaExame.Name = "dtpDataConsultaExame";
            this.dtpDataConsultaExame.Size = new System.Drawing.Size(141, 29);
            this.dtpDataConsultaExame.TabIndex = 14;
            this.dtpDataConsultaExame.ValueChanged += new System.EventHandler(this.dtpDataConsultaExame_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(431, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Data da Consulta / Exame";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(193, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Consultas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(584, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Exames";
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(856, 493);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDataConsultaExame);
            this.Controls.Add(this.dgvAgendaExames);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvAgendaConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgenda";
            this.Text = "FormAgendaDoutor";
            this.Load += new System.EventHandler(this.FormAgendaDoutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaExames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgendaConsulta;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvAgendaExames;
        private System.Windows.Forms.DateTimePicker dtpDataConsultaExame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}