using SistemaHospitalar.DAL;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormViewConsultas : Form
    {
        public FormViewConsultas()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dgvConsultas.DataSource = DalConsultas.MostrarConsultasHoje();
            rbTodas.Checked = true;
        }

        private void rbTodas_CheckedChanged(object sender, System.EventArgs e)
        {
            dgvConsultas.DataSource = DalConsultas.MostrarConsultasDGV();
        }

        private void rbDataHoje_CheckedChanged(object sender, System.EventArgs e)
        {
            dgvConsultas.DataSource = DalConsultas.MostrarConsultasHoje();
        }
    }
}
