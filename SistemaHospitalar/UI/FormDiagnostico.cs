using SistemaHospitalar.BLL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Utilities;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormDiagnostico : Form
    {
        public FormDiagnostico()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        ExamesBLL examesbll = new ExamesBLL();

        private void btnPronto_Click(object sender, System.EventArgs e)
        {
            Diagnostico diagnostico = new Diagnostico(txtDescricaoDiagnostico.Text, FuncionarioLogado.ExameTemp.Id, DateTime.Now);

            if (txtDescricaoDiagnostico.Text.Equals(string.Empty))
            {
                MessageBox.Show("Descrição inválida");
            }
            else
            {
                MessageBox.Show(examesbll.CadastrarDiagnosticoExame(diagnostico));
                Close();
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o diagnostico do exame?", "Diagnostico", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
