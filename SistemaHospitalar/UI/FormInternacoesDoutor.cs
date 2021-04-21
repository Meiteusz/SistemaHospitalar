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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormEntradaDoutores formEntradaDoutores = new FormEntradaDoutores();
            Base.AbrirFormDesejado(this, formEntradaDoutores);
        }
    }
}
