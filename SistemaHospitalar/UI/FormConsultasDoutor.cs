using SistemaHospitalar.DAL;
using SistemaHospitalar.Models;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormConsultasDoutor : Form
    {
        public FormConsultasDoutor()
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

        private void btnFazerDiagnostico_Click(object sender, System.EventArgs e)
        {
            FormDiagnostico formDiagnostico = new FormDiagnostico();
            Hide();
            formDiagnostico.ShowDialog();
            Close();
        }

        private void dgvConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DalConsultas.NomePaciente = dgvConsultas.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
