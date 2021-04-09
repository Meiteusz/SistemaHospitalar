using SistemaHospitalar.BLL;
using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;
using SistemaHospitalar.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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

            IEnumerable<Especialidades> values = Enum.GetValues(typeof(Especialidades)).Cast<Especialidades>();
            List<string> valuesWithSpaces = new List<string>(values.Select(v => v.ToString().Replace("_", " ")));
             cmbEspecialidade.DataSource = valuesWithSpaces;

            dgvFuncionarios.Columns["Email"].Width = 180;
            dgvFuncionarios.Columns["Turno"].Width = 70;
            dgvFuncionarios.Columns["Genero"].Width = 70;
        }

        DoutoresBLL doutoresBLL = new DoutoresBLL();
        RecepcionistaBLL recepcionistaBLL = new RecepcionistaBLL();

        private void rbRecepcionista_CheckedChanged_1(object sender, EventArgs e)
        {
            btnDeletarFuncionario.Text = "Deletar Recepcionista";
            rbEspecialidade.Visible = false;
            rbNome.Checked = true;
            dgvFuncionarios.DataSource = MostrarFuncionarios();
            //44
            dgvFuncionarios.Size = new Size(863, 338);
        }

        private void rbDoutor_CheckedChanged_1(object sender, EventArgs e)
        {
            btnDeletarFuncionario.Text = "Deletar Doutor(a)";
            rbEspecialidade.Visible = true;
            rbEspecialidade.Checked = true;
            dgvFuncionarios.DataSource = MostrarFuncionarios();
            dgvFuncionarios.Size = new Size(1163, 338);
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
                return DalRecepcionistas.MostrarRecepcionistas();
            else
                return DalDoutores.MostrarDoutores();
        }

        private void PopularDgvs()
        {
            if (txtPesquisa.Text.Equals(""))
                dgvFuncionarios.DataSource = MostrarFuncionarios();
            else
            {
                if (rbRecepcionista.Checked)
                    dgvFuncionarios.DataSource = DalRecepcionistas.PesquisarRecepcionistas(txtPesquisa.Text, (Turno)cmbTurno.SelectedIndex);
                else
                    dgvFuncionarios.DataSource = DalDoutores.PesquisarDoutor(txtPesquisa.Text, (Turno)cmbTurno.SelectedIndex, (Especialidades)cmbEspecialidade.SelectedIndex);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PopularDgvs();
        }

        private int Id { get; set; }

        private bool isLinhaSelecionada()
        {
            bool isSelecionada = true;
            if (dgvFuncionarios.SelectedRows.Count != 1)
                isSelecionada = false;
            return isSelecionada;
        }

        private void DeletarFuncionario()
        {
            if (MessageBox.Show("Deseja realmente deletar a conta deste(a) funcionionário?", "Deletar Funcionário(a)", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (rbRecepcionista.Checked)
                {
                    recepcionistaBLL.DeletarRecepcionista(Id);
                    dgvFuncionarios.DataSource = MostrarFuncionarios();
                }
                else
                {
                    doutoresBLL.DeletarDoutor(Id);
                    dgvFuncionarios.DataSource = MostrarFuncionarios();
                }
            }
        }

        private void btnDeletarFuncionario_Click(object sender, EventArgs e)
        {
            if (isLinhaSelecionada())
                DeletarFuncionario();
            else
                MessageBox.Show("Selecione um funcionario");
        }

        private void dgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)dgvFuncionarios.SelectedRows[0].Cells[0].Value;
        }
    }
}
