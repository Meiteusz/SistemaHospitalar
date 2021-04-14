
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
            this.cbVisitantes = new System.Windows.Forms.ComboBox();
            this.cbPacientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataVisita = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgendarVisita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbVisitantes
            // 
            this.cbVisitantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVisitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVisitantes.FormattingEnabled = true;
            this.cbVisitantes.Location = new System.Drawing.Point(27, 59);
            this.cbVisitantes.Name = "cbVisitantes";
            this.cbVisitantes.Size = new System.Drawing.Size(280, 28);
            this.cbVisitantes.TabIndex = 16;
            // 
            // cbPacientes
            // 
            this.cbPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPacientes.FormattingEnabled = true;
            this.cbPacientes.Location = new System.Drawing.Point(331, 59);
            this.cbPacientes.Name = "cbPacientes";
            this.cbPacientes.Size = new System.Drawing.Size(280, 28);
            this.cbPacientes.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Visitante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Paciente internado";
            // 
            // dtpDataVisita
            // 
            this.dtpDataVisita.CustomFormat = "dd/MM/yyyy HH:mm tt";
            this.dtpDataVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataVisita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataVisita.Location = new System.Drawing.Point(27, 133);
            this.dtpDataVisita.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpDataVisita.MinDate = new System.DateTime(2021, 3, 18, 16, 54, 53, 0);
            this.dtpDataVisita.Name = "dtpDataVisita";
            this.dtpDataVisita.Size = new System.Drawing.Size(285, 27);
            this.dtpDataVisita.TabIndex = 20;
            this.dtpDataVisita.Value = new System.DateTime(2021, 3, 18, 17, 41, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Data da visita";
            // 
            // btnAgendarVisita
            // 
            this.btnAgendarVisita.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarVisita.Location = new System.Drawing.Point(27, 180);
            this.btnAgendarVisita.Name = "btnAgendarVisita";
            this.btnAgendarVisita.Size = new System.Drawing.Size(178, 35);
            this.btnAgendarVisita.TabIndex = 22;
            this.btnAgendarVisita.Text = "Agendar visita";
            this.btnAgendarVisita.UseVisualStyleBackColor = true;
            this.btnAgendarVisita.Click += new System.EventHandler(this.btnAgendarVisita_Click);
            // 
            // FormVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 243);
            this.Controls.Add(this.btnAgendarVisita);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataVisita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPacientes);
            this.Controls.Add(this.cbVisitantes);
            this.Name = "FormVisitas";
            this.Text = "FormVisitas";
            this.Load += new System.EventHandler(this.FormVisitas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVisitantes;
        private System.Windows.Forms.ComboBox cbPacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataVisita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgendarVisita;
    }
}