using SistemaHospitalar.BLL;
using SistemaHospitalar.Models;
using SistemaHospitalar.UI;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.Views
{
    public partial class FormCadastroPaciente : Form
    {
        public FormCadastroPaciente()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cmbGeneroPaciente.DataSource = Enum.GetValues(typeof(Genero));
            cmbConvenios.DataSource = conveniosBLL.ListarConvenios();
            cmbConvenios.SelectedItem = "Nenhum";
        }

        ConveniosBLL conveniosBLL = new ConveniosBLL();
        PacienteBLL pacienteBLL = new PacienteBLL();

        private void btnCadastrarPaciente_Click(object sender, EventArgs e)
        {
            int idConvenio = pacienteBLL.PegarConvenioPeloNome(cmbConvenios.Text);

            Paciente paciente = new Paciente(txtNomePaciente.Text, mtbCpfPaciente.Text, mtbCelularPaciente.Text, (Genero)cmbGeneroPaciente.SelectedIndex, idConvenio);
            MessageBox.Show(pacienteBLL.CadastrarPaciente(paciente));
        }

        private void mtbCpfPaciente_Click(object sender, EventArgs e)
        {
            if (mtbCpfPaciente.Text.Equals("   .   .   -"))
            {
                mtbCpfPaciente.SelectionStart = mtbCpfPaciente.SelectionLength = 0;
            }
        }
        private void mtbCelularPaciente_Click(object sender, EventArgs e)
        {
            if (mtbCelularPaciente.Text.Equals("(  )      -"))
            {
                mtbCelularPaciente.SelectionStart = mtbCelularPaciente.SelectionLength = 0;
            }
        }
       
        private void btnApagar_Click(object sender, System.EventArgs e)
        {
            Base.LimparTxtEtc(Controls);
            cmbConvenios.SelectedItem = "Nenhum";
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormPacientes formPacientes = new FormPacientes();
            Base.AbrirFormDesejado(this, formPacientes);
        }
    }
}
