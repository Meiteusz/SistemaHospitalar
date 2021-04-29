using SistemaHospitalar.BLL;
using SistemaHospitalar.Utilities;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormEntradaDoutores : Form
    {
        public FormEntradaDoutores()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            lblNomeDoutor.Text = FuncionarioLogado.DoutorLogado.Nome;
            lblEspecialidadeDoutor.Text = FuncionarioLogado.DoutorLogado.Especialidade.ToString();
        }

        private void btnConsultas_Click(object sender, System.EventArgs e)
        {
            FormConsultasDoutor formViewConsultas = new FormConsultasDoutor();
            Base.AbrirFormDesejado(this, formViewConsultas);
        }

        private void btnInternacoesDoutor_Click(object sender, System.EventArgs e)
        {
            FormInternacoesDoutor formInterncoesDoutor = new FormInternacoesDoutor();
            Base.AbrirFormDesejado(this, formInterncoesDoutor);
        }

        private void btnExames_Click(object sender, System.EventArgs e)
        {
            FormExamesDoutor formExamesDoutor = new FormExamesDoutor();
            Base.AbrirFormDesejado(this, formExamesDoutor);
        }

        private void btnConfiguracoes_Click(object sender, System.EventArgs e)
        {
            FormConfiguracoesDoutores formConfiguracoesDoutores = new FormConfiguracoesDoutores();
            Base.AbrirFormDesejado(this, formConfiguracoesDoutores);
        }

        private void btnValores_Click(object sender, System.EventArgs e)
        {
            FormValores formValores = new FormValores();
            Base.AbrirFormDesejado(this, formValores);
        }

        private void brnEncerrarSessão_Click(object sender, System.EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            Base.AbrirFormDesejado(this, formLogin);
        }
    }
}
