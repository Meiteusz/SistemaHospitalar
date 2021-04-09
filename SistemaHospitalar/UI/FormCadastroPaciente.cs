using SistemaHospitalar.BLL;
using SistemaHospitalar.DAL;
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
            cmbConvenios.DataSource = DalConvenios.MostrarNomeConvenios();
            cmbConvenios.SelectedItem = "Nenhum";
        }

        PacienteBLL pacienteBLL = new PacienteBLL();

        private void LimparTextBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            cmbGeneroPaciente.SelectedIndex = 0;
            cmbConvenios.SelectedItem = "Nenhum";
            mtbCpfPaciente.Text = "";
            mtbCelularPaciente.Text = "";
            func(Controls);
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


        //Limpa todas as TextBox
        private void btnApagar_Click(object sender, System.EventArgs e)
        {
            LimparTextBox();
        }


        //Cadastra um Paciente
        private void btnCadastrarPaciente_Click(object sender, EventArgs e)
        {
            DalPacientes dalPacientes = new DalPacientes();

            int idConvenio = dalPacientes.DetectarConvenio(cmbConvenios.Text);

            Paciente paciente = new Paciente(txtNomePaciente.Text, mtbCpfPaciente.Text, mtbCelularPaciente.Text, (Genero)cmbGeneroPaciente.SelectedIndex, idConvenio);
            MessageBox.Show(pacienteBLL.CadastrarPaciente(paciente));
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormPacientes formPacientes = new FormPacientes();
            Hide();
            formPacientes.ShowDialog();
            Close();
        }
    }
}
