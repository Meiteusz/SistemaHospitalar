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

        private void btnCadastrarConvenio_Click(object sender, System.EventArgs e)
        {
            DalConvenios dalConvenios = new DalConvenios();
            Convenios convenios = new Convenios(txtNomeConvenio.Text, float.Parse(txtDescontoConvenio.Text) / 100);

            MessageBox.Show(dalConvenios.CadastrarConvenio(convenios));
            dgvConvenios.DataSource = DalConvenios.MostrarConveniosDGV();
        }

        private void btnDeletarConvenio_Click(object sender, System.EventArgs e)
        {

        }

        private void btnAtualizarConvenio_Click(object sender, System.EventArgs e)
        {

        }

        private int ID { get; set; }
        private string Nome { get; set; }

        private void dgvConvenios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = (int)dgvConvenios.SelectedRows[0].Cells[0].Value;
            Nome = dgvConvenios.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
