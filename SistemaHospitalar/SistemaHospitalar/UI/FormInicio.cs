using System;
using System.Windows.Forms;

namespace SistemaHospitalar.Views
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnVisitante_Click(object sender, EventArgs e)
        {
            FormVisitante formVisitante = new FormVisitante();
            Hide();
            formVisitante.ShowDialog();
            Close();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            Hide();
            formLogin.ShowDialog();
            Close();
        }
    }
}
