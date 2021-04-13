using SistemaHospitalar.BLL;
using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Utilities;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormConsultas : Form
    {
        public FormConsultas()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            rbTodas.Checked = true; ;
        }

        private void rbTodas_CheckedChanged_1(object sender, System.EventArgs e)
        {
            dgvConsultas.DataSource = DalConsultas.MostrarConsultas();
        }

        private void rbDataHoje_CheckedChanged_1(object sender, System.EventArgs e)
        {
            dgvConsultas.DataSource = DalConsultas.MostrarConsultasHoje();
        }

        private void btnAgendarConsulta_Click(object sender, System.EventArgs e)
        {
            FormAgendarConsulta formCadastroConsulta = new FormAgendarConsulta();
            Base.AbrirFormDesejado(this, formCadastroConsulta);
        }

        private void btnDeletarConsulta_Click(object sender, System.EventArgs e)
        {
            if (dgvConsultas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Escolha uma Consulta para deletar!");
            }
            else
            {
                DalConsultas dalConsultas = new DalConsultas();
                if (MessageBox.Show("Deseja realmente deletar esta Consulta?", "Deleção de Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show(dalConsultas.DeletarConsulta(FuncionarioLogado.ConsultaSelecionada.Id));
                    dgvConsultas.DataSource = DalConsultas.MostrarConsultas();
                }
            }
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormEntradaRecepcionista formEntradaRecepcionista = new FormEntradaRecepcionista();
            Base.AbrirFormDesejado(this, formEntradaRecepcionista);
        }

        private void dgvConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdConsulta = (int)dgvConsultas.SelectedRows[0].Cells[0].Value;
            DateTime DataConsulta = DateTime.ParseExact(dgvConsultas.SelectedRows[0].Cells[3].Value.ToString(), "dd/MM/yyyy HH:mm", null);
            string NomePaciente = dgvConsultas.SelectedRows[0].Cells[1].Value.ToString();

            Consulta consulta = new Consulta(IdConsulta, NomePaciente, DataConsulta);
            FuncionarioLogado.SetConsultaSelecionada(consulta);
        }

        private void btnReagendarConsulta_Click(object sender, System.EventArgs e)
        {
            if (dgvConsultas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Selecione uma consulta para o reagendamento!");
            }
            else
            {
                FormReagendamentoConsulta formReagendamentoConsulta = new FormReagendamentoConsulta();
                Base.AbrirFormDesejado(this, formReagendamentoConsulta);
            }
        }
    }
}
