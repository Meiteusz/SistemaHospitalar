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
            rbTodosExames.Checked = true;
        }

        ExamesBLL examesBLL = new ExamesBLL();
        PacienteBLL pacienteBLL = new PacienteBLL();

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

        private void FormExamesDoutor_Load(object sender, System.EventArgs e)
        {
            txtNomePacientes.AutoCompleteCustomSource = pacienteBLL.MostrarNomesPacientes();
            txtNomePacientes.AutoCompleteMode = AutoCompleteMode.Append;
            txtNomePacientes.AutoCompleteSource = AutoCompleteSource.CustomSource;

            dgvExames.Columns["ID"].Width = 50;
            dgvExames.Columns["Cons_Id"].Width = 60;
            dgvExames.Columns["Paciente_Nome"].Width = 200;
            dgvExames.Columns["Tipo_Exame"].Width = 244;
        }

        private void rbTodosExames_CheckedChanged(object sender, System.EventArgs e)
        {
            dgvExames.DataSource = examesBLL.MostrarExamesDoutor(FuncionarioLogado.DoutorLogado.Id);
        }

        private void rbExamesHoje_CheckedChanged(object sender, System.EventArgs e)
        {
            dgvExames.DataSource = examesBLL.MostrarExamesHojeDoutor(FuncionarioLogado.DoutorLogado.Id);
        }

        private void txtNomePacientes_TextChanged(object sender, System.EventArgs e)
        {
            if (txtNomePacientes.Text.Equals(string.Empty))
            {
                dgvExames.DataSource = examesBLL.MostrarExamesDoutor(FuncionarioLogado.DoutorLogado.Id);
            }
            else
            {
                dgvExames.DataSource = examesBLL.PesquisarExamesDoutorByNomePaciente(FuncionarioLogado.DoutorLogado.Id, txtNomePacientes.Text);
            }
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormEntradaDoutores formEntradaDoutores = new FormEntradaDoutores();
            Base.AbrirFormDesejado(this, formEntradaDoutores);
        }
    }
}
