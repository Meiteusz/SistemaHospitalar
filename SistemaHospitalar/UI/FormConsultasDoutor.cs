using SistemaHospitalar.BLL;
using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
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
            dgvConsultas.DataSource = DalConsultas.MostrarConsultasParaDoutor(FuncionarioLogado.DoutorLogado.Id);
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
                Base.AbrirFormDesejado(this, formDiagnostico);
            }
        }

        private void dgvConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.NomePaciente = dgvConsultas.CurrentRow.Cells[1].Value.ToString();
            FuncionarioLogado.SetConsultaSelecionada(consulta);
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormEntradaDoutores formEntradaDoutores = new FormEntradaDoutores();
            Base.AbrirFormDesejado(this, formEntradaDoutores);
        }
    }
}
