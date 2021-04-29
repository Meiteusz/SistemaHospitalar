using SistemaHospitalar.BLL;
using SistemaHospitalar.Utilities;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormExames : Form
    {
        public FormExames()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dgvExames.DataSource = examesBLL.MostrarExames();
            btnReagendarExame.Enabled = false;
            rbTodos.Checked = true;
        }

        ExamesBLL examesBLL = new ExamesBLL();
        PacienteBLL pacienteBLL = new PacienteBLL();

        private void FormExames_Load(object sender, System.EventArgs e)
        {
            txtNomePacientes.AutoCompleteCustomSource = pacienteBLL.MostrarNomesPacientes();
            txtNomePacientes.AutoCompleteMode = AutoCompleteMode.Append;
            txtNomePacientes.AutoCompleteSource = AutoCompleteSource.CustomSource;

            dgvExames.Columns["ID"].Width = 50;
            dgvExames.Columns["Cons_Id"].Width = 60;
            dgvExames.Columns["Paciente_Nome"].Width = 200;
            dgvExames.Columns["Doutor_Nome"].Width = 200;
            dgvExames.Columns["Data_Horario"].Width = 110;
            dgvExames.Columns["Valor"].Width = 80;
            dgvExames.Columns["Exame_Tipo"].Width = 220;
        }

        private void dgvExames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnReagendarExame.Enabled = true;
            int IdExame = (int)dgvExames.CurrentRow.Cells[0].Value;
            FuncionarioLogado.SetExameTemp(IdExame);
            FuncionarioLogado.SetConsultaTemp(FuncionarioLogado.ExameTemp.ConsultaId);
            FuncionarioLogado.SetDoutorTemp(FuncionarioLogado.ConsultaTemp.Doutor);
            pacienteBLL.PegarDadosPaciente(FuncionarioLogado.ConsultaTemp.Paciente, string.Empty);
        }

        private void btnReagendarExame_Click(object sender, System.EventArgs e)
        {
            FormReagendamentoExame formReagendamentoExame = new FormReagendamentoExame();
            Base.AbrirFormDesejado(this, formReagendamentoExame);
        }

        private void txtNomePacientes_TextChanged(object sender, System.EventArgs e)
        {
            if (txtNomePacientes.Text.Equals(string.Empty))
            {
                dgvExames.DataSource = examesBLL.MostrarExames();
            }
            else
            {
                dgvExames.DataSource = examesBLL.PesquisarExamesByNomePaciente(txtNomePacientes.Text);
            }
        }

        private void rbTodos_CheckedChanged(object sender, System.EventArgs e)
        {
            dgvExames.DataSource = examesBLL.MostrarExames();
        }

        private void rbDataHoje_CheckedChanged(object sender, System.EventArgs e)
        {
            dgvExames.DataSource = examesBLL.MostrarExamesHoje();
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormEntradaRecepcionista formEntradaRecepcionista = new FormEntradaRecepcionista();
            Base.AbrirFormDesejado(this, formEntradaRecepcionista);
        }
    }
}
