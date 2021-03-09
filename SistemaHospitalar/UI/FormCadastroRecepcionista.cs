using SistemaHospitalar.DAL;
using SistemaHospitalar.Models;
using SistemaHospitalar.UI;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.Views
{
    public partial class FormCadastroRecepcionista : Form
    {
        public FormCadastroRecepcionista()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cmbTurnoRecepcionista.DataSource = Enum.GetValues(typeof(Turno));
            cmbGeneroRecepcionista.DataSource = Enum.GetValues(typeof(Genero));
        }

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
            cmbGeneroRecepcionista.SelectedIndex = 0;
            cmbTurnoRecepcionista.SelectedIndex = 0;
            MtbCpfRecepcionista.Text = "";
            MtbCelularRecepcionista.Text = "";
            func(Controls);
        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked)
            {
                txtSenhaRecepcionista.UseSystemPasswordChar = false;
                txtRepitaSenhaRecepcionista.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenhaRecepcionista.UseSystemPasswordChar = true;
                txtRepitaSenhaRecepcionista.UseSystemPasswordChar = true;
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void txtMaskedCpfRecepcionista_Click(object sender, EventArgs e)
        {
            if (MtbCpfRecepcionista.Text.Equals("   .   .   -"))
            {
                MtbCpfRecepcionista.SelectionStart = MtbCpfRecepcionista.SelectionLength = 0;
            }
        }

        private void txtMaskedCelularRecepcionista_Click(object sender, EventArgs e)
        {
            if (MtbCelularRecepcionista.Text.Equals("(  )      -"))
            {
                MtbCelularRecepcionista.SelectionStart = MtbCelularRecepcionista.SelectionLength = 0;
            }
        }

        //Cadastra um novo recepcionista
        private void btnCadastrarRecepcionista_Click(object sender, System.EventArgs e)
        {
            Recepcionista recepcionista = new Recepcionista(txtNomeRecepcionista.Text, MtbCpfRecepcionista.Text, MtbCelularRecepcionista.Text,
            (Turno)cmbTurnoRecepcionista.SelectedIndex, (Genero)cmbGeneroRecepcionista.SelectedIndex, txtEmailRecepcionista.Text, txtSenhaRecepcionista.Text);

            DalRecepionistas dalRecepionistas = new DalRecepionistas();
            MessageBox.Show(dalRecepionistas.Cadastrar(recepcionista, txtRepitaSenhaRecepcionista.Text));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormADM formADM = new FormADM();
            Hide();
            formADM.ShowDialog();
            Close();
        }
    }
}
