using SistemaHospitalar.BLL;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormAgenda : Form
    {
        public FormAgenda()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dgvAgendaConsulta.DataSource = consultaBLL.PesquisarConsultasByData(dtpDataConsultaExame.Value.ToString("dd/MM/yyyy"));
            dgvAgendaExames.DataSource = examesBLL.PesquisarExamesByData(dtpDataConsultaExame.Value.ToString("dd/MM/yyyy"));
            dtpDataConsultaExame.Value = DateTime.Today;
        }

        ConsultaBLL consultaBLL = new ConsultaBLL();
        ExamesBLL examesBLL = new ExamesBLL();

        private void FormAgendaDoutor_Load(object sender, EventArgs e)
        {
            dgvAgendaConsulta.Columns["Doutor_Nome"].Width = 241;
            dgvAgendaConsulta.Columns["Consulta_Data"].Width = 135;
            dgvAgendaExames.Columns["Doutor_Nome"].Width = 241;
            dgvAgendaExames.Columns["Exame_Data"].Width = 135;
        }

        private void dtpDataConsultaExame_ValueChanged(object sender, EventArgs e)
        {
            dgvAgendaConsulta.DataSource = consultaBLL.PesquisarConsultasByData(dtpDataConsultaExame.Value.ToString("dd/MM/yyyy"));
            dgvAgendaExames.DataSource = examesBLL.PesquisarExamesByData(dtpDataConsultaExame.Value.ToString("dd/MM/yyyy"));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormEntradaRecepcionista formEntradaRecepcionista = new FormEntradaRecepcionista();
            Base.AbrirFormDesejado(this, formEntradaRecepcionista);
        }
    }
}
