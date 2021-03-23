
namespace SistemaHospitalar.UI
{
    partial class FormComprovantePagamento
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
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.lblCpfPaciente = new System.Windows.Forms.Label();
            this.lblValorConsulta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDataConsulta = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblEspecialidadeDoutor = new System.Windows.Forms.Label();
            this.lblNomeDoutor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(135, 502);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 57);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comprovante de pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consultas";
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.Location = new System.Drawing.Point(97, 20);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(51, 20);
            this.lblNomePaciente.TabIndex = 3;
            this.lblNomePaciente.Text = "label3";
            // 
            // lblCpfPaciente
            // 
            this.lblCpfPaciente.AutoSize = true;
            this.lblCpfPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfPaciente.Location = new System.Drawing.Point(87, 43);
            this.lblCpfPaciente.Name = "lblCpfPaciente";
            this.lblCpfPaciente.Size = new System.Drawing.Size(51, 20);
            this.lblCpfPaciente.TabIndex = 4;
            this.lblCpfPaciente.Text = "label4";
            // 
            // lblValorConsulta
            // 
            this.lblValorConsulta.AutoSize = true;
            this.lblValorConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorConsulta.Location = new System.Drawing.Point(6, 34);
            this.lblValorConsulta.Name = "lblValorConsulta";
            this.lblValorConsulta.Size = new System.Drawing.Size(198, 31);
            this.lblValorConsulta.TabIndex = 5;
            this.lblValorConsulta.Text = "ValorConsulta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValorConsulta);
            this.groupBox1.Location = new System.Drawing.Point(45, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 84);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valor da Consulta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCpfPaciente);
            this.groupBox2.Controls.Add(this.lblNomePaciente);
            this.groupBox2.Location = new System.Drawing.Point(45, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 76);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paciente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDataConsulta);
            this.groupBox3.Location = new System.Drawing.Point(45, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 64);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data da Consulta";
            // 
            // lblDataConsulta
            // 
            this.lblDataConsulta.AutoSize = true;
            this.lblDataConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataConsulta.Location = new System.Drawing.Point(67, 31);
            this.lblDataConsulta.Name = "lblDataConsulta";
            this.lblDataConsulta.Size = new System.Drawing.Size(51, 20);
            this.lblDataConsulta.TabIndex = 3;
            this.lblDataConsulta.Text = "label3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblEspecialidadeDoutor);
            this.groupBox4.Controls.Add(this.lblNomeDoutor);
            this.groupBox4.Location = new System.Drawing.Point(45, 324);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 70);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Doutor(a)";
            // 
            // lblEspecialidadeDoutor
            // 
            this.lblEspecialidadeDoutor.AutoSize = true;
            this.lblEspecialidadeDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidadeDoutor.Location = new System.Drawing.Point(159, 35);
            this.lblEspecialidadeDoutor.Name = "lblEspecialidadeDoutor";
            this.lblEspecialidadeDoutor.Size = new System.Drawing.Size(51, 20);
            this.lblEspecialidadeDoutor.TabIndex = 4;
            this.lblEspecialidadeDoutor.Text = "label4";
            // 
            // lblNomeDoutor
            // 
            this.lblNomeDoutor.AutoSize = true;
            this.lblNomeDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDoutor.Location = new System.Drawing.Point(9, 35);
            this.lblNomeDoutor.Name = "lblNomeDoutor";
            this.lblNomeDoutor.Size = new System.Drawing.Size(51, 20);
            this.lblNomeDoutor.TabIndex = 3;
            this.lblNomeDoutor.Text = "label3";
            // 
            // FormComprovantePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 571);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormComprovantePagamento";
            this.Text = "FormComprovantePagamento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.Label lblCpfPaciente;
        private System.Windows.Forms.Label lblValorConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDataConsulta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblEspecialidadeDoutor;
        private System.Windows.Forms.Label lblNomeDoutor;
    }
}