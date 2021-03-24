﻿using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormComprovantePagamento : Form
    {
        public FormComprovantePagamento()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void MostrarDadosConsultas(string pacienteNome, string pacienteCPF, string dataConsulta, string NomeDoutor, string especialidadeDoutor, string valorFinalConsulta,
            string TemConvenio, string NomeConvenio, string ValorConsulta, string ValorDesconto, string ValorFinal)
        {
            lblNomePaciente.Text = pacienteNome;
            lblCpfPaciente.Text = pacienteCPF;
            lblDataConsulta.Text = dataConsulta;
            lblNomeDoutor.Text = NomeDoutor;
            lblEspecialidadeDoutor.Text = especialidadeDoutor;
            lblValorFinalConsulta.Text = "R$ " + valorFinalConsulta + ",00";
            lblSimNao.Text = TemConvenio;
            lblNomeConvenio.Text = NomeConvenio;
            lblValorConsulta.Text = ValorConsulta;
            lblValorDesconto.Text = ValorDesconto;
            lblValorFinal.Text = ValorFinal;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FormConsultas formConsultas = new FormConsultas();
            Hide();
            formConsultas.ShowDialog();
            Close();
        }
    }
}
