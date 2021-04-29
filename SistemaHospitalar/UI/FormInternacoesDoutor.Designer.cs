
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
            this.txtNomePacientes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNomePaciente = new System.Windows.Forms.RadioButton();
            this.rbNumeroQuarto = new System.Windows.Forms.RadioButton();
            this.txtNumeroQuarto = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternacoesDoutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroQuarto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInternacoesDoutor
            // 
            this.dgvInternacoesDoutor.AllowUserToAddRows = false;
            this.dgvInternacoesDoutor.AllowUserToResizeColumns = false;
            this.dgvInternacoesDoutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dgvInternacoesDoutor.Location = new System.Drawing.Point(24, 78);
            this.dgvInternacoesDoutor.Name = "dgvInternacoesDoutor";
            this.dgvInternacoesDoutor.ReadOnly = true;
            this.dgvInternacoesDoutor.Size = new System.Drawing.Size(1045, 363);
            this.dgvInternacoesDoutor.TabIndex = 0;
            this.dgvInternacoesDoutor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInternacoesDoutor_CellClick);
            // 
            // btnVerificarInternacao
            // 
            this.btnVerificarInternacao.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnVerificarInternacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(24, 483);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 73);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtNomePacientes
            // 
            this.txtNomePacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePacientes.Location = new System.Drawing.Point(24, 48);
            this.txtNomePacientes.Name = "txtNomePacientes";
            this.txtNomePacientes.Size = new System.Drawing.Size(343, 26);
            this.txtNomePacientes.TabIndex = 6;
            this.txtNomePacientes.TextChanged += new System.EventHandler(this.txtNomePacientes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pesquisar por Nome/Quarto do Paciente";
            // 
            // rbNomePaciente
            // 
            this.rbNomePaciente.AutoSize = true;
            this.rbNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNomePaciente.Location = new System.Drawing.Point(170, 9);
            this.rbNomePaciente.Name = "rbNomePaciente";
            this.rbNomePaciente.Size = new System.Drawing.Size(135, 24);
            this.rbNomePaciente.TabIndex = 11;
            this.rbNomePaciente.TabStop = true;
            this.rbNomePaciente.Text = "Nome Paciente";
            this.rbNomePaciente.UseVisualStyleBackColor = true;
            this.rbNomePaciente.CheckedChanged += new System.EventHandler(this.rbNomePaciente_CheckedChanged);
            // 
            // rbNumeroQuarto
            // 
            this.rbNumeroQuarto.AutoSize = true;
            this.rbNumeroQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNumeroQuarto.Location = new System.Drawing.Point(421, 10);
            this.rbNumeroQuarto.Name = "rbNumeroQuarto";
            this.rbNumeroQuarto.Size = new System.Drawing.Size(136, 24);
            this.rbNumeroQuarto.TabIndex = 12;
            this.rbNumeroQuarto.TabStop = true;
            this.rbNumeroQuarto.Text = "Número Quarto";
            this.rbNumeroQuarto.UseVisualStyleBackColor = true;
            this.rbNumeroQuarto.CheckedChanged += new System.EventHandler(this.rbNumeroQuarto_CheckedChanged);
            // 
            // txtNumeroQuarto
            // 
            this.txtNumeroQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroQuarto.Location = new System.Drawing.Point(24, 47);
            this.txtNumeroQuarto.Name = "txtNumeroQuarto";
            this.txtNumeroQuarto.Size = new System.Drawing.Size(343, 26);
            this.txtNumeroQuarto.TabIndex = 13;
            this.txtNumeroQuarto.Visible = false;
            this.txtNumeroQuarto.ValueChanged += new System.EventHandler(this.txtNumeroQuarto_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNomePaciente);
            this.groupBox1.Controls.Add(this.rbNumeroQuarto);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(375, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 37);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de internação";
            // 
            // FormInternacoesDoutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1095, 568);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNumeroQuarto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomePacientes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnVerificarInternacao);
            this.Controls.Add(this.dgvInternacoesDoutor);
            this.Name = "FormInternacoesDoutor";
            this.Text = "FormInterncoesDoutor";
            this.Load += new System.EventHandler(this.FormInternacoesDoutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternacoesDoutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroQuarto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInternacoesDoutor;
        private System.Windows.Forms.Button btnVerificarInternacao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtNomePacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbNomePaciente;
        private System.Windows.Forms.RadioButton rbNumeroQuarto;
        private System.Windows.Forms.NumericUpDown txtNumeroQuarto;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}