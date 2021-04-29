
namespace SistemaHospitalar.UI
{
    partial class FormConvenios
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
            this.txtNomeConvenio = new System.Windows.Forms.TextBox();
            this.btnCadastrarConvenio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvConvenios = new System.Windows.Forms.DataGridView();
            this.txtDescontoConvenio = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvenios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeConvenio
            // 
            this.txtNomeConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeConvenio.Location = new System.Drawing.Point(581, 159);
            this.txtNomeConvenio.Name = "txtNomeConvenio";
            this.txtNomeConvenio.Size = new System.Drawing.Size(278, 26);
            this.txtNomeConvenio.TabIndex = 0;
            // 
            // btnCadastrarConvenio
            // 
            this.btnCadastrarConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarConvenio.Location = new System.Drawing.Point(397, 418);
            this.btnCadastrarConvenio.Name = "btnCadastrarConvenio";
            this.btnCadastrarConvenio.Size = new System.Drawing.Size(147, 73);
            this.btnCadastrarConvenio.TabIndex = 1;
            this.btnCadastrarConvenio.Text = "Cadastrar Convênio";
            this.btnCadastrarConvenio.UseVisualStyleBackColor = true;
            this.btnCadastrarConvenio.Click += new System.EventHandler(this.btnCadastrarConvenio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(577, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(577, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desconto   %";
            // 
            // dgvConvenios
            // 
            this.dgvConvenios.AllowUserToAddRows = false;
            this.dgvConvenios.AllowUserToResizeColumns = false;
            this.dgvConvenios.AllowUserToResizeRows = false;
            this.dgvConvenios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConvenios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConvenios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConvenios.EnableHeadersVisualStyles = false;
            this.dgvConvenios.GridColor = System.Drawing.Color.Black;
            this.dgvConvenios.Location = new System.Drawing.Point(40, 63);
            this.dgvConvenios.Name = "dgvConvenios";
            this.dgvConvenios.ReadOnly = true;
            this.dgvConvenios.Size = new System.Drawing.Size(504, 303);
            this.dgvConvenios.TabIndex = 6;
            this.dgvConvenios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConvenios_CellClick);
            // 
            // txtDescontoConvenio
            // 
            this.txtDescontoConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoConvenio.Location = new System.Drawing.Point(581, 264);
            this.txtDescontoConvenio.Name = "txtDescontoConvenio";
            this.txtDescontoConvenio.Size = new System.Drawing.Size(278, 26);
            this.txtDescontoConvenio.TabIndex = 7;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(40, 418);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 73);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FormConvenios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(901, 530);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtDescontoConvenio);
            this.Controls.Add(this.dgvConvenios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarConvenio);
            this.Controls.Add(this.txtNomeConvenio);
            this.Name = "FormConvenios";
            this.Text = "FormConvenios";
            this.Load += new System.EventHandler(this.FormConvenios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvenios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeConvenio;
        private System.Windows.Forms.Button btnCadastrarConvenio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvConvenios;
        private System.Windows.Forms.TextBox txtDescontoConvenio;
        private System.Windows.Forms.Button btnVoltar;
    }
}