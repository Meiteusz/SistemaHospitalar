using SistemaHospitalar.BLL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.UI;
using System.Windows.Forms;

namespace SistemaHospitalar.Views
{
    public partial class FormLoginADM : Form
    {
        public FormLoginADM()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            txtUsuario.Text = "admin";
            txtSenha.Text = "admin";
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            AdmBLL admBLL = new AdmBLL();
            ADM adm = new ADM(txtUsuario.Text, txtSenha.Text);

            if (admBLL.LogarADM(adm).Equals(string.Empty))
            {
                FormEntradaADM formEntradaADM = new FormEntradaADM();
                Base.AbrirFormDesejado(this, formEntradaADM);
            }
            else
            {
                MessageBox.Show(admBLL.OutPut);
            }
        }
    }
}
