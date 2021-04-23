
namespace SistemaHospitalar.UI
{
    partial class FormInternacoesDoutor
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
            this.dgvInternacoesDoutor = new System.Windows.Forms.DataGridView();
            this.btnVerificarInternacao = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternacoesDoutor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInternacoesDoutor
            // 
            this.dgvInternacoesDoutor.AllowUserToAddRows = false;
            this.dgvInternacoesDoutor.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternacoesDoutor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInternacoesDoutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternacoesDoutor.EnableHeadersVisualStyles = false;
            this.dgvInternacoesDoutor.GridColor = System.Drawing.Color.Black;
            this.dgvInternacoesDoutor.Location = new System.Drawing.Point(24, 12);
            this.dgvInternacoesDoutor.Name = "dgvInternacoesDoutor";
            this.dgvInternacoesDoutor.ReadOnly = true;
            this.dgvInternacoesDoutor.Size = new System.Drawing.Size(1045, 363);
            this.dgvInternacoesDoutor.TabIndex = 0;
            this.dgvInternacoesDoutor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInternacoesDoutor_CellClick);
            // 
            // btnVerificarInternacao
            // 
            this.btnVerificarInternacao.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnVerificarInternacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarInternacao.Location = new System.Drawing.Point(922, 483);
            this.btnVerificarInternacao.Name = "btnVerificarInternacao";
            this.btnVerificarInternacao.Size = new System.Drawing.Size(147, 73);
            this.btnVerificarInternacao.TabIndex = 1;
            this.btnVerificarInternacao.Text = "Verificar Internacao";
            this.btnVerificarInternacao.UseVisualStyleBackColor = true;
            this.btnVerificarInternacao.Click += new System.EventHandler(this.btnVerificarInternacao_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(24, 483);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 73);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormInternacoesDoutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 568);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnVerificarInternacao);
            this.Controls.Add(this.dgvInternacoesDoutor);
            this.Name = "FormInternacoesDoutor";
            this.Text = "FormInterncoesDoutor";
            this.Load += new System.EventHandler(this.FormInternacoesDoutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternacoesDoutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInternacoesDoutor;
        private System.Windows.Forms.Button btnVerificarInternacao;
        private System.Windows.Forms.Button btnVoltar;
    }
}