using SistemaHospitalar.BLL;
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
        ConveniosBLL conveniosBLL = new ConveniosBLL();

        private void btnAgendarExame_Click(object sender, System.EventArgs e)
        {
            conveniosBLL.PegarDadosConvenio(FuncionarioLogado.PacienteSelecionado.Convenio);
            examesBLL.SetValoresExame(FuncionarioLogado.DoutorTemp.ValorExame, FuncionarioLogado.ConvenioSelecionado.Desconto);

            Exame exame = new Exame(FuncionarioLogado.ConsultaTemp.Id, dtpDataExame.Value, FuncionarioLogado.DoutorTemp.ValorExame, txtTipoExame.Text);

            if (examesBLL.isDataExameValido(exame) && !txtTipoExame.Text.Equals(string.Empty))
            {
                MessageBox.Show(examesBLL.AgendarExame(exame));
                AbrirExtratoConsulta();
            }
            else
            {
                MessageBox.Show("Paciente/Doutor selecionado já está cadastrado em uma consulta/exame neste Horário.\nVerifique também se a data/horário ou o tipo do exame são válidos!", "Agendamento de exame inválido");
            }
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormConsultas formConsultas = new FormConsultas();
            Base.AbrirFormDesejado(this, formConsultas);
        }

        private void AbrirExtratoConsulta()
        {
            FormExtratoExames formComprovantePagamento = new FormExtratoExames();
            Hide();
            formComprovantePagamento.MostrarDadosConsultas(lblNomePaciente.Text, lblCpfPaciente.Text, dtpDataExame.Value.ToString("dd/MM/yyyy HH:mm tt"),
                FuncionarioLogado.DoutorTemp.Nome, FuncionarioLogado.DoutorTemp.Especialidade.ToString(), examesBLL.ValorFinalExame.ToString(), FuncionarioLogado.ConvenioSelecionado.Nome,
                (FuncionarioLogado.ConvenioSelecionado.Desconto * 100).ToString(), examesBLL.ValorExame.ToString(), examesBLL.ValorDesconto.ToString(), examesBLL.ValorFinalExame.ToString());

            formComprovantePagamento.ShowDialog();
            Close();
        }
    }
}
