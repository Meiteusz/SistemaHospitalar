using SistemaHospitalar.BLL;
using SistemaHospitalar.Models;
using SistemaHospitalar.Utilities;
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
            dgvPacientes.DataSource = pacienteBLL.MostrarPacientes();
        }

        PacienteBLL pacienteBLL = new PacienteBLL();

        private void btnCadastroDePaciente_Click(object sender, EventArgs e)
        {
            FormCadastroPaciente formCadastroPaciente = new FormCadastroPaciente();
            Base.AbrirFormDesejado(this, formCadastroPaciente);
        }

        private void btnDeletarPaciente_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count != 1)
            {
                MessageBox.Show("Escolha um Paciente para deletar!");
            }
            else
            {
                string msgDeleçaoPaciente = "Deseja realmente deletar o paciente " + FuncionarioLogado.PacienteSelecionado.Nome + "?";

                if (MessageBox.Show(msgDeleçaoPaciente, "Deleção de Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show(pacienteBLL.DeletarPaciente(FuncionarioLogado.PacienteSelecionado.Id));
                    dgvPacientes.DataSource = pacienteBLL.MostrarPacientes();
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisaNome.Text.Equals(string.Empty))
                dgvPacientes.DataSource = pacienteBLL.MostrarPacientes();
            else
                dgvPacientes.DataSource = pacienteBLL.PesquisarPacientes(txtPesquisaNome.Text);
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdPaciente = (int)dgvPacientes.CurrentRow.Cells[0].Value;
            pacienteBLL.PegarDadosPaciente(IdPaciente, string.Empty);
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaNome.Visible = true;
            txtPesquisaNome.Text = "";
        }
        
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormEntradaRecepcionista formEntradaRecepcionista = new FormEntradaRecepcionista();
            Base.AbrirFormDesejado(this, formEntradaRecepcionista);
        }
    }
}
