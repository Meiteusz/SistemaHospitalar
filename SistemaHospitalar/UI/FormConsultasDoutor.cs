using SistemaHospitalar.BLL;
using SistemaHospitalar.Utilities;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormConsultasDoutor : Form
    {
        public FormConsultasDoutor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dgvConsultas.DataSource = ConsultaBLL.ConsultasDoutor(FuncionarioLogado.DoutorLogado.Id);
        }

        ConsultaBLL ConsultaBLL = new ConsultaBLL();

        private void btnFazerDiagnostico_Click(object sender, System.EventArgs e)
        {
            if (dgvConsultas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Selecione a consulta para fazer o Diagnóstico!");
            }
            else
            {
                FormDiagnostico formDiagnostico = new FormDiagnostico();
                Base.AbrirFormDesejado(this, formDiagnostico);
            }
        }

        private void dgvConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdConsulta = (int)dgvConsultas.CurrentRow.Cells[0].Value;

            FuncionarioLogado.SetConsultaTemp(IdConsulta);
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormEntradaDoutores formEntradaDoutores = new FormEntradaDoutores();
            Base.AbrirFormDesejado(this, formEntradaDoutores);
        }
    }
}
