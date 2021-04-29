
namespace SistemaHospitalar.UI
{
    partial class FormTodasInternacoes
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
            this.dgvInternacoes = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.btnCadastrarInternacao = new System.Windows.Forms.Button();
            this.lblCopiarCPF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInternacoes
            // 
            this.dgvInternacoes.AllowUserToAddRows = false;
            this.dgvInternacoes.AllowUserToResizeColumns = false;
            this.dgvInternacoes.AllowUserToResizeRows = false;
            this.dgvInternacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInternacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternacoes.EnableHeadersVisualStyles = false;
            this.dgvInternacoes.GridColor = System.Drawing.Color.Black;
            this.dgvInternacoes.Location = new System.Drawing.Point(75, 79);
            this.dgvInternacoes.Name = "dgvInternacoes";
            this.dgvInternacoes.ReadOnly = true;
            this.dgvInternacoes.Size = new System.Drawing.Size(870, 389);
            this.dgvInternacoes.TabIndex = 0;
            this.dgvInternacoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInternacoes_CellContentClick_1);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(75, 505);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 73);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePaciente.Location = new System.Drawing.Point(75, 51);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(343, 26);
            this.txtNomePaciente.TabIndex = 2;
            this.txtNomePaciente.TextChanged += new System.EventHandler(this.txtNomePaciente_TextChanged);
            // 
            // btnCadastrarInternacao
            // 
            this.btnCadastrarInternacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarInternacao.Location = new System.Drawing.Point(798, 505);
            this.btnCadastrarInternacao.Name = "btnCadastrarInternacao";
            this.btnCadastrarInternacao.Size = new System.Drawing.Size(147, 73);
            this.btnCadastrarInternacao.TabIndex = 6;
            this.btnCadastrarInternacao.Text = "Cadastrar Internação";
            this.btnCadastrarInternacao.UseVisualStyleBackColor = true;
            this.btnCadastrarInternacao.Click += new System.EventHandler(this.btnCadastrarInternacao_Click);
            // 
            // lblCopiarCPF
            // 
            this.lblCopiarCPF.AutoSize = true;
            this.lblCopiarCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopiarCPF.ForeColor = System.Drawing.Color.White;
            this.lblCopiarCPF.Location = new System.Drawing.Point(692, 51);
            this.lblCopiarCPF.Name = "lblCopiarCPF";
            this.lblCopiarCPF.Size = new System.Drawing.Size(253, 21);
            this.lblCopiarCPF.TabIndex = 7;
            this.lblCopiarCPF.Text = "Clique no CPF que deseja copiar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pesquisar por Nome / Cpf";
            // 
            // FormTodasInternacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1020, 600);
            this.Controls.Add(this.lblCopiarCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarInternacao);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvInternacoes);
            this.Name = "FormTodasInternacoes";
            this.Text = "FormTodasInternacoes";
            this.Load += new System.EventHandler(this.FormTodasInternacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInternacoes;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Button btnCadastrarInternacao;
        private System.Windows.Forms.Label lblCopiarCPF;
        private System.Windows.Forms.Label label1;
    }
}