using SistemaHospitalar.BLL;
using SistemaHospitalar.DAL;
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
            lblNome.Text = "Bem vindo " + FuncionarioLogado.RecepcionistaLogada.Nome;
        }

        private void btnConfiguracoesRecepcionista_Click(object sender, System.EventArgs e)
        {
            FormConfiguracoesRecepcionista formConfiguracoesRecepcionista = new FormConfiguracoesRecepcionista();
            Base.AbrirFormDesejado(this, formConfiguracoesRecepcionista);
        }

        private void btnPacientes_Click(object sender, System.EventArgs e)
        {
            FormPacientes formPacientes = new FormPacientes();
            Base.AbrirFormDesejado(this, formPacientes);
        }

        private void btnConsultas_Click(object sender, System.EventArgs e)
        {
            FormConsultas formConsultas = new FormConsultas();
            Base.AbrirFormDesejado(this, formConsultas);
        }

        private void btnConvenios_Click(object sender, System.EventArgs e)
        {
            FormConvenios formConvenios = new FormConvenios();
            Base.AbrirFormDesejado(this, formConvenios);
        }

        private void btnEncerrarSessão_Click(object sender, System.EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            Base.AbrirFormDesejado(this, formLogin);
        }

        private void btnVisitas_Click(object sender, System.EventArgs e)
        {
            FormVisitas formVisitas = new FormVisitas();
            Base.AbrirFormDesejado(this, formVisitas);
        }

        private void btnInternacao_Click(object sender, System.EventArgs e)
        {
            FormInternacao formInternacao = new FormInternacao();
            Base.AbrirFormDesejado(this, formInternacao);
        }
    }
}
