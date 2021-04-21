
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
            this.dgvInternacoesDoutor = new System.Windows.Forms.DataGridView();
            this.btnVerificarInternacao = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternacoesDoutor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInternacoesDoutor
            // 
            this.dgvInternacoesDoutor.AllowUserToAddRows = false;
            this.dgvInternacoesDoutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.btnVerificarInternacao.Location = new System.Drawing.Point(946, 500);
            this.btnVerificarInternacao.Name = "btnVerificarInternacao";
            this.btnVerificarInternacao.Size = new System.Drawing.Size(137, 56);
            this.btnVerificarInternacao.TabIndex = 1;
            this.btnVerificarInternacao.Text = "Verificar Internacao";
            this.btnVerificarInternacao.UseVisualStyleBackColor = true;
            this.btnVerificarInternacao.Click += new System.EventHandler(this.btnVerificarInternacao_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(13, 500);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(137, 56);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternacoesDoutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInternacoesDoutor;
        private System.Windows.Forms.Button btnVerificarInternacao;
        private System.Windows.Forms.Button btnVoltar;
    }
}