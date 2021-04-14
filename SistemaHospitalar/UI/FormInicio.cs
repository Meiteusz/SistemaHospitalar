using SistemaHospitalar.BLL;
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
            Base.AbrirFormDesejado(this, formVisitante);
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            Base.AbrirFormDesejado(this, formLogin);
        }
    }
}
