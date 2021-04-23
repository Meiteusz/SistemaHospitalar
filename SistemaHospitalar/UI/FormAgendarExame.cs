﻿using SistemaHospitalar.BLL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Utilities;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormAgendarExame : Form
    {
        public FormAgendarExame()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            lblNomePaciente.Text = FuncionarioLogado.PacienteSelecionado.Nome;
            lblCpfPaciente.Text = FuncionarioLogado.PacienteSelecionado.Cpf;
            lblNomeDoutor.Text = FuncionarioLogado.DoutorTemp.Nome;
            lblEspecialidadeDoutor.Text = FuncionarioLogado.DoutorTemp.Especialidade.ToString();
            dtpDataExame.Value = DateTime.Today;
        }

        ExamesBLL examesBLL = new ExamesBLL();

        private void btnAgendarExame_Click(object sender, System.EventArgs e)
        {
            Exame exame = new Exame(FuncionarioLogado.ConsultaTemp.Id, dtpDataExame.Value, FuncionarioLogado.DoutorTemp.ValorExame, txtTipoExame.Text);

            if (examesBLL.isDataExameValido(exame))
            {
                MessageBox.Show(examesBLL.AgendarExame(exame));
            }
            else
            {
                MessageBox.Show("Paciente/Doutor selecionado já está cadastrado em uma consulta/exame neste Horário.\nVerifique também se a data/horário é válida!", "Agendamento de exame inválido");
            }
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormConsultas formConsultas = new FormConsultas();
            Base.AbrirFormDesejado(this, formConsultas);
        }
    }
}
