
namespace SistemaHospitalar.UI
{
    partial class FormADM
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
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbTurno = new System.Windows.Forms.RadioButton();
            this.rbEspecialidade = new System.Windows.Forms.RadioButton();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.cmbEspecialidade = new System.Windows.Forms.ComboBox();
            this.rbRecepcionista = new System.Windows.Forms.RadioButton();
            this.rbDoutor = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrarRecepcionista
            // 
            this.btnCadastrarRecepcionista.Location = new System.Drawing.Point(624, 55);
            this.btnCadastrarRecepcionista.Name = "btnCadastrarRecepcionista";
            this.btnCadastrarRecepcionista.Size = new System.Drawing.Size(154, 69);
            this.btnCadastrarRecepcionista.TabIndex = 0;
            this.btnCadastrarRecepcionista.Text = "Cadastrar Recepcionista";
            this.btnCadastrarRecepcionista.UseVisualStyleBackColor = true;
            this.btnCadastrarRecepcionista.Click += new System.EventHandler(this.btnCadastrarRecepcionista_Click);
            // 
            // btnCadastrarDoutor
            // 
            this.btnCadastrarDoutor.Location = new System.Drawing.Point(624, 145);
            this.btnCadastrarDoutor.Name = "btnCadastrarDoutor";
            this.btnCadastrarDoutor.Size = new System.Drawing.Size(154, 69);
            this.btnCadastrarDoutor.TabIndex = 1;
            this.btnCadastrarDoutor.Text = "Cadastrar Doutor(a)";
            this.btnCadastrarDoutor.UseVisualStyleBackColor = true;
            this.btnCadastrarDoutor.Click += new System.EventHandler(this.btnCadastrarDoutor_Click);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(25, 56);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.Size = new System.Drawing.Size(579, 321);
            this.dgvFuncionarios.TabIndex = 2;
            this.dgvFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(25, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(209, 26);
            this.txtPesquisa.TabIndex = 5;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(537, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(67, 38);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnDeletarFuncionario
            // 
            this.btnDeletarFuncionario.Location = new System.Drawing.Point(624, 317);
            this.btnDeletarFuncionario.Name = "btnDeletarFuncionario";
            this.btnDeletarFuncionario.Size = new System.Drawing.Size(154, 60);
            this.btnDeletarFuncionario.TabIndex = 7;
            this.btnDeletarFuncionario.UseVisualStyleBackColor = true;
            this.btnDeletarFuncionario.Click += new System.EventHandler(this.btnDeletarFuncionario_Click);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Location = new System.Drawing.Point(24, 19);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(53, 17);
            this.rbNome.TabIndex = 9;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.rbNome_CheckedChanged);
            // 
            // rbTurno
            // 
            this.rbTurno.AutoSize = true;
            this.rbTurno.Location = new System.Drawing.Point(112, 19);
            this.rbTurno.Name = "rbTurno";
            this.rbTurno.Size = new System.Drawing.Size(53, 17);
            this.rbTurno.TabIndex = 10;
            this.rbTurno.TabStop = true;
            this.rbTurno.Text = "Turno";
            this.rbTurno.UseVisualStyleBackColor = true;
            this.rbTurno.CheckedChanged += new System.EventHandler(this.rbTurno_CheckedChanged);
            // 
            // rbEspecialidade
            // 
            this.rbEspecialidade.AutoSize = true;
            this.rbEspecialidade.Location = new System.Drawing.Point(195, 21);
            this.rbEspecialidade.Name = "rbEspecialidade";
            this.rbEspecialidade.Size = new System.Drawing.Size(91, 17);
            this.rbEspecialidade.TabIndex = 11;
            this.rbEspecialidade.TabStop = true;
            this.rbEspecialidade.Text = "Especialidade";
            this.rbEspecialidade.UseVisualStyleBackColor = true;
            this.rbEspecialidade.CheckedChanged += new System.EventHandler(this.rbEspecialidade_CheckedChanged);
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(25, 19);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(209, 26);
            this.cmbTurno.TabIndex = 12;
            // 
            // cmbEspecialidade
            // 
            this.cmbEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspecialidade.FormattingEnabled = true;
            this.cmbEspecialidade.Location = new System.Drawing.Point(25, 19);
            this.cmbEspecialidade.Name = "cmbEspecialidade";
            this.cmbEspecialidade.Size = new System.Drawing.Size(209, 26);
            this.cmbEspecialidade.TabIndex = 13;
            // 
            // rbRecepcionista
            // 
            this.rbRecepcionista.AutoSize = true;
            this.rbRecepcionista.Location = new System.Drawing.Point(218, 400);
            this.rbRecepcionista.Name = "rbRecepcionista";
            this.rbRecepcionista.Size = new System.Drawing.Size(93, 17);
            this.rbRecepcionista.TabIndex = 14;
            this.rbRecepcionista.TabStop = true;
            this.rbRecepcionista.Text = "Recepcionista";
            this.rbRecepcionista.UseVisualStyleBackColor = true;
            this.rbRecepcionista.CheckedChanged += new System.EventHandler(this.rbRecepcionista_CheckedChanged_1);
            // 
            // rbDoutor
            // 
            this.rbDoutor.AutoSize = true;
            this.rbDoutor.Location = new System.Drawing.Point(350, 400);
            this.rbDoutor.Name = "rbDoutor";
            this.rbDoutor.Size = new System.Drawing.Size(69, 17);
            this.rbDoutor.TabIndex = 15;
            this.rbDoutor.TabStop = true;
            this.rbDoutor.Text = "Doutor(a)";
            this.rbDoutor.UseVisualStyleBackColor = true;
            this.rbDoutor.CheckedChanged += new System.EventHandler(this.rbDoutor_CheckedChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEspecialidade);
            this.groupBox1.Controls.Add(this.rbNome);
            this.groupBox1.Controls.Add(this.rbTurno);
            this.groupBox1.Location = new System.Drawing.Point(238, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 44);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Filtro";
            // 
            // FormADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbDoutor);
            this.Controls.Add(this.rbRecepcionista);
            this.Controls.Add(this.cmbEspecialidade);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.btnDeletarFuncionario);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.btnCadastrarDoutor);
            this.Controls.Add(this.btnCadastrarRecepcionista);
            this.Name = "FormADM";
            this.Text = "FormADM";
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
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbTurno;
        private System.Windows.Forms.RadioButton rbEspecialidade;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.ComboBox cmbEspecialidade;
        private System.Windows.Forms.RadioButton rbRecepcionista;
        private System.Windows.Forms.RadioButton rbDoutor;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}