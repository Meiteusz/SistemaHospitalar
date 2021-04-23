
namespace SistemaHospitalar.UI
{
    partial class FormDiagnosticosDoExame
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
            this.dgvDiagnosticosDoExame = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnDeletarDiagnostico = new System.Windows.Forms.Button();
            this.btnVerDescricao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosticosDoExame)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiagnosticosDoExame
            // 
            this.dgvDiagnosticosDoExame.AllowUserToAddRows = false;
            this.dgvDiagnosticosDoExame.AllowUserToResizeColumns = false;
            this.dgvDiagnosticosDoExame.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiagnosticosDoExame.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiagnosticosDoExame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnosticosDoExame.EnableHeadersVisualStyles = false;
            this.dgvDiagnosticosDoExame.GridColor = System.Drawing.Color.Black;
            this.dgvDiagnosticosDoExame.Location = new System.Drawing.Point(109, 36);
            this.dgvDiagnosticosDoExame.Name = "dgvDiagnosticosDoExame";
            this.dgvDiagnosticosDoExame.ReadOnly = true;
            this.dgvDiagnosticosDoExame.Size = new System.Drawing.Size(630, 297);
            this.dgvDiagnosticosDoExame.TabIndex = 0;
            this.dgvDiagnosticosDoExame.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnosticosDoExame_CellClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(113, 364);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 73);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Fechar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnDeletarDiagnostico
            // 
            this.btnDeletarDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarDiagnostico.Location = new System.Drawing.Point(359, 364);
            this.btnDeletarDiagnostico.Name = "btnDeletarDiagnostico";
            this.btnDeletarDiagnostico.Size = new System.Drawing.Size(147, 73);
            this.btnDeletarDiagnostico.TabIndex = 2;
            this.btnDeletarDiagnostico.Text = "Deletar Diagnostico";
            this.btnDeletarDiagnostico.UseVisualStyleBackColor = true;
            this.btnDeletarDiagnostico.Click += new System.EventHandler(this.btnDeletarDiagnostico_Click);
            // 
            // btnVerDescricao
            // 
            this.btnVerDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDescricao.Location = new System.Drawing.Point(592, 364);
            this.btnVerDescricao.Name = "btnVerDescricao";
            this.btnVerDescricao.Size = new System.Drawing.Size(147, 73);
            this.btnVerDescricao.TabIndex = 3;
            this.btnVerDescricao.Text = "Ver Descricao";
            this.btnVerDescricao.UseVisualStyleBackColor = true;
            this.btnVerDescricao.Click += new System.EventHandler(this.btnVerDescricao_Click);
            // 
            // FormDiagnosticosDoExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 499);
            this.Controls.Add(this.btnVerDescricao);
            this.Controls.Add(this.btnDeletarDiagnostico);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvDiagnosticosDoExame);
            this.Name = "FormDiagnosticosDoExame";
            this.Text = "FormDiagnosticosDoExame";
            this.Load += new System.EventHandler(this.FormDiagnosticosDoExame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosticosDoExame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiagnosticosDoExame;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnDeletarDiagnostico;
        private System.Windows.Forms.Button btnVerDescricao;
    }
}