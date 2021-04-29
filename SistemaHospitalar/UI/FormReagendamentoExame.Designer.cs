
namespace SistemaHospitalar.UI
{
    partial class FormReagendamentoExame
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCpfPaciente = new System.Windows.Forms.Label();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataExame = new System.Windows.Forms.DateTimePicker();
            this.btnReagendar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(43, 196);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 73);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCpfPaciente);
            this.groupBox1.Controls.Add(this.lblNomePaciente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpDataExame);
            this.groupBox1.Location = new System.Drawing.Point(43, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 140);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // lblCpfPaciente
            // 
            this.lblCpfPaciente.AutoSize = true;
            this.lblCpfPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfPaciente.ForeColor = System.Drawing.Color.White;
            this.lblCpfPaciente.Location = new System.Drawing.Point(189, 63);
            this.lblCpfPaciente.Name = "lblCpfPaciente";
            this.lblCpfPaciente.Size = new System.Drawing.Size(100, 20);
            this.lblCpfPaciente.TabIndex = 18;
            this.lblCpfPaciente.Text = "Cpf Paciente";
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.ForeColor = System.Drawing.Color.White;
            this.lblNomePaciente.Location = new System.Drawing.Point(181, 26);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(117, 20);
            this.lblNomePaciente.TabIndex = 17;
            this.lblNomePaciente.Text = "Nome Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paciente:";
            // 
            // dtpDataExame
            // 
            this.dtpDataExame.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataExame.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataExame.Location = new System.Drawing.Point(126, 99);
            this.dtpDataExame.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpDataExame.MinDate = new System.DateTime(2021, 3, 31, 0, 0, 0, 0);
            this.dtpDataExame.Name = "dtpDataExame";
            this.dtpDataExame.Size = new System.Drawing.Size(252, 27);
            this.dtpDataExame.TabIndex = 16;
            this.dtpDataExame.Value = new System.DateTime(2021, 3, 31, 0, 0, 0, 0);
            // 
            // btnReagendar
            // 
            this.btnReagendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReagendar.ForeColor = System.Drawing.Color.Black;
            this.btnReagendar.Location = new System.Drawing.Point(386, 196);
            this.btnReagendar.Name = "btnReagendar";
            this.btnReagendar.Size = new System.Drawing.Size(147, 73);
            this.btnReagendar.TabIndex = 19;
            this.btnReagendar.Text = "Reagendar";
            this.btnReagendar.UseVisualStyleBackColor = true;
            this.btnReagendar.Click += new System.EventHandler(this.btnReagendar_Click);
            // 
            // FormReagendamentoExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(568, 283);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReagendar);
            this.Name = "FormReagendamentoExame";
            this.Text = "FormReagendamentoExame";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCpfPaciente;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataExame;
        private System.Windows.Forms.Button btnReagendar;
    }
}