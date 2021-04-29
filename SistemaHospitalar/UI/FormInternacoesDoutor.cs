using SistemaHospitalar.BLL;
using SistemaHospitalar.Utilities;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormInternacoesDoutor : Form
    {
        public FormInternacoesDoutor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dgvInternacoesDoutor.DataSource = internacaoBLL.TodasInternacoesDoutor(FuncionarioLogado.DoutorLogado.Id);
            btnVerificarInternacao.Enabled = false;
            admBLL.PegarValorDiarioInternacao();
            rbNomePaciente.Checked = true;
        }

        AdmBLL admBLL = new AdmBLL();
        InternacaoBLL internacaoBLL = new InternacaoBLL();
        PacienteBLL pacienteBLL = new PacienteBLL();
        ConveniosBLL ConveniosBLL = new ConveniosBLL();

        private void btnVerificarInternacao_Click(object sender, EventArgs e)
        {
            FormVerificarInternacao formVerificarInternacao = new FormVerificarInternacao();
            Base.AbrirFormDesejado(this, formVerificarInternacao);
        }

        private void dgvInternacoesDoutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnVerificarInternacao.Enabled = true;
            int IdInternacao = (int)dgvInternacoesDoutor.CurrentRow.Cells[0].Value;

            FuncionarioLogado.SetInternacaoTemp(IdInternacao);
            pacienteBLL.PegarDadosPaciente(FuncionarioLogado.InternacaoTemp.PacienteId, string.Empty);
            ConveniosBLL.PegarDadosConvenio(FuncionarioLogado.PacienteSelecionado.Convenio);
        }

        private void FormInternacoesDoutor_Load(object sender, EventArgs e)
        {
            txtNomePacientes.AutoCompleteCustomSource = pacienteBLL.MostrarNomesPacientes();
            txtNomePacientes.AutoCompleteMode = AutoCompleteMode.Append;
            txtNomePacientes.AutoCompleteSource = AutoCompleteSource.CustomSource;

            dgvInternacoesDoutor.Columns["ID"].Width = 50;
            dgvInternacoesDoutor.Columns["Paciente_Nome"].Width = 202;
            dgvInternacoesDoutor.Columns["Tipo_Internacao"].Width = 110;
            dgvInternacoesDoutor.Columns["Numero_Quarto"].Width = 110;
            dgvInternacoesDoutor.Columns["Ultima_Atualizacao"].Width = 130;
        }

        private void txtNomePacientes_TextChanged(object sender, EventArgs e)
        {
            if (txtNomePacientes.Text.Equals(string.Empty))
            {
                dgvInternacoesDoutor.DataSource = internacaoBLL.TodasInternacoesDoutor(FuncionarioLogado.DoutorLogado.Id);
            }
            else
            {
                dgvInternacoesDoutor.DataSource = internacaoBLL.PesquisarInternacaoDoutor(FuncionarioLogado.DoutorLogado.Id, txtNomePacientes.Text, 0);
            }
        }

        private void txtNumeroQuarto_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroQuarto.Value.Equals(0))
            {
                dgvInternacoesDoutor.DataSource = internacaoBLL.TodasInternacoesDoutor(FuncionarioLogado.DoutorLogado.Id);
            }
            else
            {
                dgvInternacoesDoutor.DataSource = internacaoBLL.PesquisarInternacaoDoutor(FuncionarioLogado.DoutorLogado.Id, string.Empty, Convert.ToInt32(txtNumeroQuarto.Value));
            }
        }

        private void rbNomePaciente_CheckedChanged(object sender, EventArgs e)
        {
            txtNumeroQuarto.Visible = false;
            txtNomePacientes.Visible = true;
            dgvInternacoesDoutor.DataSource = internacaoBLL.TodasInternacoesDoutor(FuncionarioLogado.DoutorLogado.Id);
        }

        private void rbNumeroQuarto_CheckedChanged(object sender, EventArgs e)
        {
            txtNumeroQuarto.Visible = true;
            txtNomePacientes.Visible = false;
            dgvInternacoesDoutor.DataSource = internacaoBLL.PesquisarInternacaoDoutor(FuncionarioLogado.DoutorLogado.Id, string.Empty, Convert.ToInt32(txtNumeroQuarto.Value));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormEntradaDoutores formEntradaDoutores = new FormEntradaDoutores();
            Base.AbrirFormDesejado(this, formEntradaDoutores);
        }
    }
}
