
namespace SistemaHospitalar.UI
{
    partial class FormExamesDoutor
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
            this.dgvExames = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnFazerDiagnóstico = new System.Windows.Forms.Button();
            this.btnVerDiagnósticosDoExame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExames
            // 
            this.dgvExames.AllowUserToAddRows = false;
            this.dgvExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExames.Location = new System.Drawing.Point(109, 32);
            this.dgvExames.Name = "dgvExames";
            this.dgvExames.ReadOnly = true;
            this.dgvExames.Size = new System.Drawing.Size(658, 316);
            this.dgvExames.TabIndex = 0;
            this.dgvExames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExames_CellClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(109, 425);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(145, 60);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnFazerDiagnóstico
            // 
            this.btnFazerDiagnóstico.Location = new System.Drawing.Point(622, 425);
            this.btnFazerDiagnóstico.Name = "btnFazerDiagnóstico";
            this.btnFazerDiagnóstico.Size = new System.Drawing.Size(145, 60);
            this.btnFazerDiagnóstico.TabIndex = 2;
            this.btnFazerDiagnóstico.Text = "Fazer Diagnóstico";
            this.btnFazerDiagnóstico.UseVisualStyleBackColor = true;
            this.btnFazerDiagnóstico.Click += new System.EventHandler(this.btnFazerDiagnóstico_Click);
            // 
            // btnVerDiagnósticosDoExame
            // 
            this.btnVerDiagnósticosDoExame.Location = new System.Drawing.Point(379, 425);
            this.btnVerDiagnósticosDoExame.Name = "btnVerDiagnósticosDoExame";
            this.btnVerDiagnósticosDoExame.Size = new System.Drawing.Size(145, 60);
            this.btnVerDiagnósticosDoExame.TabIndex = 3;
            this.btnVerDiagnósticosDoExame.Text = "Ver diagnósticos do exame";
            this.btnVerDiagnósticosDoExame.UseVisualStyleBackColor = true;
            this.btnVerDiagnósticosDoExame.Click += new System.EventHandler(this.btnVerDiagnósticosDoExame_Click);
            // 
            // FormExamesDoutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 530);
            this.Controls.Add(this.btnVerDiagnósticosDoExame);
            this.Controls.Add(this.btnFazerDiagnóstico);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvExames);
            this.Name = "FormExamesDoutor";
            this.Text = "FormExamesDoutor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExames;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnFazerDiagnóstico;
        private System.Windows.Forms.Button btnVerDiagnósticosDoExame;
    }
}