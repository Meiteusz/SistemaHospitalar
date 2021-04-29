using SistemaHospitalar.BLL;
using SistemaHospitalar.Utilities;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormConsultas : Form
    {
        public FormConsultas()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            rbTodas.Checked = true;
            btnAgendarExame.Enabled = false;
            btnReagendarConsulta.Enabled = false;
        }

        ConsultaBLL consultaBLL = new ConsultaBLL();
        PacienteBLL pacienteBLL = new PacienteBLL();

        private void btnAgendarConsulta_Click(object sender, System.EventArgs e)
        {
            FormAgendarConsulta formCadastroConsulta = new FormAgendarConsulta();
            Base.AbrirFormDesejado(this, formCadastroConsulta);
        }

        private void btnAgendarExame_Click(object sender, System.EventArgs e)
        {
            FormAgendarExame formExame = new FormAgendarExame();
            Base.AbrirFormDesejado(this, formExame);
        }

        private void dgvConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAgendarExame.Enabled = true;
            btnReagendarConsulta.Enabled = true;
            int IdConsulta = (int)dgvConsultas.CurrentRow.Cells[0].Value;

            FuncionarioLogado.SetConsultaTemp(IdConsulta);
            FuncionarioLogado.SetDoutorTemp(FuncionarioLogado.ConsultaTemp.Doutor);
            pacienteBLL.PegarDadosPaciente(FuncionarioLogado.ConsultaTemp.Paciente, string.Empty);
        }

        private void btnReagendarConsulta_Click(object sender, System.EventArgs e)
        {
            FormReagendamentoConsulta formReagendamentoConsulta = new FormReagendamentoConsulta();
            Base.AbrirFormDesejado(this, formReagendamentoConsulta);
        }

        private void rbTodas_CheckedChanged(object sender, System.EventArgs e)
        {
            dgvConsultas.DataSource = consultaBLL.ConsultasGeral();
        }

        private void rbDataHoje_CheckedChanged(object sender, System.EventArgs e)
        {
            dgvConsultas.DataSource = consultaBLL.ConsultasHoje();
        }

        private void FormConsultas_Load(object sender, System.EventArgs e)
        {
            txtNomePacientes.AutoCompleteCustomSource = pacienteBLL.MostrarNomesPacientes();
            txtNomePacientes.AutoCompleteMode = AutoCompleteMode.Append;
            txtNomePacientes.AutoCompleteSource = AutoCompleteSource.CustomSource;

            dgvConsultas.Columns["ID"].Width = 50;
            dgvConsultas.Columns["Paciente_Nome"].Width = 200;
            dgvConsultas.Columns["Doutor_Nome"].Width = 200;
            dgvConsultas.Columns["Data_Horario"].Width = 110;
            dgvConsultas.Columns["Valor"].Width = 80;
            dgvConsultas.Columns["Convênio_Nome"].Width = 157;
        }
        
        private void txtNomePacientes_TextChanged(object sender, System.EventArgs e)
        {
            if (txtNomePacientes.Text.Equals(string.Empty))
            {
                dgvConsultas.DataSource = consultaBLL.ConsultasGeral();
            }
            else
            {
                dgvConsultas.DataSource = consultaBLL.PesquisarConsultaByNomePaciente(txtNomePacientes.Text);
            }
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormEntradaRecepcionista formEntradaRecepcionista = new FormEntradaRecepcionista();
            Base.AbrirFormDesejado(this, formEntradaRecepcionista);
        }
    }
}
