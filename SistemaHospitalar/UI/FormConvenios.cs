using SistemaHospitalar.BLL;
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

        ConveniosBLL conveniosBLL = new ConveniosBLL();

        private void btnCadastrarConvenio_Click(object sender, System.EventArgs e)
        {
            Convenios convenios = new Convenios(txtNomeConvenio.Text, float.Parse(txtDescontoConvenio.Text) / 100);

            MessageBox.Show(conveniosBLL.CadastrarConvenio(convenios));
            dgvConvenios.DataSource = DalConvenios.MostrarConveniosDGV();
        }

        private void dgvConvenios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conveniosBLL.PegarDadosConvenio((int)dgvConvenios.CurrentRow.Cells[0].Value);
        }

        private void FormConvenios_Load(object sender, System.EventArgs e)
        {
            dgvConvenios.Columns["ID"].Width = 50;
            dgvConvenios.Columns["Convênio_Nome"].Width = 280;
            dgvConvenios.Columns["Convênio_Desconto"].Width = 131;
        }

        private void BtnVoltar_Click(object sender, System.EventArgs e)
        {
            FormEntradaADM formEntradaADM = new FormEntradaADM();
            Base.AbrirFormDesejado(this, formEntradaADM);
        }
    }
}
