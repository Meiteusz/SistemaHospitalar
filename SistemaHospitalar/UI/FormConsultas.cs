using SistemaHospitalar.DAL;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormConsultas : Form
    {
        public FormConsultas()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dgvConsultas.DataSource = DalConsultas.MostrarConsultasDGV();
        }

        private void btnAgendarConsulta_Click(object sender, System.EventArgs e)
        {
            FormAgendarConsulta formCadastroConsulta = new FormAgendarConsulta();
            Hide();
            formCadastroConsulta.ShowDialog();
            Close();
        }

        private void btnDeletarConsulta_Click(object sender, System.EventArgs e)
        {
            if (dgvConsultas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Escolha uma Consulta para deletar!");
            }
            else
            {
                DalConsultas dalConsultas = new DalConsultas();
                if (MessageBox.Show("Deseja realmente deletar esta Consulta?", "Deleção de Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show(dalConsultas.DeletarConsulta(DalConsultas.Id));
                    dgvConsultas.DataSource = DalConsultas.MostrarConsultasDGV();
                }
            }
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormEntradaRecepcionista formEntradaRecepcionista = new FormEntradaRecepcionista();
            Hide();
            formEntradaRecepcionista.ShowDialog();
            Close();
        }

        private void dgvConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DalConsultas.Id = (int)dgvConsultas.SelectedRows[0].Cells[0].Value;
            DalConsultas.DataConsulta = dgvConsultas.SelectedRows[0].Cells[4].Value.ToString();
            DalConsultas.NomePaciente = dgvConsultas.SelectedRows[0].Cells[2].Value.ToString();
            
            //DalConsultas.IdDoutor = dgvConsultas.SelectedRows[0].Cells[3].Value;
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
                Hide();
                formReagendamentoConsulta.ShowDialog();
                Close();
            }
        }
    }
}
