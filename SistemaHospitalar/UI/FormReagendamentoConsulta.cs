using SistemaHospitalar.BLL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Utilities;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormReagendamentoConsulta : Form
    {
        public FormReagendamentoConsulta()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dtpDataConsulta.Value = FuncionarioLogado.ConsultaTemp.DataConsulta;
            lblNomePaciente.Text = FuncionarioLogado.PacienteSelecionado.Nome;
            lblCpfPaciente.Text = FuncionarioLogado.PacienteSelecionado.Cpf;
        }

        ConsultaBLL consultaBLL = new ConsultaBLL();

        private void btnReagendar_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.DataConsulta = dtpDataConsulta.Value;
            consulta.Paciente = FuncionarioLogado.ConsultaTemp.Paciente;
            consulta.Doutor = FuncionarioLogado.ConsultaTemp.Doutor;

            if (consultaBLL.isDataValida(consulta))
            {
                MessageBox.Show(consultaBLL.ReagendarConsulta(dtpDataConsulta.Value, FuncionarioLogado.ConsultaTemp.Id));
                FormConsultas formConsultas = new FormConsultas();
                Base.AbrirFormDesejado(this, formConsultas);
            }
            else
            {
                MessageBox.Show("O doutor(a) ou o paciente selecionado já está cadastrado em uma consulta neste Dia/Horario!\nVerifique tambem se a data/horário é válida!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormConsultas formConsultas = new FormConsultas();
            Base.AbrirFormDesejado(this, formConsultas);
        }
    }
}
