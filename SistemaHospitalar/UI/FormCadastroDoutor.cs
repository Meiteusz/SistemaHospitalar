using SistemaHospitalar.BLL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;
using SistemaHospitalar.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaHospitalar.Views
{
    public partial class FormCadastroDoutor : Form
    {
        public FormCadastroDoutor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cmbTurnoDoutor.DataSource = Enum.GetValues(typeof(Turno));
            cmbGeneroDoutor.DataSource = Enum.GetValues(typeof(Genero));

            IEnumerable<Especialidades> values = Enum.GetValues(typeof(Especialidades)).Cast<Especialidades>();
            List<string> valuesWithSpaces = new List<string>(values.Select(v => v.ToString().Replace("_", " ")));
            cmbEspecialidadeDoutor.DataSource = valuesWithSpaces;
        }

        DoutoresBLL doutorBLL = new DoutoresBLL();

        //Limpa todas as TextBox
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
            cmbGeneroDoutor.SelectedIndex = 0;
            cmbTurnoDoutor.SelectedIndex = 0;
            cmbEspecialidadeDoutor.SelectedIndex = 0;
            txtMaskedCpfDoutor.Text = "";
            txtMaskedCelularDoutor.Text = "";
            func(Controls);
        }

        private void cbMostrarSenha_CheckedChanged(object sender, System.EventArgs e)
        {
            if (cbMostrarSenha.Checked)
            {
                txtSenhaDoutor.UseSystemPasswordChar = false;
                txtRepitaSenhaDoutor.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenhaDoutor.UseSystemPasswordChar = true;
                txtRepitaSenhaDoutor.UseSystemPasswordChar = true;
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void txtMaskedCpfDoutor_Click(object sender, EventArgs e)
        {
            txtMaskedCpfDoutor.SelectionStart = txtMaskedCpfDoutor.SelectionLength = 0;
        }

        private void txtMaskedCelularDoutor_Click(object sender, EventArgs e)
        {
            txtMaskedCelularDoutor.SelectionStart = txtMaskedCelularDoutor.SelectionLength = 0;
        }


        private void btnCadastrarDoutor_Click(object sender, EventArgs e)
        {
            Doutores doutor = new Doutores(txtNomeDoutor.Text, txtEmailDoutor.Text, txtSenhaDoutor.Text, txtMaskedCpfDoutor.Text, (Turno)cmbTurnoDoutor.SelectedIndex,
           (Genero)cmbGeneroDoutor.SelectedIndex, (Especialidades)cmbEspecialidadeDoutor.SelectedIndex, txtMaskedCelularDoutor.Text, (float)txtValorConsulta.Value, (float)txtValorExame.Value);

            MessageBox.Show(doutorBLL.CadastrarDoutor(doutor, txtRepitaSenhaDoutor.Text));
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormFuncionarios formADM = new FormFuncionarios();
            Base.VoltarFormAnterior(this, formADM);
        }
    }
}
