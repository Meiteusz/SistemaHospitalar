
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
            this.dgvDiagnosticosDoExame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnosticosDoExame.Location = new System.Drawing.Point(33, 22);
            this.dgvDiagnosticosDoExame.Name = "dgvDiagnosticosDoExame";
            this.dgvDiagnosticosDoExame.ReadOnly = true;
            this.dgvDiagnosticosDoExame.Size = new System.Drawing.Size(587, 297);
            this.dgvDiagnosticosDoExame.TabIndex = 0;
            this.dgvDiagnosticosDoExame.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnosticosDoExame_CellClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(33, 364);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(150, 65);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Fechar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnDeletarDiagnostico
            // 
            this.btnDeletarDiagnostico.Location = new System.Drawing.Point(253, 364);
            this.btnDeletarDiagnostico.Name = "btnDeletarDiagnostico";
            this.btnDeletarDiagnostico.Size = new System.Drawing.Size(150, 65);
            this.btnDeletarDiagnostico.TabIndex = 2;
            this.btnDeletarDiagnostico.Text = "Deletar Diagnostico";
            this.btnDeletarDiagnostico.UseVisualStyleBackColor = true;
            this.btnDeletarDiagnostico.Click += new System.EventHandler(this.btnDeletarDiagnostico_Click);
            // 
            // btnVerDescricao
            // 
            this.btnVerDescricao.Location = new System.Drawing.Point(470, 364);
            this.btnVerDescricao.Name = "btnVerDescricao";
            this.btnVerDescricao.Size = new System.Drawing.Size(150, 65);
            this.btnVerDescricao.TabIndex = 3;
            this.btnVerDescricao.Text = "Ver Descricao";
            this.btnVerDescricao.UseVisualStyleBackColor = true;
            this.btnVerDescricao.Click += new System.EventHandler(this.btnVerDescricao_Click);
            // 
            // FormDiagnosticosDoExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 464);
            this.Controls.Add(this.btnVerDescricao);
            this.Controls.Add(this.btnDeletarDiagnostico);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvDiagnosticosDoExame);
            this.Name = "FormDiagnosticosDoExame";
            this.Text = "FormDiagnosticosDoExame";
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