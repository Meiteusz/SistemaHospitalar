
namespace SistemaHospitalar.UI
{
    partial class FormAgendarExame
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
            this.btnAgendarExame = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCpfPaciente = new System.Windows.Forms.Label();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNomeDoutor = new System.Windows.Forms.Label();
            this.lblEspecialidadeDoutor = new System.Windows.Forms.Label();
            this.dtpDataExame = new System.Windows.Forms.DateTimePicker();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTipoExame = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgendarExame
            // 
            this.btnAgendarExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarExame.Location = new System.Drawing.Point(761, 488);
            this.btnAgendarExame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgendarExame.Name = "btnAgendarExame";
            this.btnAgendarExame.Size = new System.Drawing.Size(147, 73);
            this.btnAgendarExame.TabIndex = 0;
            this.btnAgendarExame.Text = "Agendar Exame";
            this.btnAgendarExame.UseVisualStyleBackColor = true;
            this.btnAgendarExame.Click += new System.EventHandler(this.btnAgendarExame_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCpfPaciente);
            this.groupBox1.Controls.Add(this.lblNomePaciente);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(44, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(864, 106);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paciente";
            // 
            // lblCpfPaciente
            // 
            this.lblCpfPaciente.AutoSize = true;
            this.lblCpfPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfPaciente.Location = new System.Drawing.Point(561, 51);
            this.lblCpfPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpfPaciente.Name = "lblCpfPaciente";
            this.lblCpfPaciente.Size = new System.Drawing.Size(57, 20);
            this.lblCpfPaciente.TabIndex = 1;
            this.lblCpfPaciente.Text = "label2";
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.Location = new System.Drawing.Point(110, 51);
            this.lblNomePaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(57, 20);
            this.lblNomePaciente.TabIndex = 0;
            this.lblNomePaciente.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNomeDoutor);
            this.groupBox2.Controls.Add(this.lblEspecialidadeDoutor);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(44, 149);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(864, 106);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doutor(a)";
            // 
            // lblNomeDoutor
            // 
            this.lblNomeDoutor.AutoSize = true;
            this.lblNomeDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDoutor.Location = new System.Drawing.Point(110, 51);
            this.lblNomeDoutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeDoutor.Name = "lblNomeDoutor";
            this.lblNomeDoutor.Size = new System.Drawing.Size(57, 20);
            this.lblNomeDoutor.TabIndex = 2;
            this.lblNomeDoutor.Text = "label3";
            // 
            // lblEspecialidadeDoutor
            // 
            this.lblEspecialidadeDoutor.AutoSize = true;
            this.lblEspecialidadeDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidadeDoutor.Location = new System.Drawing.Point(561, 51);
            this.lblEspecialidadeDoutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecialidadeDoutor.Name = "lblEspecialidadeDoutor";
            this.lblEspecialidadeDoutor.Size = new System.Drawing.Size(57, 20);
            this.lblEspecialidadeDoutor.TabIndex = 3;
            this.lblEspecialidadeDoutor.Text = "label4";
            // 
            // dtpDataExame
            // 
            this.dtpDataExame.CustomFormat = "dd/MM/yyyy HH:mm tt";
            this.dtpDataExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataExame.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataExame.Location = new System.Drawing.Point(44, 306);
            this.dtpDataExame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDataExame.Name = "dtpDataExame";
            this.dtpDataExame.Size = new System.Drawing.Size(432, 26);
            this.dtpDataExame.TabIndex = 3;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(45, 488);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 73);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data do Exame";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(41, 350);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tipo do Exame";
            // 
            // txtTipoExame
            // 
            this.txtTipoExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoExame.Location = new System.Drawing.Point(44, 373);
            this.txtTipoExame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTipoExame.MaxLength = 50;
            this.txtTipoExame.Name = "txtTipoExame";
            this.txtTipoExame.Size = new System.Drawing.Size(608, 26);
            this.txtTipoExame.TabIndex = 7;
            // 
            // FormAgendarExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(959, 589);
            this.Controls.Add(this.txtTipoExame);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dtpDataExame);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgendarExame);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAgendarExame";
            this.Text = "FormExame";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgendarExame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCpfPaciente;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNomeDoutor;
        private System.Windows.Forms.Label lblEspecialidadeDoutor;
        private System.Windows.Forms.DateTimePicker dtpDataExame;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTipoExame;
    }
}