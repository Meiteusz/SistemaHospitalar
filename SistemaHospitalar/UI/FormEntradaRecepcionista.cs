using SistemaHospitalar.BLL;
using SistemaHospitalar.UI;
using SistemaHospitalar.Utilities;
using SistemaHospitalar.Views;
using System.Windows.Forms;

namespace SistemaHospitalar
{
    public partial class FormEntradaRecepcionista : Form
    {
        public FormEntradaRecepcionista()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            lblNomeRecepcionista.Text = FuncionarioLogado.RecepcionistaLogada.Nome;
        }

        private void btnConsultas_Click(object sender, System.EventArgs e)
        {
            FormConsultas formConsultas = new FormConsultas();
            Base.AbrirFormDesejado(this, formConsultas);
        }

        private void btnInternacao_Click(object sender, System.EventArgs e)
        {
            FormTodasInternacoes formTodasInternacoes = new FormTodasInternacoes();
            Base.AbrirFormDesejado(this, formTodasInternacoes);
        }

        private void btnPacientes_Click(object sender, System.EventArgs e)
        {
            FormPacientes formPacientes = new FormPacientes();
            Base.AbrirFormDesejado(this, formPacientes);
        }

        private void btnVisitas_Click(object sender, System.EventArgs e)
        {
            FormVisitas formVisitas = new FormVisitas();
            Base.AbrirFormDesejado(this, formVisitas);
        }

        private void btnExames_Click(object sender, System.EventArgs e)
        {
            FormExames formExames = new FormExames();
            Base.AbrirFormDesejado(this, formExames);
        }

        private void btnAgenda_Click(object sender, System.EventArgs e)
        {
            FormAgenda formAgenda = new FormAgenda();
            Base.AbrirFormDesejado(this, formAgenda);
        }

        private void btnConfiguracoesRecepcionista_Click(object sender, System.EventArgs e)
        {
            FormConfiguracoesRecepcionista formConfiguracoesRecepcionista = new FormConfiguracoesRecepcionista();
            Base.AbrirFormDesejado(this, formConfiguracoesRecepcionista);
        }

        private void btnEncerrarSessão_Click(object sender, System.EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            Base.AbrirFormDesejado(this, formLogin);
        }
    }
}
