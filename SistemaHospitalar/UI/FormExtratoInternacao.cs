using SistemaHospitalar.BLL;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormExtratoInternacao : Form
    {
        public FormExtratoInternacao()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            FormInternacoesDoutor formInternacoesDoutor = new FormInternacoesDoutor();
            Base.AbrirFormDesejado(this, formInternacoesDoutor);
        }

        public void PreencherValoresInternacao(string NomePaciente, string CpfPaciente, string NomeConvenio, string DescontoConvenio, string DataEntrada, string DataSaida,
            string NumeroQuarto, string NomeDoutor, string EspecialidadeDoutor, string ValorDiario, string DiasDeInternacao, string ValorTotal, string ValorDesconto, string ValorFinal)
        {
            lblNomePaciente.Text = NomePaciente;
            lblCpfPaciente.Text = CpfPaciente;
            lblNomeConvenio.Text = NomeConvenio;
            lblDesconto.Text = DescontoConvenio + "%";
            lblDataEntrada.Text = DataEntrada;
            lblDataSaida.Text = DataSaida;
            lblNumeroQuarto.Text = NumeroQuarto;
            lblNomeDoutor.Text = NomeDoutor;
            lblEspecialidadeDoutor.Text = EspecialidadeDoutor;
            lblValorDiaria.Text = ValorDiario;
            lblDiasInternacao.Text = DiasDeInternacao;
            lblValorTotal.Text = ValorTotal;
            lblValorDesconto.Text = ValorDesconto;
            lblValorFinal.Text = ValorFinal;
            lblValorFinalInternacao.Text = ValorFinal;
        }
    }
}
