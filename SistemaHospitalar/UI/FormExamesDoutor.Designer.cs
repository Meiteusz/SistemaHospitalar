
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
            this.rbTodosExames = new System.Windows.Forms.RadioButton();
            this.rbExamesHoje = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExames
            // 
            this.dgvExames.AllowUserToAddRows = false;
            this.dgvExames.AllowUserToResizeColumns = false;
            this.dgvExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExames.EnableHeadersVisualStyles = false;
            this.dgvExames.GridColor = System.Drawing.Color.Black;
            this.dgvExames.Location = new System.Drawing.Point(79, 68);
            this.dgvExames.Name = "dgvExames";
            this.dgvExames.ReadOnly = true;
            this.dgvExames.Size = new System.Drawing.Size(744, 335);
            this.dgvExames.TabIndex = 0;
            this.dgvExames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExames_CellClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(79, 452);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 73);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnFazerDiagnóstico
            // 
            this.btnFazerDiagnóstico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazerDiagnóstico.Location = new System.Drawing.Point(676, 452);
            this.btnFazerDiagnóstico.Name = "btnFazerDiagnóstico";
            this.btnFazerDiagnóstico.Size = new System.Drawing.Size(147, 73);
            this.btnFazerDiagnóstico.TabIndex = 2;
            this.btnFazerDiagnóstico.Text = "Fazer Diagnóstico";
            this.btnFazerDiagnóstico.UseVisualStyleBackColor = true;
            this.btnFazerDiagnóstico.Click += new System.EventHandler(this.btnFazerDiagnóstico_Click);
            // 
            // btnVerDiagnósticosDoExame
            // 
            this.btnVerDiagnósticosDoExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDiagnósticosDoExame.Location = new System.Drawing.Point(379, 452);
            this.btnVerDiagnósticosDoExame.Name = "btnVerDiagnósticosDoExame";
            this.btnVerDiagnósticosDoExame.Size = new System.Drawing.Size(147, 73);
            this.btnVerDiagnósticosDoExame.TabIndex = 3;
            this.btnVerDiagnósticosDoExame.Text = "Ver diagnósticos do exame";
            this.btnVerDiagnósticosDoExame.UseVisualStyleBackColor = true;
            this.btnVerDiagnósticosDoExame.Click += new System.EventHandler(this.btnVerDiagnósticosDoExame_Click);
            // 
            // rbTodosExames
            // 
            this.rbTodosExames.AutoSize = true;
            this.rbTodosExames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodosExames.Location = new System.Drawing.Point(250, 38);
            this.rbTodosExames.Name = "rbTodosExames";
            this.rbTodosExames.Size = new System.Drawing.Size(132, 24);
            this.rbTodosExames.TabIndex = 4;
            this.rbTodosExames.TabStop = true;
            this.rbTodosExames.Text = "Todos Exames";
            this.rbTodosExames.UseVisualStyleBackColor = true;
            this.rbTodosExames.CheckedChanged += new System.EventHandler(this.rbTodosExames_CheckedChanged);
            // 
            // rbExamesHoje
            // 
            this.rbExamesHoje.AutoSize = true;
            this.rbExamesHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExamesHoje.Location = new System.Drawing.Point(537, 38);
            this.rbExamesHoje.Name = "rbExamesHoje";
            this.rbExamesHoje.Size = new System.Drawing.Size(121, 24);
            this.rbExamesHoje.TabIndex = 5;
            this.rbExamesHoje.TabStop = true;
            this.rbExamesHoje.Text = "Exames Hoje";
            this.rbExamesHoje.UseVisualStyleBackColor = true;
            this.rbExamesHoje.CheckedChanged += new System.EventHandler(this.rbExamesHoje_CheckedChanged);
            // 
            // FormExamesDoutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 550);
            this.Controls.Add(this.rbExamesHoje);
            this.Controls.Add(this.rbTodosExames);
            this.Controls.Add(this.btnVerDiagnósticosDoExame);
            this.Controls.Add(this.btnFazerDiagnóstico);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvExames);
            this.Name = "FormExamesDoutor";
            this.Text = "FormExamesDoutor";
            this.Load += new System.EventHandler(this.FormExamesDoutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExames;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnFazerDiagnóstico;
        private System.Windows.Forms.Button btnVerDiagnósticosDoExame;
        private System.Windows.Forms.RadioButton rbTodosExames;
        private System.Windows.Forms.RadioButton rbExamesHoje;
    }
}