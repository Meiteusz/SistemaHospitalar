using SistemaHospitalar.BLL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Utilities;
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
            dtpDataConsulta.Value = DateTime.Today;
            cmbEspecialidade.DataSource = Enum.GetValues(typeof(Especialidades));
            btnCadastrarConsulta.Enabled = false;
        }

        ConsultaBLL consultaBLL = new ConsultaBLL();
        PacienteBLL pacienteBLL = new PacienteBLL();
        DoutoresBLL doutoresBLL = new DoutoresBLL();
        ConveniosBLL ConveniosBLL = new ConveniosBLL();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarDoutorDGV();
        }

        private void dgvDoutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdDoutor = (int)dgvDoutores.CurrentRow.Cells[0].Value;
            FuncionarioLogado.SetDoutorTemp(IdDoutor);

            txtNomeDoutor.Text = FuncionarioLogado.DoutorTemp.Nome;
            btnCadastrarConsulta.Enabled = true;
        }

        private void btnAgendarConsulta_Click(object sender, EventArgs e)
        {
            pacienteBLL.PegarDadosPaciente(0, cmbCpfPacientes.Text);
            ConveniosBLL.PegarDadosConvenio(FuncionarioLogado.PacienteSelecionado.Convenio);
            consultaBLL.SetValoresConsulta(FuncionarioLogado.DoutorTemp.ValorConsulta, FuncionarioLogado.ConvenioSelecionado.Desconto);

            Consulta consulta = new Consulta(FuncionarioLogado.PacienteSelecionado.Id, FuncionarioLogado.DoutorTemp.Id, dtpDataConsulta.Value, consultaBLL.ValorFinalConsulta);

            if (consultaBLL.isDataValida(consulta))
            {
                MessageBox.Show(consultaBLL.AgendarConsulta(consulta));
                AbrirComprovanteDePagamento();
            }
            else
            {
                MessageBox.Show("O doutor(a) ou o paciente selecionado já está cadastrado em uma consulta neste Dia/Horario!\nVerifique tambem se a data/horário é válida!");
            }
        }

        private void FormCadastroConsulta_Load(object sender, EventArgs e)
        {
            //cmbCpfPacientes.DisplayMember = "NOME";
            cmbCpfPacientes.DataSource = pacienteBLL.MostrarCpfPacientes();
            cmbCpfPacientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCpfPacientes.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cmbCpfPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacienteBLL.PegarDadosPaciente(0, cmbCpfPacientes.Text);
            lblNomePaciente.Text = FuncionarioLogado.PacienteSelecionado.Nome;
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormConsultas formConsultas = new FormConsultas();
            Base.AbrirFormDesejado(this, formConsultas);
        }

        private void AbrirComprovanteDePagamento()
        {
            FormComprovantePagamento formComprovantePagamento = new FormComprovantePagamento();
            Hide();
            formComprovantePagamento.MostrarDadosConsultas(lblNomePaciente.Text, cmbCpfPacientes.Text, dtpDataConsulta.Value.ToString("dd/MM/yyyy HH:mm tt"),
                FuncionarioLogado.DoutorTemp.Nome, FuncionarioLogado.DoutorTemp.Especialidade.ToString(), consultaBLL.ValorFinalConsulta.ToString(), FuncionarioLogado.ConvenioSelecionado.Nome,
                (FuncionarioLogado.ConvenioSelecionado.Desconto * 100).ToString(), consultaBLL.ValorConsulta.ToString(), consultaBLL.ValorDesconto.ToString(), consultaBLL.ValorFinalConsulta.ToString());

            formComprovantePagamento.ShowDialog();
            Close();
        }

        private void PesquisarDoutorDGV()
        {
            dgvDoutores.DataSource = doutoresBLL.MostrarDoutoresConsulta((Especialidades)cmbEspecialidade.SelectedIndex);
        }

        private void MostrarAgendaDoutorDGV()
        {
            dgvDoutores.DataSource = consultaBLL.AgendaDoutor(FuncionarioLogado.DoutorTemp.Id);
            dgvDoutores.Columns["NomePaciente"].Width = 185;
            dgvDoutores.Columns["DATACONSULTA"].Width = 200;
        }
    }
}
