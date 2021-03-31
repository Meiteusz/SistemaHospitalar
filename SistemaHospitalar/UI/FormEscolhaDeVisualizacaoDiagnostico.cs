using SistemaHospitalar.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormEscolhaDeVisualizacaoDiagnostico : Form
    {
        public FormEscolhaDeVisualizacaoDiagnostico()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (rbEmail.Checked)
            {
                Validator validator = new Validator();
                if (!validator.ValidarEmail(txtEmailPaciente.Text).Equals(""))
                {
                    MessageBox.Show("Email inválido!");
                }
                else
                {
                    MessageBox.Show("Diagóstico enviado! 🗸");
                    FormConsultasDoutor formConsultasDoutor = new FormConsultasDoutor();
                    Hide();
                    formConsultasDoutor.ShowDialog();
                    Close();
                }
            }
            else
            {

            }
        }

        private void rbEmail_CheckedChanged(object sender, EventArgs e)
        {
            gpEmailPaciente.Visible = true;
        }

        private void rbImpressao_CheckedChanged(object sender, EventArgs e)
        {
            gpEmailPaciente.Visible = false;
        }
    }
}
