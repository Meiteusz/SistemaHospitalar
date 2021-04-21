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
            dgvVisitas.Columns["ID"].Width = 60;
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
            cmbVisitantes.DataSource = visitasBLL.MostrarCpfVisitantes();
            cmbVisitantes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbVisitantes.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbPacientes.DataSource = pacienteBLL.MostrarCpfPacientesInternados();
            cmbPacientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbPacientes.AutoCompleteSource = AutoCompleteSource.ListItems;
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormEntradaRecepcionista formEntradaRecepcionista = new FormEntradaRecepcionista();
            Base.AbrirFormDesejado(this, formEntradaRecepcionista);
        }
    }
}
