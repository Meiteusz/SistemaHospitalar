
namespace SistemaHospitalar.UI
{
    partial class FormExames
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
            this.btnReagendarExame = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbDataHoje = new System.Windows.Forms.RadioButton();
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
            this.dgvExames.AllowUserToResizeRows = false;
            this.dgvExames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExames.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExames.GridColor = System.Drawing.Color.Black;
            this.dgvExames.Location = new System.Drawing.Point(57, 109);
            this.dgvExames.Name = "dgvExames";
            this.dgvExames.ReadOnly = true;
            this.dgvExames.Size = new System.Drawing.Size(962, 366);
            this.dgvExames.TabIndex = 0;
            this.dgvExames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExames_CellClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(57, 509);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 73);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnReagendarExame
            // 
            this.btnReagendarExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReagendarExame.Location = new System.Drawing.Point(872, 509);
            this.btnReagendarExame.Name = "btnReagendarExame";
            this.btnReagendarExame.Size = new System.Drawing.Size(147, 73);
            this.btnReagendarExame.TabIndex = 4;
            this.btnReagendarExame.Text = "Reagendar Exame";
            this.btnReagendarExame.UseVisualStyleBackColor = true;
            this.btnReagendarExame.Click += new System.EventHandler(this.btnReagendarExame_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Controls.Add(this.rbDataHoje);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(406, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 37);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de exame";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.Location = new System.Drawing.Point(185, 9);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(71, 24);
            this.rbTodos.TabIndex = 3;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbDataHoje
            // 
            this.rbDataHoje.AutoSize = true;
            this.rbDataHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDataHoje.Location = new System.Drawing.Point(355, 8);
            this.rbDataHoje.Name = "rbDataHoje";
            this.rbDataHoje.Size = new System.Drawing.Size(60, 24);
            this.rbDataHoje.TabIndex = 4;
            this.rbDataHoje.TabStop = true;
            this.rbDataHoje.Text = "Hoje";
            this.rbDataHoje.UseVisualStyleBackColor = true;
            this.rbDataHoje.CheckedChanged += new System.EventHandler(this.rbDataHoje_CheckedChanged);
            // 
            // txtNomePacientes
            // 
            this.txtNomePacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePacientes.Location = new System.Drawing.Point(57, 77);
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
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pesquisar por Nome";
            // 
            // FormExames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1080, 594);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNomePacientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReagendarExame);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvExames);
            this.Name = "FormExames";
            this.Text = "FormExames";
            this.Load += new System.EventHandler(this.FormExames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExames;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnReagendarExame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbDataHoje;
        private System.Windows.Forms.TextBox txtNomePacientes;
        private System.Windows.Forms.Label label1;
    }
}