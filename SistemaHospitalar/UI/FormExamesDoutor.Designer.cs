
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvExames = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnFazerDiagnóstico = new System.Windows.Forms.Button();
            this.btnVerDiagnósticosDoExame = new System.Windows.Forms.Button();
            this.rbTodosExames = new System.Windows.Forms.RadioButton();
            this.rbExamesHoje = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomePacientes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExames
            // 
            this.dgvExames.AllowUserToAddRows = false;
            this.dgvExames.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExames.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExames.EnableHeadersVisualStyles = false;
            this.dgvExames.GridColor = System.Drawing.Color.Black;
            this.dgvExames.Location = new System.Drawing.Point(86, 83);
            this.dgvExames.Name = "dgvExames";
            this.dgvExames.ReadOnly = true;
            this.dgvExames.Size = new System.Drawing.Size(797, 360);
            this.dgvExames.TabIndex = 0;
            this.dgvExames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExames_CellClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(86, 492);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 73);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnFazerDiagnóstico
            // 
            this.btnFazerDiagnóstico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazerDiagnóstico.Location = new System.Drawing.Point(736, 492);
            this.btnFazerDiagnóstico.Name = "btnFazerDiagnóstico";
            this.btnFazerDiagnóstico.Size = new System.Drawing.Size(147, 73);
            this.btnFazerDiagnóstico.TabIndex = 2;
            this.btnFazerDiagnóstico.Text = "Fazer Diagnóstico";
            this.btnFazerDiagnóstico.UseVisualStyleBackColor = true;
            this.btnFazerDiagnóstico.Click += new System.EventHandler(this.btnFazerDiagnóstico_Click);
            // 
            // btnVerDiagnósticosDoExame
            // 
            this.btnVerDiagnósticosDoExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDiagnósticosDoExame.Location = new System.Drawing.Point(415, 492);
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
            this.rbTodosExames.Location = new System.Drawing.Point(144, 9);
            this.rbTodosExames.Name = "rbTodosExames";
            this.rbTodosExames.Size = new System.Drawing.Size(71, 24);
            this.rbTodosExames.TabIndex = 4;
            this.rbTodosExames.TabStop = true;
            this.rbTodosExames.Text = "Todos";
            this.rbTodosExames.UseVisualStyleBackColor = true;
            this.rbTodosExames.CheckedChanged += new System.EventHandler(this.rbTodosExames_CheckedChanged);
            // 
            // rbExamesHoje
            // 
            this.rbExamesHoje.AutoSize = true;
            this.rbExamesHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExamesHoje.Location = new System.Drawing.Point(247, 9);
            this.rbExamesHoje.Name = "rbExamesHoje";
            this.rbExamesHoje.Size = new System.Drawing.Size(60, 24);
            this.rbExamesHoje.TabIndex = 5;
            this.rbExamesHoje.TabStop = true;
            this.rbExamesHoje.Text = "Hoje";
            this.rbExamesHoje.UseVisualStyleBackColor = true;
            this.rbExamesHoje.CheckedChanged += new System.EventHandler(this.rbExamesHoje_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTodosExames);
            this.groupBox1.Controls.Add(this.rbExamesHoje);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(436, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 37);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de exame";
            // 
            // txtNomePacientes
            // 
            this.txtNomePacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePacientes.Location = new System.Drawing.Point(87, 54);
            this.txtNomePacientes.Name = "txtNomePacientes";
            this.txtNomePacientes.Size = new System.Drawing.Size(343, 26);
            this.txtNomePacientes.TabIndex = 11;
            this.txtNomePacientes.TextChanged += new System.EventHandler(this.txtNomePacientes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pesquisar por Paciente";
            // 
            // FormExamesDoutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(970, 581);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNomePacientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerDiagnósticosDoExame);
            this.Controls.Add(this.btnFazerDiagnóstico);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvExames);
            this.Name = "FormExamesDoutor";
            this.Text = "FormExamesDoutor";
            this.Load += new System.EventHandler(this.FormExamesDoutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomePacientes;
        private System.Windows.Forms.Label label1;
    }
}