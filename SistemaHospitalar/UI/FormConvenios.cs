using SistemaHospitalar.BLL;
using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Utilities;
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

        private void btnDeletarConvenio_Click(object sender, System.EventArgs e)
        {
            if (isLinhaSelecionada())
                DeletarConvenio();
            else
                MessageBox.Show("Selecione um Convênio!");
        }
        
        private bool isLinhaSelecionada()
        {
            bool isSelecionada = true;
            if (dgvConvenios.SelectedRows.Count != 1 || FuncionarioLogado.ConvenioSelecionado.Nome.Equals("Nenhum"))
                isSelecionada = false;
            return isSelecionada;
        }
        private void DeletarConvenio()
        {
            if (MessageBox.Show("Deseja realmente deletar o Convênio " + FuncionarioLogado.ConvenioSelecionado.Nome + "?", "Deletar Convênio", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(conveniosBLL.DeletarConvenio(FuncionarioLogado.ConvenioSelecionado.Id));
                dgvConvenios.DataSource = DalConvenios.MostrarConveniosDGV();
            }
        }

        private void dgvConvenios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conveniosBLL.PegarDadosConvenio((int)dgvConvenios.CurrentRow.Cells[0].Value);
        }

        private void BtnVoltar_Click(object sender, System.EventArgs e)
        {
            FormEntradaADM formEntradaADM = new FormEntradaADM();
            Base.AbrirFormDesejado(this, formEntradaADM);
        }
    }
}
