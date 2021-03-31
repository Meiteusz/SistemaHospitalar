using SistemaHospitalar.DAL;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormDiagnostico : Form
    {
        public FormDiagnostico()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtNomePaciente.Text = DalConsultas.NomePaciente;
    }
}
}
