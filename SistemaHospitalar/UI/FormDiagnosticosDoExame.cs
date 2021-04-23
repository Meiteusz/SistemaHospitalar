using SistemaHospitalar.BLL;
using SistemaHospitalar.Utilities;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormDiagnosticosDoExame : Form
    {
        public FormDiagnosticosDoExame()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dgvDiagnosticosDoExame.DataSource = examesBLL.MostrarDiagnosticosExame(FuncionarioLogado.ExameTemp.Id);
            btnVerDescricao.Enabled = false;
            btnDeletarDiagnostico.Enabled = false;
        }

        ExamesBLL examesBLL = new ExamesBLL();

        private void btnVerDescricao_Click(object sender, System.EventArgs e)
        {
            FormDescricaoDiagnostico formDescricaoDiagnostico = new FormDescricaoDiagnostico();
            formDescricaoDiagnostico.ShowDialog();
        }

        private void btnDeletarDiagnostico_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(examesBLL.DeletarDiagnostico(FuncionarioLogado.DiagnosticoTemp.Id));
            dgvDiagnosticosDoExame.DataSource = examesBLL.MostrarDiagnosticosExame(FuncionarioLogado.ExameTemp.Id);
        }

        private void dgvDiagnosticosDoExame_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnVerDescricao.Enabled = true;
            btnDeletarDiagnostico.Enabled = true;
            int IdDiagnostico = (int)dgvDiagnosticosDoExame.CurrentRow.Cells[0].Value;
            FuncionarioLogado.SetDiagnosticoTemp(IdDiagnostico);
        }

        private void FormDiagnosticosDoExame_Load(object sender, System.EventArgs e)
        {
            dgvDiagnosticosDoExame.Columns["ID_Diagnostico"].Width = 115;
            dgvDiagnosticosDoExame.Columns["Descricao"].Width = 250;
            dgvDiagnosticosDoExame.Columns["Data_Diagnostico"].Width = 122;
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormExamesDoutor formExamesDoutor = new FormExamesDoutor();
            Base.AbrirFormDesejado(this, formExamesDoutor);
        }
    }
}
