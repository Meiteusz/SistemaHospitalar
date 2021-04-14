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
            dtpDataConsulta.Value = FuncionarioLogado.ConsultaSelecionada.DataConsulta;
            lblNomePaciente.Text = FuncionarioLogado.ConsultaSelecionada.NomePaciente;
        }

        ConsultaBLL consultaBLL = new ConsultaBLL();

        private void btnReagendar_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.DataConsulta = dtpDataConsulta.Value;
            consulta.Id = FuncionarioLogado.ConsultaSelecionada.Id;
            consulta.Paciente = FuncionarioLogado.ConsultaSelecionada.Paciente;
            consulta.Doutor = FuncionarioLogado.ConsultaSelecionada.Doutor;

            if (consultaBLL.isDataValida(consulta))
            {
                MessageBox.Show(consultaBLL.ReagendarConsulta(dtpDataConsulta.Value, FuncionarioLogado.ConsultaSelecionada.Id));
                FormConsultas formConsultas = new FormConsultas();
                Base.AbrirFormDesejado(this, formConsultas);
            }
            else
            {
                MessageBox.Show("O doutor(a) ou o paciente selecionado já está cadastrado em uma consulta neste Dia/Horario!\nVerifique tambem se a data/horário é válida!");
            }
        }
    }
}
