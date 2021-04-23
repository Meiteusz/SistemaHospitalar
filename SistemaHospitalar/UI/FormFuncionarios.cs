using SistemaHospitalar.BLL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;
using SistemaHospitalar.Utilities;
using SistemaHospitalar.Views;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormFuncionarios : Form
    {
        public FormFuncionarios()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            rbRecepcionista.Checked = true;

            cmbTurno.DataSource = Enum.GetValues(typeof(Turno));
            cmbEspecialidade.DataSource = Enum.GetValues(typeof(Especialidades));

            btnDeletarFuncionario.Enabled = false;
            dgvFuncionarios.Columns["NOME"].Width = 200;
            dgvFuncionarios.Columns["Turno"].Width = 70;
            dgvFuncionarios.Columns["Genero"].Width = 70;
        }

        DoutoresBLL doutoresBLL = new DoutoresBLL();
        RecepcionistaBLL recepcionistaBLL = new RecepcionistaBLL();

        private void rbRecepcionista_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbEspecialidade.Enabled = false;
            btnDeletarFuncionario.Text = "Deletar Recepcionista";
            dgvFuncionarios.DataSource = recepcionistaBLL.MostrarRecepcionistas();
        }

        private void rbDoutor_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbEspecialidade.Enabled = true;
            btnDeletarFuncionario.Text = "Deletar Doutor(a)";
            dgvFuncionarios.DataSource = doutoresBLL.MostrarDoutores();
        }

        private void btnCadastrarRecepcionista_Click(object sender, EventArgs e)
        {
            FormCadastroRecepcionista formCadastroRecepcionista = new FormCadastroRecepcionista();
            Base.AbrirFormDesejado(this, formCadastroRecepcionista);
        }

        private void btnCadastrarDoutor_Click(object sender, EventArgs e)
        {
            FormCadastroDoutor formCadastroDoutor = new FormCadastroDoutor();
            Base.AbrirFormDesejado(this, formCadastroDoutor);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PopularDgvs();
        }

        private void btnDeletarFuncionario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente deletar a conta deste(a) funcionionário?", "Deletar Funcionário(a)", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (rbRecepcionista.Checked)
                {
                    MessageBox.Show(recepcionistaBLL.DeletarRecepcionista(FuncionarioLogado.RecepcionistaLogada.Id));
                    dgvFuncionarios.DataSource = recepcionistaBLL.MostrarRecepcionistas();
                }
                else if (rbDoutor.Checked)
                {
                    MessageBox.Show(doutoresBLL.DeletarDoutor(FuncionarioLogado.DoutorLogado.Id));
                    dgvFuncionarios.DataSource = doutoresBLL.MostrarDoutores();
                }
            }
        }

        private void dgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeletarFuncionario.Enabled = true;
            if (rbRecepcionista.Checked)
            {
                Recepcionista recepcionista = new Recepcionista();
                recepcionista.Id = (int)dgvFuncionarios.CurrentRow.Cells[0].Value;
                FuncionarioLogado.SetFuncionarioLogado(recepcionista);
            }
            else if (rbDoutor.Checked)
            {
                Doutores doutores = new Doutores();
                doutores.Id = (int)dgvFuncionarios.CurrentRow.Cells[0].Value;
                FuncionarioLogado.SetFuncionarioLogado(doutores);
            }
        }

        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            Base.LimparTxtEtc(Controls);
            if (rbRecepcionista.Checked)
            {
                dgvFuncionarios.DataSource = recepcionistaBLL.MostrarRecepcionistas();
            }
            else if (rbDoutor.Checked)
            {
                dgvFuncionarios.DataSource = doutoresBLL.MostrarDoutores();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormEntradaADM formEntradaADM = new FormEntradaADM();
            Base.AbrirFormDesejado(this, formEntradaADM);
        }

        private void PopularDgvs()
        {
            if (rbRecepcionista.Checked)
            {
                dgvFuncionarios.DataSource = recepcionistaBLL.PesquisarRecepcionistas(txtPesquisa.Text, (Turno)cmbTurno.SelectedIndex);
            }
            else
            {
                dgvFuncionarios.DataSource = doutoresBLL.PesquisarDoutores(txtPesquisa.Text, (Turno)cmbTurno.SelectedIndex, (Especialidades)cmbEspecialidade.SelectedIndex);
            }
        }
    }
}
