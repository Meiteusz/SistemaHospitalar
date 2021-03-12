
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
            this.txtNomeConvenio = new System.Windows.Forms.TextBox();
            this.btnCadastrarConvenio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvConvenios = new System.Windows.Forms.DataGridView();
            this.txtDescontoConvenio = new System.Windows.Forms.TextBox();
            this.btnAtualizarConvenio = new System.Windows.Forms.Button();
            this.btnDeletarConvenio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvenios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeConvenio
            // 
            this.txtNomeConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeConvenio.Location = new System.Drawing.Point(473, 107);
            this.txtNomeConvenio.Name = "txtNomeConvenio";
            this.txtNomeConvenio.Size = new System.Drawing.Size(278, 30);
            this.txtNomeConvenio.TabIndex = 0;
            // 
            // btnCadastrarConvenio
            // 
            this.btnCadastrarConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarConvenio.Location = new System.Drawing.Point(530, 271);
            this.btnCadastrarConvenio.Name = "btnCadastrarConvenio";
            this.btnCadastrarConvenio.Size = new System.Drawing.Size(161, 61);
            this.btnCadastrarConvenio.TabIndex = 1;
            this.btnCadastrarConvenio.Text = "Cadastrar Convênio";
            this.btnCadastrarConvenio.UseVisualStyleBackColor = true;
            this.btnCadastrarConvenio.Click += new System.EventHandler(this.btnCadastrarConvenio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desconto";
            // 
            // dgvConvenios
            // 
            this.dgvConvenios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConvenios.Location = new System.Drawing.Point(57, 75);
            this.dgvConvenios.Name = "dgvConvenios";
            this.dgvConvenios.Size = new System.Drawing.Size(347, 284);
            this.dgvConvenios.TabIndex = 6;
            // 
            // txtDescontoConvenio
            // 
            this.txtDescontoConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoConvenio.Location = new System.Drawing.Point(473, 212);
            this.txtDescontoConvenio.Name = "txtDescontoConvenio";
            this.txtDescontoConvenio.Size = new System.Drawing.Size(278, 30);
            this.txtDescontoConvenio.TabIndex = 7;
            // 
            // btnAtualizarConvenio
            // 
            this.btnAtualizarConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarConvenio.Location = new System.Drawing.Point(57, 388);
            this.btnAtualizarConvenio.Name = "btnAtualizarConvenio";
            this.btnAtualizarConvenio.Size = new System.Drawing.Size(130, 50);
            this.btnAtualizarConvenio.TabIndex = 8;
            this.btnAtualizarConvenio.Text = "Atualizar Convenio";
            this.btnAtualizarConvenio.UseVisualStyleBackColor = true;
            this.btnAtualizarConvenio.Click += new System.EventHandler(this.btnAtualizarConvenio_Click);
            // 
            // btnDeletarConvenio
            // 
            this.btnDeletarConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarConvenio.Location = new System.Drawing.Point(274, 388);
            this.btnDeletarConvenio.Name = "btnDeletarConvenio";
            this.btnDeletarConvenio.Size = new System.Drawing.Size(130, 50);
            this.btnDeletarConvenio.TabIndex = 9;
            this.btnDeletarConvenio.Text = "Deletar Convênio";
            this.btnDeletarConvenio.UseVisualStyleBackColor = true;
            this.btnDeletarConvenio.Click += new System.EventHandler(this.btnDeletarConvenio_Click);
            // 
            // FormConvenios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeletarConvenio);
            this.Controls.Add(this.btnAtualizarConvenio);
            this.Controls.Add(this.txtDescontoConvenio);
            this.Controls.Add(this.dgvConvenios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarConvenio);
            this.Controls.Add(this.txtNomeConvenio);
            this.Name = "FormConvenios";
            this.Text = "FormConvenios";
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
        private System.Windows.Forms.Button btnAtualizarConvenio;
        private System.Windows.Forms.Button btnDeletarConvenio;
    }
}