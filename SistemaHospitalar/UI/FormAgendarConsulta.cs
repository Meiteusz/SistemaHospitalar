using SistemaHospitalar.BLL;
using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            IEnumerable<Especialidades> values = Enum.GetValues(typeof(Especialidades)).Cast<Especialidades>();
            List<string> valuesWithSpaces = new List<string>(values.Select(v => v.ToString().Replace("_", " ")));
            cmbEspecialidade.DataSource = valuesWithSpaces;
        }

        ConsultaBLL consultaBLL = new ConsultaBLL();
        PacienteBLL pacienteBLL = new PacienteBLL();
        DoutoresBLL doutoresBLL = new DoutoresBLL();

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
            DoutorId = (int)dgvDoutores.CurrentRow.Cells[0].Value;
            DoutorNome = dgvDoutores.CurrentRow.Cells[1].Value.ToString();
            txtNomeDoutor.Text = DoutorNome;

            Enum.TryParse(dgvDoutores.CurrentRow.Cells[2].Value.ToString(), out Especialidades especialidadeConvertida);
            EspecialidadeDoutor = especialidadeConvertida.ToString();

            ValorConsulta = (float)dgvDoutores.CurrentRow.Cells[3].Value;
            ValorConsulta = float.Parse(DalDoutores.PegarValorConsulta(DoutorId));
            ValorFinal = ValorConsulta;
        }


        private void btnAgendarConsulta_Click(object sender, EventArgs e)
        {
            ValorDesconto = ValorConsulta * float.Parse(DalConsultas.ValorDescontoConvenio(DalPacientes.Id));
            ValorFinal -= ValorDesconto; //Desconto com respectivo convênio do Paciente

            if (ValidarCamposConsulta().Equals(""))
            {
                Consulta consulta = new Consulta(DalPacientes.Id, DoutorId, dtpDataConsulta.Value, ValorFinal);

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
            else
            {
                MessageBox.Show(ValidarCamposConsulta());
            }
        }






        private string ValidarCamposConsulta()
        {
            string msg = "";
            if (txtNomeDoutor.Text.Equals(""))
            {
                msg = "Selecione o doutor que irá fazer a consulta!";
            }
            else if (dtpDataConsulta.Value <= DateTime.Now || dtpDataConsulta.Value.DayOfWeek.Equals(DayOfWeek.Saturday) ||
                dtpDataConsulta.Value.DayOfWeek.Equals(DayOfWeek.Sunday) || dtpDataConsulta.Value.Hour > 23 || dtpDataConsulta.Value.Hour < 7 ||
                dtpDataConsulta.Value.Minute != 0 && dtpDataConsulta.Value.Minute != 30)
            {
                msg = "Data ou Horário inválidos!";
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
            formComprovantePagamento.MostrarDadosConsultas(lblNomePaciente.Text, cmbCpfPacientes.Text, dtpDataConsulta.Value.ToString("dd/MM/yyyy HH:mm tt"),
                DoutorNome, EspecialidadeDoutor, ValorFinal.ToString(), PegarNomeConvenio(), DescontoConvenio.ToString() + "%", ValorConsulta.ToString(), ValorDesconto.ToString(), ValorFinal.ToString());

            formComprovantePagamento.ShowDialog();
            Close();
        }



        private void FormCadastroConsulta_Load(object sender, EventArgs e)
        {
            cmbCpfPacientes.DisplayMember = "NOME";
            cmbCpfPacientes.DataSource = pacienteBLL.MostrarCpfPacientes();
            cmbCpfPacientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCpfPacientes.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void cmbCpfPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNomePaciente.Text = DalPacientes.IdentificarPaciente(cmbCpfPacientes.Text);
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormConsultas formConsultas = new FormConsultas();
            Base.AbrirFormDesejado(this, formConsultas);
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



        private void PesquisarDoutorDGV()
        {
            dgvDoutores.DataSource = doutoresBLL.PesquisarEspecialidade((Especialidades)cmbEspecialidade.SelectedIndex);
            dgvDoutores.Columns["Nome"].Width = 185;
        }

        private void MostrarAgendaDoutorDGV()
        {
            dgvDoutores.DataSource = consultaBLL.AgendaDoutor(DoutorId);
            dgvDoutores.Columns["NomePaciente"].Width = 185;
            dgvDoutores.Columns["DATACONSULTA"].Width = 200;
        }
    }
}
