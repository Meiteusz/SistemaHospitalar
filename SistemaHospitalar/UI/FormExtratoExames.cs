using SistemaHospitalar.BLL;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormExtratoExames : Form
    {
        public FormExtratoExames()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void MostrarDadosConsultas(string pacienteNome, string pacienteCPF, string dataConsulta, string NomeDoutor, string especialidadeDoutor, string valorFinalConsulta,
            string NomeConvenio, string DescontoConvenio, string ValorConsulta, string ValorDesconto, string ValorFinal)
        {
            lblNomePaciente.Text = pacienteNome;
            lblCpfPaciente.Text = pacienteCPF;
            lblDataExame.Text = dataConsulta;
            lblNomeDoutor.Text = NomeDoutor;
            lblEspecialidadeDoutor.Text = especialidadeDoutor;
            lblValorFinalExame.Text = "R$ " + valorFinalConsulta;
            lblNomeConvenio.Text = NomeConvenio;
            lblDesconto.Text = DescontoConvenio + "%";
            lblValorExame.Text = ValorConsulta;
            lblValorDesconto.Text = ValorDesconto;
            lblValorFinal.Text = ValorFinal;
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            FormExames formExames = new FormExames();
            Base.AbrirFormDesejado(this, formExames);
        }
    }
}
