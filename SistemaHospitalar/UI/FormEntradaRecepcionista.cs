using SistemaHospitalar.DAL;
using SistemaHospitalar.UI;
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
            //lblNome.Text = "Bem vindo " + DalRecepionistas.Nome;
        }

        private void btnConfiguracoes_Click(object sender, System.EventArgs e)
        {
            FormConfiguracoes formConfiguracoes = new FormConfiguracoes();
            Hide();
            formConfiguracoes.ShowDialog();
            Close();
        }

        private void btnMedicos_Click(object sender, System.EventArgs e)
        {
            FormEntradaDoutores formEntradaDoutores = new FormEntradaDoutores();
            Hide();
            formEntradaDoutores.ShowDialog();
            Close();
        }

        private void btnPacientes_Click(object sender, System.EventArgs e)
        {
            FormPacientes formPacientes = new FormPacientes();
            Hide();
            formPacientes.ShowDialog();
            Close();
            FormCadastroPaciente formCadastroPaciente = new FormCadastroPaciente();
        }

        private void btnConsultas_Click(object sender, System.EventArgs e)
        {
            FormConsultas formConsultas = new FormConsultas();
            Hide();
            formConsultas.ShowDialog();
            Close();
        }

        private void btnConvenios_Click(object sender, System.EventArgs e)
        {
            FormConvenios formConvenios = new FormConvenios();
            Hide();
            formConvenios.ShowDialog();
            Close();
        }
    }
}
