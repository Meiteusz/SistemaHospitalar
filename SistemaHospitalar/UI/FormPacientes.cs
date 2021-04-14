using SistemaHospitalar.BLL;
using SistemaHospitalar.Models;
using SistemaHospitalar.Views;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormPacientes : Form
    {
        public FormPacientes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dgvPacientes.DataSource = DalPacientes.MostrarPacientesDGV();
        }

        PacienteBLL pacienteBLL = new PacienteBLL();

        private void btnCadastroDePaciente_Click(object sender, EventArgs e)
        {
            FormCadastroPaciente formCadastroPaciente = new FormCadastroPaciente();
            Hide();
            formCadastroPaciente.ShowDialog();
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisaNome.Text.Equals(""))
                dgvPacientes.DataSource = DalPacientes.MostrarPacientesDGV();
            else
                dgvPacientes.DataSource = DalPacientes.PesquisarPaciente(txtPesquisaNome.Text);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormEntradaRecepcionista formEntradaRecepcionista = new FormEntradaRecepcionista();
            Hide();
            formEntradaRecepcionista.ShowDialog();
            Close();
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaNome.Visible = true;
            txtPesquisaNome.Text = "";
        }

        private int Id { get; set; }
        private string Nome { get; set; }

        private void btnDeletarPaciente_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count != 1)
            {
                MessageBox.Show("Escolha um Paciente para deletar!");
            }
            else
            {
                string msgDeleçaoPaciente = "Deseja realmente deletar o paciente " + Nome + "?";

                if (MessageBox.Show(msgDeleçaoPaciente, "Deleção de Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show(pacienteBLL.DeletarPaciente(Id));
                    dgvPacientes.DataSource = DalPacientes.MostrarPacientesDGV();
                }
            }
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)dgvPacientes.SelectedRows[0].Cells[0].Value;
            Nome = dgvPacientes.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
