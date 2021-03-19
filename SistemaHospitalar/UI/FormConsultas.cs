using SistemaHospitalar.DAL;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormConsultas : Form
    {
        public FormConsultas()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dgvConsultas.DataSource = DalConsultas.MostrarConsultas();
        }

        private void btnCadastrarConsulta_Click(object sender, System.EventArgs e)
        {
            FormAgendarConsulta formCadastroConsulta = new FormAgendarConsulta();
            Hide();
            formCadastroConsulta.ShowDialog();
            Close();
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormEntradaRecepcionista formEntradaRecepcionista = new FormEntradaRecepcionista();
            Hide();
            formEntradaRecepcionista.ShowDialog();
            Close();
        }
    }
}
