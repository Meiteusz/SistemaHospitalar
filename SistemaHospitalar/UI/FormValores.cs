using SistemaHospitalar.BLL;
using SistemaHospitalar.DAL;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormValores : Form
    {
        public FormValores()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtValorConsulta.Value = decimal.Parse(DalDoutores.ValorConsulta);
            txtValorExame.Value = decimal.Parse(DalDoutores.ValorExame);
        }

        private void btnAtualizarValores_Click(object sender, System.EventArgs e)
        {
            DalDoutores dalDoutores = new DalDoutores();
            MessageBox.Show(dalDoutores.UpdateValores((float)txtValorConsulta.Value, (float)txtValorExame.Value));
            dalDoutores.PegarValoresDoutor(DalDoutores.Email, DalDoutores.Senha);
        }


        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormEntradaDoutores formEntradaDoutores = new FormEntradaDoutores();
            Base.VoltarFormAnterior(this, formEntradaDoutores);
        }
    }
}
