
namespace SistemaHospitalar.UI
{
    partial class FormPacientes
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
            this.btnCadastroDePaciente = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbGravidade = new System.Windows.Forms.RadioButton();
            this.cmbGravidade = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMensagemPaciente = new System.Windows.Forms.Button();
            this.btnDeletarPaciente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastroDePaciente
            // 
            this.btnCadastroDePaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastroDePaciente.Location = new System.Drawing.Point(575, 50);
            this.btnCadastroDePaciente.Name = "btnCadastroDePaciente";
            this.btnCadastroDePaciente.Size = new System.Drawing.Size(193, 55);
            this.btnCadastroDePaciente.TabIndex = 0;
            this.btnCadastroDePaciente.Text = "Cadastro de Pacientes";
            this.btnCadastroDePaciente.UseVisualStyleBackColor = true;
            this.btnCadastroDePaciente.Click += new System.EventHandler(this.btnCadastroDePaciente_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(12, 50);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.Size = new System.Drawing.Size(531, 394);
            this.dgvPacientes.TabIndex = 1;
            this.dgvPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.Location = new System.Drawing.Point(575, 383);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(193, 55);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::SistemaHospitalar.Properties.Resources.search_icon;
            this.btnPesquisar.Location = new System.Drawing.Point(503, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(40, 38);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaNome.Location = new System.Drawing.Point(12, 18);
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(281, 26);
            this.txtPesquisaNome.TabIndex = 7;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Location = new System.Drawing.Point(2, 24);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(53, 17);
            this.rbNome.TabIndex = 9;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.rbNome_CheckedChanged);
            // 
            // rbGravidade
            // 
            this.rbGravidade.AutoSize = true;
            this.rbGravidade.Location = new System.Drawing.Point(100, 24);
            this.rbGravidade.Name = "rbGravidade";
            this.rbGravidade.Size = new System.Drawing.Size(74, 17);
            this.rbGravidade.TabIndex = 10;
            this.rbGravidade.TabStop = true;
            this.rbGravidade.Text = "Gravidade";
            this.rbGravidade.UseVisualStyleBackColor = true;
            this.rbGravidade.CheckedChanged += new System.EventHandler(this.rbGravidade_CheckedChanged);
            // 
            // cmbGravidade
            // 
            this.cmbGravidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGravidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGravidade.FormattingEnabled = true;
            this.cmbGravidade.Location = new System.Drawing.Point(12, 18);
            this.cmbGravidade.Name = "cmbGravidade";
            this.cmbGravidade.Size = new System.Drawing.Size(281, 26);
            this.cmbGravidade.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGravidade);
            this.groupBox1.Controls.Add(this.rbNome);
            this.groupBox1.Location = new System.Drawing.Point(318, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 46);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Filtro";
            // 
            // btnMensagemPaciente
            // 
            this.btnMensagemPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMensagemPaciente.Location = new System.Drawing.Point(575, 201);
            this.btnMensagemPaciente.Name = "btnMensagemPaciente";
            this.btnMensagemPaciente.Size = new System.Drawing.Size(193, 55);
            this.btnMensagemPaciente.TabIndex = 13;
            this.btnMensagemPaciente.Text = "Mensagens aos Pacientes";
            this.btnMensagemPaciente.UseVisualStyleBackColor = true;
            // 
            // btnDeletarPaciente
            // 
            this.btnDeletarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletarPaciente.Location = new System.Drawing.Point(575, 125);
            this.btnDeletarPaciente.Name = "btnDeletarPaciente";
            this.btnDeletarPaciente.Size = new System.Drawing.Size(193, 55);
            this.btnDeletarPaciente.TabIndex = 14;
            this.btnDeletarPaciente.Text = "Deletar Pacientes";
            this.btnDeletarPaciente.UseVisualStyleBackColor = true;
            this.btnDeletarPaciente.Click += new System.EventHandler(this.btnDeletarPaciente_Click);
            // 
            // FormPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeletarPaciente);
            this.Controls.Add(this.btnMensagemPaciente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbGravidade);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisaNome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.btnCadastroDePaciente);
            this.Name = "FormPacientes";
            this.Text = "FormPacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroDePaciente;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbGravidade;
        private System.Windows.Forms.ComboBox cmbGravidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMensagemPaciente;
        private System.Windows.Forms.Button btnDeletarPaciente;
    }
}