using SistemaHospitalar.Utilities;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormDescricaoDiagnostico : Form
    {
        public FormDescricaoDiagnostico()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtDescricaoDiagnostico.Text = FuncionarioLogado.DiagnosticoTemp.Descricao;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDescricaoDiagnostico_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não é possível alterar a descrição de um diagnostico\nSe preferir, crie um novo diagnostico para este exame");
        }
    }
}
