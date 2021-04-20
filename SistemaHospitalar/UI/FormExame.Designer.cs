
namespace SistemaHospitalar.UI
{
    partial class FormExame
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.lblCpfPaciente = new System.Windows.Forms.Label();
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
            this.btnAgendarExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarExame.Location = new System.Drawing.Point(713, 232);
            this.btnAgendarExame.Name = "btnAgendarExame";
            this.btnAgendarExame.Size = new System.Drawing.Size(146, 56);
            this.btnAgendarExame.TabIndex = 0;
            this.btnAgendarExame.Text = "Agendar Exame";
            this.btnAgendarExame.UseVisualStyleBackColor = true;
            this.btnAgendarExame.Click += new System.EventHandler(this.btnAgendarExame_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCpfPaciente);
            this.groupBox1.Controls.Add(this.lblNomePaciente);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paciente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNomeDoutor);
            this.groupBox2.Controls.Add(this.lblEspecialidadeDoutor);
            this.groupBox2.Location = new System.Drawing.Point(452, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 69);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doutor(a)";
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.Location = new System.Drawing.Point(73, 33);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(51, 20);
            this.lblNomePaciente.TabIndex = 0;
            this.lblNomePaciente.Text = "label1";
            // 
            // lblCpfPaciente
            // 
            this.lblCpfPaciente.AutoSize = true;
            this.lblCpfPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfPaciente.Location = new System.Drawing.Point(249, 33);
            this.lblCpfPaciente.Name = "lblCpfPaciente";
            this.lblCpfPaciente.Size = new System.Drawing.Size(51, 20);
            this.lblCpfPaciente.TabIndex = 1;
            this.lblCpfPaciente.Text = "label2";
            // 
            // lblNomeDoutor
            // 
            this.lblNomeDoutor.AutoSize = true;
            this.lblNomeDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDoutor.Location = new System.Drawing.Point(73, 33);
            this.lblNomeDoutor.Name = "lblNomeDoutor";
            this.lblNomeDoutor.Size = new System.Drawing.Size(51, 20);
            this.lblNomeDoutor.TabIndex = 2;
            this.lblNomeDoutor.Text = "label3";
            // 
            // lblEspecialidadeDoutor
            // 
            this.lblEspecialidadeDoutor.AutoSize = true;
            this.lblEspecialidadeDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidadeDoutor.Location = new System.Drawing.Point(249, 33);
            this.lblEspecialidadeDoutor.Name = "lblEspecialidadeDoutor";
            this.lblEspecialidadeDoutor.Size = new System.Drawing.Size(51, 20);
            this.lblEspecialidadeDoutor.TabIndex = 3;
            this.lblEspecialidadeDoutor.Text = "label4";
            // 
            // dtpDataExame
            // 
            this.dtpDataExame.CustomFormat = "dd/MM/yyyy HH:mm tt";
            this.dtpDataExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataExame.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataExame.Location = new System.Drawing.Point(29, 154);
            this.dtpDataExame.Name = "dtpDataExame";
            this.dtpDataExame.Size = new System.Drawing.Size(289, 26);
            this.dtpDataExame.TabIndex = 3;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(28, 232);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(146, 56);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data do Exame";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tipo do Exame";
            // 
            // txtTipoExame
            // 
            this.txtTipoExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoExame.Location = new System.Drawing.Point(452, 154);
            this.txtTipoExame.MaxLength = 50;
            this.txtTipoExame.Name = "txtTipoExame";
            this.txtTipoExame.Size = new System.Drawing.Size(407, 26);
            this.txtTipoExame.TabIndex = 7;
            // 
            // FormExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 303);
            this.Controls.Add(this.txtTipoExame);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dtpDataExame);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgendarExame);
            this.Name = "FormExame";
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