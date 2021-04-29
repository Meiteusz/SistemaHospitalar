using SistemaHospitalar.BLL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Utilities;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormReagendamentoExame : Form
    {
        public FormReagendamentoExame()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            lblNomePaciente.Text = FuncionarioLogado.PacienteSelecionado.Nome;
            lblCpfPaciente.Text = FuncionarioLogado.PacienteSelecionado.Cpf;
            dtpDataExame.Value = FuncionarioLogado.ExameTemp.DataExame;
        }

        ExamesBLL examesBLL = new ExamesBLL();

        private void btnReagendar_Click(object sender, System.EventArgs e)
        {
            Exame exame = new Exame();

            exame.ConsultaId = FuncionarioLogado.ConsultaTemp.Id;
            exame.DataExame = dtpDataExame.Value;

            if (examesBLL.isDataExameValido(exame))
            {
                MessageBox.Show(examesBLL.ReagendarExame(exame.DataExame, FuncionarioLogado.ExameTemp.Id));
                FormExames formExames = new FormExames();
                Base.AbrirFormDesejado(this, formExames);
            }
            else
            {
                MessageBox.Show("Paciente/Doutor selecionado já está cadastrado em uma consulta/exame neste Horário.\nVerifique também se a data/horário é válida!", "Agendamento de exame inválido");
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            FormExames formExames = new FormExames();
            Base.AbrirFormDesejado(this, formExames);
        }
    }
}
