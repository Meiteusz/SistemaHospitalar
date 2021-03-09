using SistemaHospitalar.DAL;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormEntradaDoutores : Form
    {
        public FormEntradaDoutores()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            lblNome.Text = "Bem vindo: " + DalDoutores.Nome;
        }

        private void btnConfiguracoes_Click(object sender, System.EventArgs e)
        {
            FormConfiguracoesDoutores formConfiguracoesDoutores = new FormConfiguracoesDoutores();
            Hide();
            formConfiguracoesDoutores.ShowDialog();
            Close();
        }
    }
}
