using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormAgendarConsulta : Form
    {
        public FormAgendarConsulta()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cmbEspecialidade.DataSource = Enum.GetValues(typeof(Especialidades));
        }

        private void FormCadastroConsulta_Load(object sender, System.EventArgs e)
        {
            cmbCpfPacientes.DisplayMember = "NOME";
            cmbCpfPacientes.DataSource = DalPacientes.MostrarCPFPacientes();
            cmbCpfPacientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCpfPacientes.AutoCompleteSource = AutoCompleteSource.ListItems;
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvDoutores.DataSource = DalDoutores.PesquisarEspecialidade((Especialidades)cmbEspecialidade.SelectedIndex);
        }


        private int DoutorId { get; set; }
        private string DoutorNome { get; set; }
        private string EspecialidadeDoutor { get; set; }

        private float ValorConsulta { get; set; }
        private float ValorFinal { get; set; }
        private float ValorDesconto { get; set; }

        private void dgvDoutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoutorId = (int)dgvDoutores.SelectedRows[0].Cells[0].Value;
            DoutorNome = dgvDoutores.SelectedRows[0].Cells[1].Value.ToString();
            txtNomeDoutor.Text = DoutorNome;

            Enum.TryParse(dgvDoutores.SelectedRows[0].Cells[2].Value.ToString(), out Especialidades especialidadeConvertida);
            EspecialidadeDoutor = especialidadeConvertida.ToString();

            ValorConsulta = float.Parse(DalDoutores.PegarValorConsulta(DoutorId));
            ValorFinal = ValorConsulta;
        }


        private void btnAgendarConsulta_Click(object sender, EventArgs e)
        {
            if (txtNomeDoutor.Text.Equals(""))
            {
                MessageBox.Show("Selecione o doutor que irá fazer a consulta!");
            }
            else if (dtpDataConsulta.Value <= DateTime.Now)
            {
                MessageBox.Show("Data inválida");
            }
            else
            {
                ValorDesconto = ValorConsulta * float.Parse(DalConsultas.ValorDescontoConvenio(DalPacientes.Id));
                ValorFinal -= ValorDesconto; //Desconto com respectivo convênio do Paciente

                Consulta consulta = new Consulta(Estado_Consulta.Espera.ToString(), DalPacientes.Id, DoutorId, dtpDataConsulta.Value, ValorFinal);
                DalConsultas dalConsultas = new DalConsultas();

                MessageBox.Show(dalConsultas.AgendarConsulta(consulta));
                AbrirComprovanteDePagamento();
            }

        }


        private void cmbCpfPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNomePaciente.Text = DalPacientes.IdentificarPaciente(cmbCpfPacientes.Text);
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormConsultas formConsultas = new FormConsultas();
            Hide();
            formConsultas.ShowDialog();
            Close();
        }


        private float DescontoConvenio { get; set; }
        private string PegarNomeConvenio()
        {
            string NomeConvenio = "";
            NomeConvenio = DalConvenios.IndentificarNomeConvenio(DalConvenios.IndentificarConvenio(DalPacientes.Id));
            DescontoConvenio = float.Parse(DalConvenios.DescontoConvenio) * 100;
            return NomeConvenio;
        }

        private void AbrirComprovanteDePagamento()
        {
            FormComprovantePagamento formComprovantePagamento = new FormComprovantePagamento();
            Hide();
            formComprovantePagamento.MostrarDadosConsultas(lblNomePaciente.Text, cmbCpfPacientes.Text, dtpDataConsulta.Value.ToString("dd/MM/yyyy hh:mm tt"),
                DoutorNome, EspecialidadeDoutor, ValorFinal.ToString(), PegarNomeConvenio(), DescontoConvenio.ToString() + "%", ValorConsulta.ToString(), ValorDesconto.ToString(), ValorFinal.ToString());

            formComprovantePagamento.ShowDialog();
            Close();
        }
    }
}
