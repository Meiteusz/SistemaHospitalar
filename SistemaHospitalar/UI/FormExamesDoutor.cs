using SistemaHospitalar.BLL;
using SistemaHospitalar.Utilities;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormExamesDoutor : Form
    {
        public FormExamesDoutor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dgvExames.DataSource = examesBLL.MostrarExamesDoutor(FuncionarioLogado.DoutorLogado.Id);
            btnFazerDiagnóstico.Enabled = false;
            btnVerDiagnósticosDoExame.Enabled = false;
        }

        ExamesBLL examesBLL = new ExamesBLL();

        private void btnFazerDiagnóstico_Click(object sender, System.EventArgs e)
        {
            FormDiagnostico formDiagnosticos = new FormDiagnostico();
            formDiagnosticos.ShowDialog();
        }

        private void dgvExames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnFazerDiagnóstico.Enabled = true;
            int IdExame = (int)dgvExames.CurrentRow.Cells[0].Value;
            FuncionarioLogado.SetExameTemp(IdExame);
            if (examesBLL.isDiagnosticoExistente(FuncionarioLogado.ExameTemp.Id))
            {
                btnVerDiagnósticosDoExame.Enabled = true;
            }
            else
            {
                btnVerDiagnósticosDoExame.Enabled = false;
            }
        }

        private void btnVerDiagnósticosDoExame_Click(object sender, System.EventArgs e)
        {
            FormDiagnosticosDoExame formDiagnosticosDoExame = new FormDiagnosticosDoExame();
            Base.AbrirFormDesejado(this, formDiagnosticosDoExame);
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormEntradaDoutores formEntradaDoutores = new FormEntradaDoutores();
            Base.AbrirFormDesejado(this, formEntradaDoutores);
        }
    }
}
