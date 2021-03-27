
namespace SistemaHospitalar.UI
{
    partial class FormViewConsultas
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
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.rbDataHoje = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(46, 92);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.Size = new System.Drawing.Size(449, 246);
            this.dgvConsultas.TabIndex = 0;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(46, 56);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(259, 26);
            this.txtPesquisa.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Location = new System.Drawing.Point(103, 27);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(55, 17);
            this.rbTodas.TabIndex = 3;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas";
            this.rbTodas.UseVisualStyleBackColor = true;
            this.rbTodas.CheckedChanged += new System.EventHandler(this.rbTodas_CheckedChanged);
            // 
            // rbDataHoje
            // 
            this.rbDataHoje.AutoSize = true;
            this.rbDataHoje.Location = new System.Drawing.Point(225, 27);
            this.rbDataHoje.Name = "rbDataHoje";
            this.rbDataHoje.Size = new System.Drawing.Size(47, 17);
            this.rbDataHoje.TabIndex = 4;
            this.rbDataHoje.TabStop = true;
            this.rbDataHoje.Text = "Hoje";
            this.rbDataHoje.UseVisualStyleBackColor = true;
            this.rbDataHoje.CheckedChanged += new System.EventHandler(this.rbDataHoje_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTodas);
            this.groupBox1.Controls.Add(this.rbDataHoje);
            this.groupBox1.Location = new System.Drawing.Point(46, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 63);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar Consultas:";
            // 
            // FormViewConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dgvConsultas);
            this.Name = "FormViewConsultas";
            this.Text = "FormViewConsultas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.RadioButton rbDataHoje;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}