﻿using SistemaHospitalar.BLL;
using SistemaHospitalar.DAL;
using SistemaHospitalar.Models;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormConfiguracoesDoutores : Form
    {
        public FormConfiguracoesDoutores()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cmbTurnoDoutor.DataSource = Enum.GetValues(typeof(Turno));
        }

        DoutoresBLL doutoresBLL = new DoutoresBLL();

        private void FormConfiguracoesDoutores_Load(object sender, System.EventArgs e)
        {
            txtNomeDoutor.Text = DalDoutores.Nome;
            txtEmailDoutor.Text = DalDoutores.Email;
            txtMaskedCelularDoutor.Text = DalDoutores.Celular;
            cmbTurnoDoutor.Text = DalDoutores.Turno;
            txtSenhaDoutor.Text = DalDoutores.Senha;
        }

        private void btnAtualizarInformacoes_Click(object sender, EventArgs e)
        {
            Doutores doutores = new Doutores(txtNomeDoutor.Text, txtEmailDoutor.Text, txtMaskedCelularDoutor.Text, (Turno)cmbTurnoDoutor.SelectedIndex, txtSenhaDoutor.Text);

            if (MessageBox.Show(doutoresBLL.MsgAtualizarInformacoes, "Alterar Informações", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(doutoresBLL.AtualizarDoutor(doutores, txtRepetirSenhaDoutor.Text));
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormEntradaDoutores formEntradaDoutores = new FormEntradaDoutores();
            Base.VoltarFormAnterior(this, formEntradaDoutores);
        }
    }
}
