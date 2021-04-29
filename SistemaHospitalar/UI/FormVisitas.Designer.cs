
namespace SistemaHospitalar.UI
{
    partial class FormVisitas
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
            this.cmbVisitantes = new System.Windows.Forms.ComboBox();
            this.cmbPacientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataVisita = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgendarVisita = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNomeVisitante = new System.Windows.Forms.Label();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.dgvVisitas = new System.Windows.Forms.DataGridView();
            this.txtNomeVisitante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCadastrarVisitante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVisitantes
            // 
            this.cmbVisitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVisitantes.FormattingEnabled = true;
            this.cmbVisitantes.Location = new System.Drawing.Point(939, 233);
            this.cmbVisitantes.Name = "cmbVisitantes";
            this.cmbVisitantes.Size = new System.Drawing.Size(225, 28);
            this.cmbVisitantes.TabIndex = 16;
            this.cmbVisitantes.SelectedIndexChanged += new System.EventHandler(this.cbVisitantes_SelectedIndexChanged);
            // 
            // cmbPacientes
            // 
            this.cmbPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPacientes.FormattingEnabled = true;
            this.cmbPacientes.Location = new System.Drawing.Point(939, 102);
            this.cmbPacientes.Name = "cmbPacientes";
            this.cmbPacientes.Size = new System.Drawing.Size(225, 28);
            this.cmbPacientes.TabIndex = 17;
            this.cmbPacientes.SelectedIndexChanged += new System.EventHandler(this.cbPacientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(935, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Visitante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(935, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Paciente internado";
            // 
            // dtpDataVisita
            // 
            this.dtpDataVisita.CustomFormat = "dd/MM/yyyy HH:mm tt";
            this.dtpDataVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataVisita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataVisita.Location = new System.Drawing.Point(939, 359);
            this.dtpDataVisita.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpDataVisita.MinDate = new System.DateTime(2021, 3, 18, 16, 54, 53, 0);
            this.dtpDataVisita.Name = "dtpDataVisita";
            this.dtpDataVisita.Size = new System.Drawing.Size(225, 27);
            this.dtpDataVisita.TabIndex = 20;
            this.dtpDataVisita.Value = new System.DateTime(2021, 3, 18, 17, 41, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(936, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Data da visita";
            // 
            // btnAgendarVisita
            // 
            this.btnAgendarVisita.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarVisita.Location = new System.Drawing.Point(786, 465);
            this.btnAgendarVisita.Name = "btnAgendarVisita";
            this.btnAgendarVisita.Size = new System.Drawing.Size(147, 73);
            this.btnAgendarVisita.TabIndex = 22;
            this.btnAgendarVisita.Text = "Agendar visita";
            this.btnAgendarVisita.UseVisualStyleBackColor = true;
            this.btnAgendarVisita.Click += new System.EventHandler(this.btnAgendarVisita_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(29, 465);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 73);
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(934, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(935, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nome:";
            // 
            // lblNomeVisitante
            // 
            this.lblNomeVisitante.AutoSize = true;
            this.lblNomeVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeVisitante.ForeColor = System.Drawing.Color.White;
            this.lblNomeVisitante.Location = new System.Drawing.Point(996, 266);
            this.lblNomeVisitante.Name = "lblNomeVisitante";
            this.lblNomeVisitante.Size = new System.Drawing.Size(0, 20);
            this.lblNomeVisitante.TabIndex = 26;
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.ForeColor = System.Drawing.Color.White;
            this.lblNomePaciente.Location = new System.Drawing.Point(997, 136);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(0, 20);
            this.lblNomePaciente.TabIndex = 27;
            // 
            // dgvVisitas
            // 
            this.dgvVisitas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitas.EnableHeadersVisualStyles = false;
            this.dgvVisitas.GridColor = System.Drawing.Color.Black;
            this.dgvVisitas.Location = new System.Drawing.Point(27, 77);
            this.dgvVisitas.Name = "dgvVisitas";
            this.dgvVisitas.ReadOnly = true;
            this.dgvVisitas.Size = new System.Drawing.Size(906, 309);
            this.dgvVisitas.TabIndex = 28;
            // 
            // txtNomeVisitante
            // 
            this.txtNomeVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeVisitante.Location = new System.Drawing.Point(27, 47);
            this.txtNomeVisitante.Name = "txtNomeVisitante";
            this.txtNomeVisitante.Size = new System.Drawing.Size(343, 26);
            this.txtNomeVisitante.TabIndex = 29;
            this.txtNomeVisitante.TextChanged += new System.EventHandler(this.txtNomeVisitante_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Pesquisar visitante por Nome";
            // 
            // btnCadastrarVisitante
            // 
            this.btnCadastrarVisitante.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarVisitante.Location = new System.Drawing.Point(426, 465);
            this.btnCadastrarVisitante.Name = "btnCadastrarVisitante";
            this.btnCadastrarVisitante.Size = new System.Drawing.Size(147, 73);
            this.btnCadastrarVisitante.TabIndex = 32;
            this.btnCadastrarVisitante.Text = "Cadastrar Visitante";
            this.btnCadastrarVisitante.UseVisualStyleBackColor = true;
            this.btnCadastrarVisitante.Click += new System.EventHandler(this.btnCadastrarVisitante_Click);
            // 
            // FormVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1267, 576);
            this.Controls.Add(this.btnCadastrarVisitante);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNomeVisitante);
            this.Controls.Add(this.dgvVisitas);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.lblNomeVisitante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAgendarVisita);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataVisita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPacientes);
            this.Controls.Add(this.cmbVisitantes);
            this.Name = "FormVisitas";
            this.Text = "FormVisitas";
            this.Load += new System.EventHandler(this.FormVisitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVisitantes;
        private System.Windows.Forms.ComboBox cmbPacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataVisita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgendarVisita;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNomeVisitante;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.DataGridView dgvVisitas;
        private System.Windows.Forms.TextBox txtNomeVisitante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCadastrarVisitante;
    }
}