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
            btnFazerDiagnostico.Enabled = false;
        }

        ConsultaBLL ConsultaBLL = new ConsultaBLL();

        private void btnFazerDiagnostico_Click(object sender, System.EventArgs e)
        {
            FormDiagnosticoDaConsulta formDiagnostico = new FormDiagnosticoDaConsulta();
            Base.AbrirFormDesejado(this, formDiagnostico);
        }

        private void dgvConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnFazerDiagnostico.Enabled = true;
            int IdConsulta = (int)dgvConsultas.CurrentRow.Cells[0].Value;
            FuncionarioLogado.SetConsultaTemp(IdConsulta);
        }

        private void FormConsultasDoutor_Load(object sender, System.EventArgs e)
        {
            dgvConsultas.Columns["ID"].Width = 50;
            dgvConsultas.Columns["Paciente_Nome"].Width = 250;
            dgvConsultas.Columns["Data_Horario"].Width = 121;
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormEntradaDoutores formEntradaDoutores = new FormEntradaDoutores();
            Base.AbrirFormDesejado(this, formEntradaDoutores);
        }
    }
}
