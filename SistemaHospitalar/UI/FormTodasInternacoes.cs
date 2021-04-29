using SistemaHospitalar.BLL;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormTodasInternacoes : Form
    {
        public FormTodasInternacoes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dgvInternacoes.DataSource = internacaoBLL.TodasInternacoes();
        }

        InternacaoBLL internacaoBLL = new InternacaoBLL();
        PacienteBLL pacienteBLL = new PacienteBLL();

        private void FormTodasInternacoes_Load(object sender, System.EventArgs e)
        {
            FormatarColunasDGV();
            txtNomePaciente.AutoCompleteCustomSource = pacienteBLL.MostrarNomesPacientes();
            txtNomePaciente.AutoCompleteMode = AutoCompleteMode.Append;
            txtNomePaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void txtNomePaciente_TextChanged(object sender, EventArgs e)
        {
            if (txtNomePaciente.Text.Equals(string.Empty))
            {
                dgvInternacoes.DataSource = internacaoBLL.TodasInternacoes();
            }
            else
            {
                dgvInternacoes.DataSource = internacaoBLL.PesquisarInternacaoByNomePaciente(txtNomePaciente.Text, txtNomePaciente.Text);
            }
        }

        private void dgvInternacoes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInternacoes.CurrentCell.ColumnIndex.Equals(1))
            {
                Clipboard.SetText(dgvInternacoes.CurrentRow.Cells[1].Value.ToString());
                lblCopiarCPF.Text = "CPF copiado";
            }
        }

        private void btnCadastrarInternacao_Click(object sender, EventArgs e)
        {
            FormInternacao formInternacao = new FormInternacao();
            Base.AbrirFormDesejado(this, formInternacao);
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormEntradaRecepcionista formEntradaRecepcionista = new FormEntradaRecepcionista();
            Base.AbrirFormDesejado(this, formEntradaRecepcionista);
        }

        public void FormatarColunasDGV()
        {
            dgvInternacoes.Columns["Paciente_Nome"].Width = 205;
            dgvInternacoes.Columns["Doutor_Nome"].Width = 205;
            dgvInternacoes.Columns["Tipo_Internacao"].Width = 111;
            dgvInternacoes.Columns["Numero_Quarto"].Width = 106;
        }
    }
}
