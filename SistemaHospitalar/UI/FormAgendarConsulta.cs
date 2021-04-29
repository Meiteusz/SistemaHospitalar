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
            dgvDoutores.DataSource = doutoresBLL.MostrarDoutoresConsulta(Especialidades.Selecione);
            btnCadastrarConsulta.Enabled = false;
        }

        ConsultaBLL consultaBLL = new ConsultaBLL();
        PacienteBLL pacienteBLL = new PacienteBLL();
        DoutoresBLL doutoresBLL = new DoutoresBLL();
        ConveniosBLL conveniosBLL = new ConveniosBLL();

        private void btnAgendarConsulta_Click(object sender, EventArgs e)
        {
            pacienteBLL.PegarDadosPaciente(0, cmbCpfPacientes.Text);
            conveniosBLL.PegarDadosConvenio(FuncionarioLogado.PacienteSelecionado.Convenio);
            consultaBLL.SetValoresConsulta(FuncionarioLogado.DoutorTemp.ValorConsulta, FuncionarioLogado.ConvenioSelecionado.Desconto);

            Consulta consulta = new Consulta(FuncionarioLogado.PacienteSelecionado.Id, FuncionarioLogado.DoutorTemp.Id, dtpDataConsulta.Value, consultaBLL.ValorFinalConsulta);

            if (consultaBLL.isDataValida(consulta))
            {
                MessageBox.Show(consultaBLL.AgendarConsulta(consulta));
                AbrirExtratoConsulta();
            }
            else
            {
                MessageBox.Show("Paciente/Doutor selecionado já está cadastrado em uma consulta/exame neste Horário.\nVerifique também se a data/horário é válida!", "Agendamento de consulta inválido");
            }
        }

        private void dgvDoutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdDoutor = (int)dgvDoutores.CurrentRow.Cells[0].Value;
            FuncionarioLogado.SetDoutorTemp(IdDoutor);

            txtNomeDoutor.Text = FuncionarioLogado.DoutorTemp.Nome;
            btnCadastrarConsulta.Enabled = true;
        }

        private void FormCadastroConsulta_Load(object sender, EventArgs e)
        {
            dgvDoutores.Columns["ID"].Width = 50;
            dgvDoutores.Columns["Doutor_Nome"].Width = 203;
            dgvDoutores.Columns["Valor"].Width = 80;

            cmbCpfPacientes.DataSource = pacienteBLL.MostrarCpfPacientes();
            cmbCpfPacientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCpfPacientes.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cmbCpfPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacienteBLL.PegarDadosPaciente(0, cmbCpfPacientes.Text);
            lblNomePaciente.Text = FuncionarioLogado.PacienteSelecionado.Nome;
        }

        private void cmbEspecialidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDoutores.DataSource = doutoresBLL.MostrarDoutoresConsulta((Especialidades)cmbEspecialidade.SelectedIndex);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormConsultas formConsultas = new FormConsultas();
            Base.AbrirFormDesejado(this, formConsultas);
        }

        private void AbrirExtratoConsulta()
        {
            FormExtratoConsulta formComprovantePagamento = new FormExtratoConsulta();
            Hide();
            formComprovantePagamento.MostrarDadosConsultas(lblNomePaciente.Text, cmbCpfPacientes.Text, dtpDataConsulta.Value.ToString("dd/MM/yyyy HH:mm tt"),
                FuncionarioLogado.DoutorTemp.Nome, FuncionarioLogado.DoutorTemp.Especialidade.ToString(), consultaBLL.ValorFinalConsulta.ToString(), FuncionarioLogado.ConvenioSelecionado.Nome,
                (FuncionarioLogado.ConvenioSelecionado.Desconto * 100).ToString(), consultaBLL.ValorConsulta.ToString(), consultaBLL.ValorDesconto.ToString(), consultaBLL.ValorFinalConsulta.ToString());

            formComprovantePagamento.ShowDialog();
            Close();
        }
    }
}
