using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormConvenios : Form
    {
        public FormConvenios()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dgvConvenios.DataSource = DalConvenios.MostrarConveniosDGV();
        }

        private int ID { get; set; }
        private string Nome { get; set; }

        private void btnCadastrarConvenio_Click(object sender, System.EventArgs e)
        {
            DalConvenios dalConvenios = new DalConvenios();
            Convenios convenios = new Convenios(txtNomeConvenio.Text, float.Parse(txtDescontoConvenio.Text) / 100);

            MessageBox.Show(dalConvenios.CadastrarConvenio(convenios));
            dgvConvenios.DataSource = DalConvenios.MostrarConveniosDGV();
        }

        private void btnDeletarConvenio_Click(object sender, System.EventArgs e)
        {
            if (dgvConvenios.SelectedRows.Count != 1 || Nome.Equals("Nenhum"))
            {
                MessageBox.Show("Escolha um Convênio para deletar!");
            }
            else
            {
                if (MessageBox.Show("Deseja realmente deletar o Convênio " + Nome + "?", "Deletar Convênio", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DalConvenios dalConvenios = new DalConvenios();
                    MessageBox.Show(dalConvenios.DeletarConvenio(ID));
                    dgvConvenios.DataSource = DalConvenios.MostrarConveniosDGV();
                }
            }
        }

        private void dgvConvenios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = (int)dgvConvenios.SelectedRows[0].Cells[0].Value;
            Nome = dgvConvenios.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormEntradaRecepcionista formEntradaRecepcionista = new FormEntradaRecepcionista();
            Hide();
            formEntradaRecepcionista.ShowDialog();
            Close();
        }
    }
}
