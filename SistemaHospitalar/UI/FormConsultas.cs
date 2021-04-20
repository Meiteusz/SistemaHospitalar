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
        }

        ConsultaBLL consultaBLL = new ConsultaBLL();
        PacienteBLL pacienteBLL = new PacienteBLL();

        private void btnAgendarConsulta_Click(object sender, System.EventArgs e)
        {
            FormAgendarConsulta formCadastroConsulta = new FormAgendarConsulta();
            Base.AbrirFormDesejado(this, formCadastroConsulta);
        }

        private void btnDeletarConsulta_Click(object sender, System.EventArgs e)
        {
            if (dgvConsultas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Escolha uma Consulta para deletar!");
            }
            else
            {
                if (MessageBox.Show("Deseja realmente deletar esta Consulta?", "Deleção de Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show(consultaBLL.DeletarConsulta(FuncionarioLogado.ConsultaTemp.Id));
                    dgvConsultas.DataSource = consultaBLL.ConsultasGeral();
                }
            }
        }

        private void btnAgendarExame_Click(object sender, System.EventArgs e)
        {
            FormExame formExame = new FormExame();
            Base.AbrirFormDesejado(this, formExame);
        }

        private void dgvConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAgendarExame.Enabled = true;
            int IdConsulta = (int)dgvConsultas.CurrentRow.Cells[0].Value;

            FuncionarioLogado.SetConsultaTemp(IdConsulta);
            FuncionarioLogado.SetDoutorTemp(FuncionarioLogado.ConsultaTemp.Doutor);
            pacienteBLL.PegarDadosPaciente(FuncionarioLogado.ConsultaTemp.Paciente, string.Empty);
        }

        private void btnReagendarConsulta_Click(object sender, System.EventArgs e)
        {
            if (dgvConsultas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Selecione uma consulta para o reagendamento!");

            }
            else
            {
                FormReagendamentoConsulta formReagendamentoConsulta = new FormReagendamentoConsulta();
                Base.AbrirFormDesejado(this, formReagendamentoConsulta);
            }
        }

        private void rbTodas_CheckedChanged(object sender, System.EventArgs e)
        {
            dgvConsultas.DataSource = consultaBLL.ConsultasGeral();
        }

        private void rbDataHoje_CheckedChanged(object sender, System.EventArgs e)
        {
            dgvConsultas.DataSource = consultaBLL.ConsultasHoje();
        }
        
        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormEntradaRecepcionista formEntradaRecepcionista = new FormEntradaRecepcionista();
            Base.AbrirFormDesejado(this, formEntradaRecepcionista);
        }
    }
}
