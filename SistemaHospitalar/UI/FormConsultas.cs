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

        private int Id { get; set; }
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
                    MessageBox.Show(dalConsultas.DeletarConsulta(Id));
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
            Id = (int)dgvConsultas.SelectedRows[0].Cells[0].Value;
        }
    }
}
