using SistemaHospitalar.DAL;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormReagendamentoConsulta : Form
    {
        public FormReagendamentoConsulta()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dtpDataConsulta.Value = DateTime.Parse(DalConsultas.DataConsulta, CultureInfo.CreateSpecificCulture("fr-FR"));
            lblNomePaciente.Text = DalConsultas.NomePaciente;
            lblCpfPaciente.Text = DalConsultas.PegarCpfPaciente(DalConsultas.PegarIdConsulta(DalConsultas.Id));
        }

        private void btnReagendar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos().Equals(""))
            {
                if (DalConsultas.isDataConsultaValido(dtpDataConsulta.Value, DalConsultas.PegarIdPaciente(DalConsultas.Id), DalConsultas.PegarIdDoutor(DalConsultas.Id)))
                {
                    DalConsultas dalConsultas = new DalConsultas();
                    MessageBox.Show(dalConsultas.ReagendarConsulta(dtpDataConsulta.Value, DalConsultas.Id));

                    FormConsultas formConsultas = new FormConsultas();
                    Hide();
                    formConsultas.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("O doutor(a) ou o paciente selecionado já está cadastrado em uma consulta neste Dia/Horario!\nVerifique tambem se a data/horário é válida!");
                }
            }
            else
            {
                MessageBox.Show(msgErro);
            }
        }

        private string msgErro = "";
        private string ValidarCampos()
        {
            if (dtpDataConsulta.Value <= DateTime.Now || dtpDataConsulta.Value.DayOfWeek.Equals(DayOfWeek.Saturday) || dtpDataConsulta.Value.DayOfWeek.Equals(DayOfWeek.Sunday) 
                || dtpDataConsulta.Value.Hour > 23 || dtpDataConsulta.Value.Hour < 7)
            {
                msgErro = "Data Inválida!";
            }
            else
            {
                msgErro = "";
            }
            return msgErro;
        }
    }
}
