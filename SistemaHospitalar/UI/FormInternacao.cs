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
            dtpDataEntradaInternacao.Value = DateTime.Now;
            cmbTipoInternacao.DataSource = Enum.GetValues(typeof(TipoInternacao));
            cmbEspecialidades.DataSource = Enum.GetValues(typeof(Especialidades));
            cmbQuartos.DataSource = quartosBLL.ListarQuartosDisponiveis();
            btnCadastrarInternação.Enabled = false;
        }

        InternacaoBLL internacaoBLL = new InternacaoBLL();
        PacienteBLL pacienteBLL = new PacienteBLL();
        DoutoresBLL doutoresBLL = new DoutoresBLL();
        QuartosBLL quartosBLL = new QuartosBLL();

        private void btnCadastrarInternação_Click(object sender, System.EventArgs e)
        {
            Internacao internacao = new Internacao(FuncionarioLogado.PacienteSelecionado.Id, FuncionarioLogado.DoutorTemp.Id, rtbDescricao.Text,
                (TipoInternacao)cmbTipoInternacao.SelectedIndex, Convert.ToInt32(cmbQuartos.Text), dtpDataEntradaInternacao.Value, DateTime.Now);

            MessageBox.Show(internacaoBLL.CadastrarInternacao(internacao));
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
            cmbPacientes.DataSource = pacienteBLL.MostrarCpfPacientesNaoInternados();
            cmbPacientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbPacientes.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void dgvDoutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idDoutor = (int)dgvDoutores.CurrentRow.Cells[0].Value;
            FuncionarioLogado.SetDoutorTemp(idDoutor);
            txtNomeDoutor.Text = FuncionarioLogado.DoutorTemp.Nome;
            btnCadastrarInternação.Enabled = true;
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
