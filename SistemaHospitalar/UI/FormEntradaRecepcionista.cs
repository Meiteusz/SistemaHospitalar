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

        private void btnConsultas_Click(object sender, System.EventArgs e)
        {
            FormConsultas formConsultas = new FormConsultas();
            Base.AbrirFormDesejado(this, formConsultas);
        }

        private void btnInternacao_Click(object sender, System.EventArgs e)
        {
            FormInternacao formInternacao = new FormInternacao();
            Base.AbrirFormDesejado(this, formInternacao);
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

        private void btnVisitantes_Click(object sender, System.EventArgs e)
        {
            FormVisitantes formVisitantes = new FormVisitantes();
            Base.AbrirFormDesejado(this, formVisitantes);
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
