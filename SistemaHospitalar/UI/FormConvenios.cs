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

        private int ID { get; set; }
        private string Nome { get; set; }

        ConveniosBLL conveniosBLL = new ConveniosBLL();

        private void btnCadastrarConvenio_Click(object sender, System.EventArgs e)
        {
            Convenios convenios = new Convenios(txtNomeConvenio.Text, float.Parse(txtDescontoConvenio.Text) / 100);

            MessageBox.Show(conveniosBLL.CadastrarConvenio(convenios));
            dgvConvenios.DataSource = DalConvenios.MostrarConveniosDGV();
        }

        private bool isLinhaSelecionada()
        {
            bool isSelecionada = true;
            if (dgvConvenios.SelectedRows.Count != 1 || Nome.Equals("Nenhum"))
                isSelecionada = false;
            return isSelecionada;
        }

        private void DeletarConvenio()
        {
            if (MessageBox.Show("Deseja realmente deletar o Convênio " + Nome + "?", "Deletar Convênio", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(conveniosBLL.DeletarConvenio(ID));
                dgvConvenios.DataSource = DalConvenios.MostrarConveniosDGV();
            }
        }

        private void btnDeletarConvenio_Click(object sender, System.EventArgs e)
        {
            if (isLinhaSelecionada())
                DeletarConvenio();
            else
                MessageBox.Show("Selecione um Convênio!");
        }

        private void dgvConvenios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = (int)dgvConvenios.SelectedRows[0].Cells[0].Value;
            Nome = dgvConvenios.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
