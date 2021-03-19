
namespace SistemaHospitalar.UI
{
    partial class FormConsultas
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
            this.btnAgendarConsulta = new System.Windows.Forms.Button();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgendarConsulta
            // 
            this.btnAgendarConsulta.Location = new System.Drawing.Point(549, 103);
            this.btnAgendarConsulta.Name = "btnAgendarConsulta";
            this.btnAgendarConsulta.Size = new System.Drawing.Size(222, 67);
            this.btnAgendarConsulta.TabIndex = 0;
            this.btnAgendarConsulta.Text = "Agendar Consulta";
            this.btnAgendarConsulta.UseVisualStyleBackColor = true;
            this.btnAgendarConsulta.Click += new System.EventHandler(this.btnCadastrarConsulta_Click);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(28, 103);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.Size = new System.Drawing.Size(480, 318);
            this.dgvConsultas.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(28, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(99, 48);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.btnAgendarConsulta);
            this.Name = "FormConsultas";
            this.Text = "FormConsultas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgendarConsulta;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Button btnVoltar;
    }
}