using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;
using SistemaHospitalar.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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

            IEnumerable<Gravidade> values = Enum.GetValues(typeof(Gravidade)).Cast<Gravidade>();
            List<string> valuesWithSpaces = new List<string>(values.Select(v => v.ToString().Replace("_", " ")));

            cmbGravidadePaciente.DataSource = valuesWithSpaces;
            rbNao.Checked = true;

            dtpDataEntradaPaciente.Value = DateTime.Now;
            dtpDataSaidaPaciente.Value = DateTime.Now;
        }

        private void ClearTextBoxes()
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
            cmbGravidadePaciente.SelectedIndex = 0;
            mtbCpfPaciente.Text = "";
            mtbCelularPaciente.Text = "";
            mtbCelular2Paciente.Text = "";
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

        private void mtbCelular2Paciente_Click(object sender, EventArgs e)
        {
            if (mtbCelular2Paciente.Text.Equals("(  )      -"))
            {
                mtbCelular2Paciente.SelectionStart = mtbCelular2Paciente.SelectionLength = 0;
            }
        }


        //Limpa todas as TextBox
        private void btnApagar_Click(object sender, System.EventArgs e)
        {
            ClearTextBoxes();
        }

        //Cadastra um Paciente
        private void btnCadastrarPaciente_Click(object sender, EventArgs e)
        {
            DalPacientes dalPacientes = new DalPacientes();
            Paciente paciente = new Paciente(txtNomePaciente.Text, mtbCpfPaciente.Text, mtbCelularPaciente.Text, mtbCelular2Paciente.Text,
                (Genero)cmbGeneroPaciente.SelectedIndex, (Gravidade)cmbGravidadePaciente.SelectedIndex, dtpDataEntradaPaciente.Value, dtpDataSaidaPaciente.Value);

            // TEM PLANO? 0-FALSE 1-TRUE
            if (rbSim.Checked)
            {
                paciente.isPlano = true;
            }
            else if (rbNao.Checked)
            {
                paciente.isPlano = false;
            }

            MessageBox.Show(dalPacientes.Cadastrar(paciente));
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
