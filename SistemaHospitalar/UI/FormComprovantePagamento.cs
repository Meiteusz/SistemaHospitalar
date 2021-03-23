using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormComprovantePagamento : Form
    {
        public FormComprovantePagamento()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void MostrarDadosConsultas(string pacienteNome, string pacienteCPF, string dataConsulta, string NomeDoutor, string especialidadeDoutor, string valorConsulta)
        {
            lblNomePaciente.Text = pacienteNome;
            lblCpfPaciente.Text = pacienteCPF;
            lblDataConsulta.Text = dataConsulta;
            lblNomeDoutor.Text = NomeDoutor;
            lblEspecialidadeDoutor.Text = especialidadeDoutor;
            lblValorConsulta.Text = "R$ " + valorConsulta + ",00";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FormConsultas formConsultas = new FormConsultas();
            Hide();
            formConsultas.ShowDialog();
            Close();
        }
    }
}
