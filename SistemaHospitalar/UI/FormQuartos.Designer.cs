
namespace SistemaHospitalar.UI
{
    partial class FormQuartos
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
            this.dgvQuartos = new System.Windows.Forms.DataGridView();
            this.btnCadastrarQuarto = new System.Windows.Forms.Button();
            this.txtNumeroQuarto = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbQuartosDisponiveis = new System.Windows.Forms.RadioButton();
            this.rbTodosQuartos = new System.Windows.Forms.RadioButton();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroQuarto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQuartos
            // 
            this.dgvQuartos.AllowUserToAddRows = false;
            this.dgvQuartos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuartos.EnableHeadersVisualStyles = false;
            this.dgvQuartos.GridColor = System.Drawing.Color.Black;
            this.dgvQuartos.Location = new System.Drawing.Point(36, 43);
            this.dgvQuartos.Name = "dgvQuartos";
            this.dgvQuartos.ReadOnly = true;
            this.dgvQuartos.Size = new System.Drawing.Size(346, 351);
            this.dgvQuartos.TabIndex = 0;
            // 
            // btnCadastrarQuarto
            // 
            this.btnCadastrarQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarQuarto.Location = new System.Drawing.Point(709, 410);
            this.btnCadastrarQuarto.Name = "btnCadastrarQuarto";
            this.btnCadastrarQuarto.Size = new System.Drawing.Size(147, 73);
            this.btnCadastrarQuarto.TabIndex = 1;
            this.btnCadastrarQuarto.Text = "Cadastrar Quarto";
            this.btnCadastrarQuarto.UseVisualStyleBackColor = true;
            this.btnCadastrarQuarto.Click += new System.EventHandler(this.btnCadastrarQuarto_Click);
            // 
            // txtNumeroQuarto
            // 
            this.txtNumeroQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroQuarto.Location = new System.Drawing.Point(695, 225);
            this.txtNumeroQuarto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtNumeroQuarto.Name = "txtNumeroQuarto";
            this.txtNumeroQuarto.Size = new System.Drawing.Size(97, 30);
            this.txtNumeroQuarto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(529, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número do Quarto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(522, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cadastro de Quarto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbQuartosDisponiveis);
            this.groupBox1.Controls.Add(this.rbTodosQuartos);
            this.groupBox1.Location = new System.Drawing.Point(36, 424);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // rbQuartosDisponiveis
            // 
            this.rbQuartosDisponiveis.AutoSize = true;
            this.rbQuartosDisponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbQuartosDisponiveis.ForeColor = System.Drawing.Color.White;
            this.rbQuartosDisponiveis.Location = new System.Drawing.Point(175, 22);
            this.rbQuartosDisponiveis.Name = "rbQuartosDisponiveis";
            this.rbQuartosDisponiveis.Size = new System.Drawing.Size(165, 24);
            this.rbQuartosDisponiveis.TabIndex = 1;
            this.rbQuartosDisponiveis.TabStop = true;
            this.rbQuartosDisponiveis.Text = "Quartos disponíveis";
            this.rbQuartosDisponiveis.UseVisualStyleBackColor = true;
            this.rbQuartosDisponiveis.CheckedChanged += new System.EventHandler(this.rbQuartosDisponiveis_CheckedChanged);
            // 
            // rbTodosQuartos
            // 
            this.rbTodosQuartos.AutoSize = true;
            this.rbTodosQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodosQuartos.ForeColor = System.Drawing.Color.White;
            this.rbTodosQuartos.Location = new System.Drawing.Point(6, 22);
            this.rbTodosQuartos.Name = "rbTodosQuartos";
            this.rbTodosQuartos.Size = new System.Drawing.Size(129, 24);
            this.rbTodosQuartos.TabIndex = 0;
            this.rbTodosQuartos.TabStop = true;
            this.rbTodosQuartos.Text = "Todos quartos";
            this.rbTodosQuartos.UseVisualStyleBackColor = true;
            this.rbTodosQuartos.CheckedChanged += new System.EventHandler(this.rbTodosQuartos_CheckedChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(467, 410);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 73);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(892, 517);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroQuarto);
            this.Controls.Add(this.btnCadastrarQuarto);
            this.Controls.Add(this.dgvQuartos);
            this.Name = "FormQuartos";
            this.Text = "FormQuartos";
            this.Load += new System.EventHandler(this.FormQuartos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroQuarto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuartos;
        private System.Windows.Forms.Button btnCadastrarQuarto;
        private System.Windows.Forms.NumericUpDown txtNumeroQuarto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbQuartosDisponiveis;
        private System.Windows.Forms.RadioButton rbTodosQuartos;
        private System.Windows.Forms.Button btnVoltar;
    }
}