using SistemaHospitalar.BLL;
using SistemaHospitalar.Utilities;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormValores : Form
    {
        public FormValores()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtValorConsulta.Value = (decimal)FuncionarioLogado.DoutorLogado.ValorConsulta;
            txtValorExame.Value = (decimal)FuncionarioLogado.DoutorLogado.ValorExame;
        }

        DoutoresBLL doutoresBLL = new DoutoresBLL();

        private void btnAtualizarValores_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(doutoresBLL.AtualizarValores((float)txtValorConsulta.Value, (float)txtValorExame.Value));

            FormLogin formLogin = new FormLogin();
            Base.AbrirFormDesejado(this, formLogin);
        }


        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormEntradaDoutores formEntradaDoutores = new FormEntradaDoutores();
            Base.AbrirFormDesejado(this, formEntradaDoutores);
        }
    }
}
