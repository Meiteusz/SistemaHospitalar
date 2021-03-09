using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;
using SistemaHospitalar.Views;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormADM : Form
    {
        public FormADM()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            rbRecepcionista.Checked = true;
            cmbTurno.DataSource = Enum.GetValues(typeof(Turno));
            cmbEspecialidade.DataSource = Enum.GetValues(typeof(Especialidades));
        }

        private void rbRecepcionista_CheckedChanged_1(object sender, EventArgs e)
        {
            rbEspecialidade.Visible = false;
            rbNome.Checked = true;
            dgvFuncionarios.DataSource = MostrarFuncionarios();
        }

        private void rbDoutor_CheckedChanged_1(object sender, EventArgs e)
        {
            rbEspecialidade.Visible = true;
            rbEspecialidade.Checked = true;
            dgvFuncionarios.DataSource = MostrarFuncionarios();
        }

        private void btnCadastrarRecepcionista_Click(object sender, EventArgs e)
        {
            FormCadastroRecepcionista formCadastroRecepcionista = new FormCadastroRecepcionista();
            Hide();
            formCadastroRecepcionista.ShowDialog();
            Close();
        }

        private void btnCadastrarDoutor_Click(object sender, EventArgs e)
        {
            FormCadastroDoutor formCadastroDoutor = new FormCadastroDoutor();
            Hide();
            formCadastroDoutor.ShowDialog();
            Close();
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            DefaultTxtAndCMB();
            txtPesquisa.Visible = true;
            cmbEspecialidade.Visible = false;
            cmbTurno.Visible = false;
        }

        private void rbTurno_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = " ";
            cmbEspecialidade.SelectedIndex = 0;
            cmbTurno.Visible = true;
            txtPesquisa.Visible = false;
            cmbEspecialidade.Visible = false;
        }

        private void rbEspecialidade_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = " ";
            cmbTurno.SelectedIndex = 0;
            cmbEspecialidade.Visible = true;
            txtPesquisa.Visible = false;
            cmbTurno.Visible = false;
        }

        private void DefaultTxtAndCMB()
        {
            if (!txtPesquisa.Text.Equals(""))
            {
                txtPesquisa.Text = "";
            }
            if (cmbTurno.SelectedIndex > 0)
            {
                cmbTurno.SelectedIndex = 0;
            }
            if (cmbEspecialidade.SelectedIndex > 0)
            {
                cmbEspecialidade.SelectedIndex = 0;
            }
        }

        private DataTable MostrarFuncionarios()
        {
            if (rbRecepcionista.Checked)
            {
                btnDeletarDoutor.Visible = false;
                btnDeletarRecepcionista.Visible = true;
                return DalRecepionistas.MostrarRecepcionistas();
            }
            else
            {
                btnDeletarDoutor.Visible = true;
                btnDeletarRecepcionista.Visible = false;
                return DalDoutores.MostrarDoutores();
            }
        }

        private void PopularDgvs()
        {
            if (txtPesquisa.Text.Equals(""))
                dgvFuncionarios.DataSource = MostrarFuncionarios();
            else
            {
                if (rbRecepcionista.Checked)
                    dgvFuncionarios.DataSource = DalRecepionistas.PesquisarRecepcionistas(txtPesquisa.Text, (Turno)cmbTurno.SelectedIndex);
                else
                    dgvFuncionarios.DataSource = DalDoutores.PesquisarDoutor(txtPesquisa.Text, (Turno)cmbTurno.SelectedIndex, (Especialidades)cmbEspecialidade.SelectedIndex);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PopularDgvs();
        }
    }
}
