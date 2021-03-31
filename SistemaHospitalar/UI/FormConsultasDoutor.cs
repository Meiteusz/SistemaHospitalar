using SistemaHospitalar.DAL;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormConsultasDoutor : Form
    {
        public FormConsultasDoutor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dgvConsultas.DataSource = DalConsultas.MostrarConsultasParaDoutor(int.Parse(DalDoutores.Id));
        }

        private void btnFazerDiagnostico_Click(object sender, System.EventArgs e)
        {
            if (dgvConsultas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Selecione a consulta para fazer o Diagnóstico!");
            }
            else
            {
                FormDiagnostico formDiagnostico = new FormDiagnostico();
                Hide();
                formDiagnostico.ShowDialog();
                Close();
            }
        }

        private void dgvConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DalConsultas.NomePaciente = dgvConsultas.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormEntradaDoutores formEntradaDoutores = new FormEntradaDoutores();
            Hide();
            formEntradaDoutores.ShowDialog();
            Close();
        }
    }
}
