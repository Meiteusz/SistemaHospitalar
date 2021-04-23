
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgendarConsulta = new System.Windows.Forms.Button();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpFiltrosConsultas = new System.Windows.Forms.GroupBox();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.rbDataHoje = new System.Windows.Forms.RadioButton();
            this.btnAgendarExame = new System.Windows.Forms.Button();
            this.btnReagendarConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.gpFiltrosConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgendarConsulta
            // 
            this.btnAgendarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarConsulta.Location = new System.Drawing.Point(337, 550);
            this.btnAgendarConsulta.Name = "btnAgendarConsulta";
            this.btnAgendarConsulta.Size = new System.Drawing.Size(147, 73);
            this.btnAgendarConsulta.TabIndex = 0;
            this.btnAgendarConsulta.Text = "Agendar Consulta";
            this.btnAgendarConsulta.UseVisualStyleBackColor = true;
            this.btnAgendarConsulta.Click += new System.EventHandler(this.btnAgendarConsulta_Click);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.AllowUserToResizeColumns = false;
            this.dgvConsultas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.EnableHeadersVisualStyles = false;
            this.dgvConsultas.GridColor = System.Drawing.Color.Black;
            this.dgvConsultas.Location = new System.Drawing.Point(93, 114);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.Size = new System.Drawing.Size(838, 395);
            this.dgvConsultas.TabIndex = 1;
            this.dgvConsultas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultas_CellClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(93, 550);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 73);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gpFiltrosConsultas
            // 
            this.gpFiltrosConsultas.Controls.Add(this.rbTodas);
            this.gpFiltrosConsultas.Controls.Add(this.rbDataHoje);
            this.gpFiltrosConsultas.Location = new System.Drawing.Point(96, 45);
            this.gpFiltrosConsultas.Name = "gpFiltrosConsultas";
            this.gpFiltrosConsultas.Size = new System.Drawing.Size(835, 63);
            this.gpFiltrosConsultas.TabIndex = 6;
            this.gpFiltrosConsultas.TabStop = false;
            this.gpFiltrosConsultas.Text = "Mostrar Consultas:";
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodas.Location = new System.Drawing.Point(241, 24);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(71, 24);
            this.rbTodas.TabIndex = 3;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas";
            this.rbTodas.UseVisualStyleBackColor = true;
            this.rbTodas.CheckedChanged += new System.EventHandler(this.rbTodas_CheckedChanged);
            // 
            // rbDataHoje
            // 
            this.rbDataHoje.AutoSize = true;
            this.rbDataHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDataHoje.Location = new System.Drawing.Point(465, 24);
            this.rbDataHoje.Name = "rbDataHoje";
            this.rbDataHoje.Size = new System.Drawing.Size(60, 24);
            this.rbDataHoje.TabIndex = 4;
            this.rbDataHoje.TabStop = true;
            this.rbDataHoje.Text = "Hoje";
            this.rbDataHoje.UseVisualStyleBackColor = true;
            this.rbDataHoje.CheckedChanged += new System.EventHandler(this.rbDataHoje_CheckedChanged);
            // 
            // btnAgendarExame
            // 
            this.btnAgendarExame.BackColor = System.Drawing.Color.Transparent;
            this.btnAgendarExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarExame.Location = new System.Drawing.Point(782, 550);
            this.btnAgendarExame.Name = "btnAgendarExame";
            this.btnAgendarExame.Size = new System.Drawing.Size(147, 73);
            this.btnAgendarExame.TabIndex = 7;
            this.btnAgendarExame.Text = "Agendar Exame";
            this.btnAgendarExame.UseVisualStyleBackColor = false;
            this.btnAgendarExame.Click += new System.EventHandler(this.btnAgendarExame_Click);
            // 
            // btnReagendarConsulta
            // 
            this.btnReagendarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReagendarConsulta.Location = new System.Drawing.Point(561, 550);
            this.btnReagendarConsulta.Name = "btnReagendarConsulta";
            this.btnReagendarConsulta.Size = new System.Drawing.Size(147, 73);
            this.btnReagendarConsulta.TabIndex = 8;
            this.btnReagendarConsulta.Text = "Reagendar Consulta";
            this.btnReagendarConsulta.UseVisualStyleBackColor = true;
            this.btnReagendarConsulta.Click += new System.EventHandler(this.btnReagendarConsulta_Click);
            // 
            // FormConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 653);
            this.Controls.Add(this.btnReagendarConsulta);
            this.Controls.Add(this.btnAgendarExame);
            this.Controls.Add(this.gpFiltrosConsultas);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.btnAgendarConsulta);
            this.Name = "FormConsultas";
            this.Text = "FormConsultas";
            this.Load += new System.EventHandler(this.FormConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.gpFiltrosConsultas.ResumeLayout(false);
            this.gpFiltrosConsultas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgendarConsulta;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox gpFiltrosConsultas;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.RadioButton rbDataHoje;
        private System.Windows.Forms.Button btnAgendarExame;
        private System.Windows.Forms.Button btnReagendarConsulta;
    }
}