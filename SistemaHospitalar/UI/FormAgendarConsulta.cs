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

        private void FormCadastroConsulta_Load(object sender, EventArgs e)
        {
            cmbCpfPacientes.DisplayMember = "NOME";
            cmbCpfPacientes.DataSource = DalPacientes.MostrarCPFPacientes();
            cmbCpfPacientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCpfPacientes.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void PesquisarDoutorDGV()
        {
            dgvDoutores.DataSource = DalDoutores.PesquisarEspecialidade((Especialidades)cmbEspecialidade.SelectedIndex);
            dgvDoutores.Columns["Nome"].Width = 185;
        }

        private void MostrarAgendaDoutorDGV()
        {
            dgvDoutores.DataSource = DalConsultas.MostrarAgendarDoutor(DoutorId);
            dgvDoutores.Columns["NomePaciente"].Width = 185;
            dgvDoutores.Columns["DATACONSULTA"].Width = 200;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarDoutorDGV();
        }

        public static int DoutorId { get; set; }
        private string DoutorNome { get; set; }
        private string EspecialidadeDoutor { get; set; }

        private float ValorConsulta { get; set; }
        private float ValorFinal { get; set; }
        private float ValorDesconto { get; set; }

        private void dgvDoutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // CURRENTROW E CURRENTCELL (MUDAR)
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
            if (ValidarCamposConsulta().Equals(""))
            {
                if (DalConsultas.isDataConsultaValido(dtpDataConsulta.Value, DalPacientes.Id, DoutorId))
                {
                    ValorDesconto = ValorConsulta * float.Parse(DalConsultas.ValorDescontoConvenio(DalPacientes.Id));
                    ValorFinal -= ValorDesconto; //Desconto com respectivo convênio do Paciente

                    Consulta consulta = new Consulta(Estado_Consulta.Espera.ToString(), DalPacientes.Id, DoutorId, dtpDataConsulta.Value, ValorFinal);
                    DalConsultas dalConsultas = new DalConsultas();

                    MessageBox.Show(dalConsultas.AgendarConsulta(consulta));
                    AbrirComprovanteDePagamento();
                }
                else
                {
                    MessageBox.Show("O doutor(a) ou o paciente selecionado já está cadastrado em uma consulta neste Dia/Horario!");
                }
            }
            else
            {
                MessageBox.Show(ValidarCamposConsulta());
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


        private string ValidarCamposConsulta()
        {
            string msg = "";
            if (txtNomeDoutor.Text.Equals(""))
            {
                msg = "Selecione o doutor que irá fazer a consulta!";
            }
            else if (dtpDataConsulta.Value <= DateTime.Now)
            {
                msg = "Data inválida";
            }
            return msg;
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

        private void cbAgendaDoutor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAgendaDoutor.Checked)
            {
                if (dgvDoutores.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selecione um Doutor(a)");
                    cbAgendaDoutor.Checked = false;
                }
                else
                {
                    MostrarAgendaDoutorDGV();

                }
            }
            else
            {
                PesquisarDoutorDGV();
            }
        }
    }
}
