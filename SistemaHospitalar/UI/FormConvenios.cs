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
            Convenios convenios = new Convenios(txtNomeConvenio.Text, float.Parse(txtDescontoConvenio.Text));

            MessageBox.Show(dalConvenios.CadastrarConvenio(convenios));
        }

        private void btnDeletarConvenio_Click(object sender, System.EventArgs e)
        {

        }

        private void btnAtualizarConvenio_Click(object sender, System.EventArgs e)
        {

        }
    }
}
