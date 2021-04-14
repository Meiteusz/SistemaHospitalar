
namespace SistemaHospitalar.UI
{
    partial class FormFuncionarios
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
            this.btnCadastrarRecepcionista = new System.Windows.Forms.Button();
            this.btnCadastrarDoutor = new System.Windows.Forms.Button();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnDeletarFuncionario = new System.Windows.Forms.Button();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.cmbEspecialidade = new System.Windows.Forms.ComboBox();
            this.rbRecepcionista = new System.Windows.Forms.RadioButton();
            this.rbDoutor = new System.Windows.Forms.RadioButton();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimparFiltros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrarRecepcionista
            // 
            this.btnCadastrarRecepcionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarRecepcionista.Location = new System.Drawing.Point(124, 455);
            this.btnCadastrarRecepcionista.Name = "btnCadastrarRecepcionista";
            this.btnCadastrarRecepcionista.Size = new System.Drawing.Size(157, 64);
            this.btnCadastrarRecepcionista.TabIndex = 0;
            this.btnCadastrarRecepcionista.Text = "Cadastrar Recepcionista";
            this.btnCadastrarRecepcionista.UseVisualStyleBackColor = true;
            this.btnCadastrarRecepcionista.Click += new System.EventHandler(this.btnCadastrarRecepcionista_Click);
            // 
            // btnCadastrarDoutor
            // 
            this.btnCadastrarDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarDoutor.Location = new System.Drawing.Point(561, 455);
            this.btnCadastrarDoutor.Name = "btnCadastrarDoutor";
            this.btnCadastrarDoutor.Size = new System.Drawing.Size(157, 64);
            this.btnCadastrarDoutor.TabIndex = 1;
            this.btnCadastrarDoutor.Text = "Cadastrar Doutor(a)";
            this.btnCadastrarDoutor.UseVisualStyleBackColor = true;
            this.btnCadastrarDoutor.Click += new System.EventHandler(this.btnCadastrarDoutor_Click);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(25, 118);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.Size = new System.Drawing.Size(794, 308);
            this.dgvFuncionarios.TabIndex = 2;
            this.dgvFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(30, 40);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(334, 30);
            this.txtPesquisa.TabIndex = 5;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(1059, 455);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(157, 64);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnDeletarFuncionario
            // 
            this.btnDeletarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarFuncionario.Location = new System.Drawing.Point(345, 455);
            this.btnDeletarFuncionario.Name = "btnDeletarFuncionario";
            this.btnDeletarFuncionario.Size = new System.Drawing.Size(157, 64);
            this.btnDeletarFuncionario.TabIndex = 7;
            this.btnDeletarFuncionario.Text = "Deletar Funcionario";
            this.btnDeletarFuncionario.UseVisualStyleBackColor = true;
            this.btnDeletarFuncionario.Click += new System.EventHandler(this.btnDeletarFuncionario_Click);
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(30, 131);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(334, 32);
            this.cmbTurno.TabIndex = 12;
            // 
            // cmbEspecialidade
            // 
            this.cmbEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspecialidade.FormattingEnabled = true;
            this.cmbEspecialidade.Location = new System.Drawing.Point(30, 235);
            this.cmbEspecialidade.Name = "cmbEspecialidade";
            this.cmbEspecialidade.Size = new System.Drawing.Size(334, 32);
            this.cmbEspecialidade.TabIndex = 13;
            // 
            // rbRecepcionista
            // 
            this.rbRecepcionista.AutoSize = true;
            this.rbRecepcionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRecepcionista.Location = new System.Drawing.Point(292, 88);
            this.rbRecepcionista.Name = "rbRecepcionista";
            this.rbRecepcionista.Size = new System.Drawing.Size(128, 24);
            this.rbRecepcionista.TabIndex = 14;
            this.rbRecepcionista.TabStop = true;
            this.rbRecepcionista.Text = "Recepcionista";
            this.rbRecepcionista.UseVisualStyleBackColor = true;
            this.rbRecepcionista.CheckedChanged += new System.EventHandler(this.rbRecepcionista_CheckedChanged_1);
            // 
            // rbDoutor
            // 
            this.rbDoutor.AutoSize = true;
            this.rbDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDoutor.Location = new System.Drawing.Point(452, 88);
            this.rbDoutor.Name = "rbDoutor";
            this.rbDoutor.Size = new System.Drawing.Size(95, 24);
            this.rbDoutor.TabIndex = 15;
            this.rbDoutor.TabStop = true;
            this.rbDoutor.Text = "Doutor(a)";
            this.rbDoutor.UseVisualStyleBackColor = true;
            this.rbDoutor.CheckedChanged += new System.EventHandler(this.rbDoutor_CheckedChanged_1);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(25, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(123, 43);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimparFiltros
            // 
            this.btnLimparFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFiltros.Location = new System.Drawing.Point(825, 455);
            this.btnLimparFiltros.Name = "btnLimparFiltros";
            this.btnLimparFiltros.Size = new System.Drawing.Size(157, 64);
            this.btnLimparFiltros.TabIndex = 18;
            this.btnLimparFiltros.Text = "Limpar Filtros";
            this.btnLimparFiltros.UseVisualStyleBackColor = true;
            this.btnLimparFiltros.Click += new System.EventHandler(this.btnLimparFiltros_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Especialidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Turno";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEspecialidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbTurno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(825, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 308);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 642);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimparFiltros);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.rbDoutor);
            this.Controls.Add(this.rbRecepcionista);
            this.Controls.Add(this.btnDeletarFuncionario);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.btnCadastrarDoutor);
            this.Controls.Add(this.btnCadastrarRecepcionista);
            this.Name = "FormFuncionarios";
            this.Text = "FormFuncionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarRecepcionista;
        private System.Windows.Forms.Button btnCadastrarDoutor;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnDeletarFuncionario;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.ComboBox cmbEspecialidade;
        private System.Windows.Forms.RadioButton rbRecepcionista;
        private System.Windows.Forms.RadioButton rbDoutor;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimparFiltros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}