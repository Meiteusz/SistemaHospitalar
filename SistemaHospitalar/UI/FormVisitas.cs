using SistemaHospitalar.BLL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Utilities;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormVisitas : Form
    {
        public FormVisitas()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dtpDataVisita.Value = DateTime.Now;
            dgvVisitas.DataSource = visitasBLL.MostrarVisitas();
        }

        VisitasBLL visitasBLL = new VisitasBLL();
        PacienteBLL pacienteBLL = new PacienteBLL();
        InternacaoBLL internacaoBLL = new InternacaoBLL();

        private void btnAgendarVisita_Click(object sender, EventArgs e)
        {
            Visita visita = new Visita(FuncionarioLogado.VisitanteSelecionado.Id, dtpDataVisita.Value, internacaoBLL.PegarIdInternacaoPeloIdPaciente(FuncionarioLogado.PacienteSelecionado.Id));

            MessageBox.Show(visitasBLL.AgendarVisita(visita));
            dgvVisitas.DataSource = visitasBLL.MostrarVisitas();
        }

        private void FormVisitas_Load(object sender, EventArgs e)
        {
            dgvVisitas.Columns["ID"].Width = 50;
            dgvVisitas.Columns["Nome_Paciente"].Width = 200;
            dgvVisitas.Columns["Nome_Visitante"].Width = 200;
            dgvVisitas.Columns["Numero_Quarto"].Width = 110;
            dgvVisitas.Columns["Data_Visita"].Width = 103;

            cmbVisitantes.DataSource = visitasBLL.MostrarCpfVisitantes();
            cmbVisitantes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbVisitantes.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbPacientes.DataSource = pacienteBLL.MostrarCpfPacientesInternados();
            cmbPacientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbPacientes.AutoCompleteSource = AutoCompleteSource.ListItems;

            txtNomeVisitante.AutoCompleteCustomSource = visitasBLL.MostrarNomesVisitantes();
            txtNomeVisitante.AutoCompleteMode = AutoCompleteMode.Append;
            txtNomeVisitante.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void cbVisitantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            visitasBLL.PegarDadosVisitante(0, cmbVisitantes.Text);
            lblNomeVisitante.Text = FuncionarioLogado.VisitanteSelecionado.Nome;
        }

        private void cbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacienteBLL.PegarDadosPaciente(0, cmbPacientes.Text);
            lblNomePaciente.Text = FuncionarioLogado.PacienteSelecionado.Nome;
        }

        private void txtNomeVisitante_TextChanged(object sender, EventArgs e)
        {
            if (txtNomeVisitante.Text.Equals(string.Empty))
            {
                dgvVisitas.DataSource = visitasBLL.MostrarVisitas();
            }
            else
            {
                dgvVisitas.DataSource = visitasBLL.PesquisarVisitante(txtNomeVisitante.Text);
            }
        }

        private void btnCadastrarVisitante_Click(object sender, EventArgs e)
        {
            FormVisitantes formVisitantes = new FormVisitantes();
            Base.AbrirFormDesejado(this, formVisitantes);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormEntradaRecepcionista formEntradaRecepcionista = new FormEntradaRecepcionista();
            Base.AbrirFormDesejado(this, formEntradaRecepcionista);
        }
    }
}
