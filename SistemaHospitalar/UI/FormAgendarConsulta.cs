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

        private void txtNomeDoutor_Click(object sender, EventArgs e)
        {
            txtNomeDoutor.Enabled = false;
            cmbEspecialidade.Visible = true;
            dgvDoutores.Visible = true;
            btnPesquisar.Visible = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvDoutores.DataSource = DalDoutores.PesquisarEspecialidade((Especialidades)cmbEspecialidade.SelectedIndex);
        }

        private int DoutorId { get; set; }
        private float ValorConsulta { get; set; }
        private void dgvDoutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoutorId = (int)dgvDoutores.SelectedRows[0].Cells[0].Value;
            txtNomeDoutor.Text = dgvDoutores.SelectedRows[0].Cells[1].Value.ToString();
            ValorConsulta = float.Parse(DalDoutores.PegarValorConsulta(DoutorId));
        }

        private void btnAgendarConsulta_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta(Estado_Consulta.Espera.ToString(), DalPacientes.Id, DoutorId, DateTime.Now, ValorConsulta, DateTime.Now);
            DalConsultas dalConsultas = new DalConsultas();
            MessageBox.Show(dalConsultas.CadastrarConsulta(consulta));
        }

        private void cmbCpfPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNomePaciente.Text = "Nome: " + DalPacientes.IdentificarPaciente(cmbCpfPacientes.Text);
        }
    }
}
