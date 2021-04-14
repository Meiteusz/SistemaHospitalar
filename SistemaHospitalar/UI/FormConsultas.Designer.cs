
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
            System.Windows.Forms.Button btnReagendarConsulta;
            this.btnAgendarConsulta = new System.Windows.Forms.Button();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnDeletarConsulta = new System.Windows.Forms.Button();
            this.gpFiltrosConsultas = new System.Windows.Forms.GroupBox();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.rbDataHoje = new System.Windows.Forms.RadioButton();
            btnReagendarConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.gpFiltrosConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReagendarConsulta
            // 
            btnReagendarConsulta.BackColor = System.Drawing.Color.Aquamarine;
            btnReagendarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReagendarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnReagendarConsulta.Location = new System.Drawing.Point(503, 487);
            btnReagendarConsulta.Name = "btnReagendarConsulta";
            btnReagendarConsulta.Size = new System.Drawing.Size(161, 57);
            btnReagendarConsulta.TabIndex = 4;
            btnReagendarConsulta.Text = "Reagendar Consulta";
            btnReagendarConsulta.UseVisualStyleBackColor = false;
            btnReagendarConsulta.Click += new System.EventHandler(this.btnReagendarConsulta_Click);
            // 
            // btnAgendarConsulta
            // 
            this.btnAgendarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarConsulta.Location = new System.Drawing.Point(305, 487);
            this.btnAgendarConsulta.Name = "btnAgendarConsulta";
            this.btnAgendarConsulta.Size = new System.Drawing.Size(161, 57);
            this.btnAgendarConsulta.TabIndex = 0;
            this.btnAgendarConsulta.Text = "Agendar Consulta";
            this.btnAgendarConsulta.UseVisualStyleBackColor = true;
            this.btnAgendarConsulta.Click += new System.EventHandler(this.btnAgendarConsulta_Click);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(110, 104);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.Size = new System.Drawing.Size(743, 338);
            this.dgvConsultas.TabIndex = 1;
            this.dgvConsultas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultas_CellClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(110, 487);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(161, 57);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnDeletarConsulta
            // 
            this.btnDeletarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarConsulta.Location = new System.Drawing.Point(692, 487);
            this.btnDeletarConsulta.Name = "btnDeletarConsulta";
            this.btnDeletarConsulta.Size = new System.Drawing.Size(161, 57);
            this.btnDeletarConsulta.TabIndex = 3;
            this.btnDeletarConsulta.Text = "Deletar Consulta";
            this.btnDeletarConsulta.UseVisualStyleBackColor = true;
            this.btnDeletarConsulta.Click += new System.EventHandler(this.btnDeletarConsulta_Click);
            // 
            // gpFiltrosConsultas
            // 
            this.gpFiltrosConsultas.Controls.Add(this.rbTodas);
            this.gpFiltrosConsultas.Controls.Add(this.rbDataHoje);
            this.gpFiltrosConsultas.Location = new System.Drawing.Point(113, 35);
            this.gpFiltrosConsultas.Name = "gpFiltrosConsultas";
            this.gpFiltrosConsultas.Size = new System.Drawing.Size(740, 63);
            this.gpFiltrosConsultas.TabIndex = 6;
            this.gpFiltrosConsultas.TabStop = false;
            this.gpFiltrosConsultas.Text = "Mostrar Consultas:";
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Location = new System.Drawing.Point(119, 27);
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
            this.rbDataHoje.Location = new System.Drawing.Point(241, 27);
            this.rbDataHoje.Name = "rbDataHoje";
            this.rbDataHoje.Size = new System.Drawing.Size(47, 17);
            this.rbDataHoje.TabIndex = 4;
            this.rbDataHoje.TabStop = true;
            this.rbDataHoje.Text = "Hoje";
            this.rbDataHoje.UseVisualStyleBackColor = true;
            this.rbDataHoje.CheckedChanged += new System.EventHandler(this.rbDataHoje_CheckedChanged);
            // 
            // FormConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 580);
            this.Controls.Add(this.gpFiltrosConsultas);
            this.Controls.Add(btnReagendarConsulta);
            this.Controls.Add(this.btnDeletarConsulta);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.btnAgendarConsulta);
            this.Name = "FormConsultas";
            this.Text = "FormConsultas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.gpFiltrosConsultas.ResumeLayout(false);
            this.gpFiltrosConsultas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgendarConsulta;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnDeletarConsulta;
        private System.Windows.Forms.GroupBox gpFiltrosConsultas;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.RadioButton rbDataHoje;
    }
}