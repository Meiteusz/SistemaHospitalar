
namespace SistemaHospitalar.UI
{
    partial class FormEntradaADM
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
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnConvenios = new System.Windows.Forms.Button();
            this.btnEncerrarSessão = new System.Windows.Forms.Button();
            this.btnQuartos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiariaInternacao = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAtualizarDiaria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiariaInternacao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.Location = new System.Drawing.Point(93, 176);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(176, 93);
            this.btnFuncionarios.TabIndex = 0;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnConvenios
            // 
            this.btnConvenios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvenios.Location = new System.Drawing.Point(309, 176);
            this.btnConvenios.Name = "btnConvenios";
            this.btnConvenios.Size = new System.Drawing.Size(176, 93);
            this.btnConvenios.TabIndex = 1;
            this.btnConvenios.Text = "Convenios";
            this.btnConvenios.UseVisualStyleBackColor = true;
            this.btnConvenios.Click += new System.EventHandler(this.btnConvenios_Click);
            // 
            // btnEncerrarSessão
            // 
            this.btnEncerrarSessão.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrarSessão.Location = new System.Drawing.Point(669, 379);
            this.btnEncerrarSessão.Name = "btnEncerrarSessão";
            this.btnEncerrarSessão.Size = new System.Drawing.Size(119, 59);
            this.btnEncerrarSessão.TabIndex = 2;
            this.btnEncerrarSessão.Text = "Encerrar Sessão";
            this.btnEncerrarSessão.UseVisualStyleBackColor = true;
            this.btnEncerrarSessão.Click += new System.EventHandler(this.btnEncerrarSessão_Click);
            // 
            // btnQuartos
            // 
            this.btnQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuartos.Location = new System.Drawing.Point(527, 176);
            this.btnQuartos.Name = "btnQuartos";
            this.btnQuartos.Size = new System.Drawing.Size(176, 93);
            this.btnQuartos.TabIndex = 3;
            this.btnQuartos.Text = "Quartos";
            this.btnQuartos.UseVisualStyleBackColor = true;
            this.btnQuartos.Click += new System.EventHandler(this.btnQuartos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Diária Internação";
            // 
            // txtDiariaInternacao
            // 
            this.txtDiariaInternacao.DecimalPlaces = 2;
            this.txtDiariaInternacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiariaInternacao.Location = new System.Drawing.Point(328, 28);
            this.txtDiariaInternacao.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtDiariaInternacao.Name = "txtDiariaInternacao";
            this.txtDiariaInternacao.Size = new System.Drawing.Size(129, 27);
            this.txtDiariaInternacao.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAtualizarDiaria);
            this.groupBox1.Controls.Add(this.txtDiariaInternacao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 75);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valor Internação";
            // 
            // btnAtualizarDiaria
            // 
            this.btnAtualizarDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarDiaria.Location = new System.Drawing.Point(488, 22);
            this.btnAtualizarDiaria.Name = "btnAtualizarDiaria";
            this.btnAtualizarDiaria.Size = new System.Drawing.Size(125, 37);
            this.btnAtualizarDiaria.TabIndex = 7;
            this.btnAtualizarDiaria.Text = "Atualizar Diaria";
            this.btnAtualizarDiaria.UseVisualStyleBackColor = true;
            this.btnAtualizarDiaria.Click += new System.EventHandler(this.btnAtualizarDiaria_Click);
            // 
            // FormEntradaADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuartos);
            this.Controls.Add(this.btnEncerrarSessão);
            this.Controls.Add(this.btnConvenios);
            this.Controls.Add(this.btnFuncionarios);
            this.Name = "FormEntradaADM";
            this.Text = "FormEntradaADM";
            ((System.ComponentModel.ISupportInitialize)(this.txtDiariaInternacao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnConvenios;
        private System.Windows.Forms.Button btnEncerrarSessão;
        private System.Windows.Forms.Button btnQuartos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtDiariaInternacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAtualizarDiaria;
    }
}