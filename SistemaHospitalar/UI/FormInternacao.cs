using SistemaHospitalar.BLL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Utilities;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormInternacao : Form
    {
        public FormInternacao()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cmbTipoInternacao.DataSource = Base.ReformularTipoInternacao();
            cmbEspecialidades.DataSource = Base.ReformularEspecialidades();
            cmbQuartos.DataSource = quartosBLL.ListarQuartosDisponiveis();
        }

        PacienteBLL pacienteBLL = new PacienteBLL();
        DoutoresBLL doutoresBLL = new DoutoresBLL();
        QuartosBLL quartosBLL = new QuartosBLL();

        private void btnCadastrarInternação_Click(object sender, System.EventArgs e)
        {

        }

        private void cmbEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(cmbEspecialidades.Text, out Especialidades TurnoConvertido);
            dgvDoutores.DataSource = doutoresBLL.MostrarDoutoresInternacao(TurnoConvertido);
        }

        private void cmbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacienteBLL.PegarDadosPaciente(0, cmbPacientes.Text);
            lblNomePaciente.Text = FuncionarioLogado.PacienteSelecionado.Nome;
        }

        private void FormInternacao_Load(object sender, EventArgs e)
        {
            cmbPacientes.DataSource = pacienteBLL.MostrarCpfPacientes();
            cmbPacientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbPacientes.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnLimpar_Click(object sender, System.EventArgs e)
        {
            Base.LimparTxtEtc(Controls);
            dtpDataEntradaInternacao.Value = DateTime.Now;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormEntradaRecepcionista formEntradaRecepcionista = new FormEntradaRecepcionista();
            Base.AbrirFormDesejado(this, formEntradaRecepcionista);
        }

    }
}
