using SistemaHospitalar.BLL;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormEntradaADM : Form
    {
        public FormEntradaADM()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            FormFuncionarios formFuncionarios = new FormFuncionarios();
            Base.AbrirFormDesejado(this, formFuncionarios);
        }

        private void btnConvenios_Click(object sender, EventArgs e)
        {
            FormConvenios formConvenios = new FormConvenios();
            Base.AbrirFormDesejado(this, formConvenios);
        }
    }
}
